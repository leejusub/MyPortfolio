using MaterialSkin;
using MaterialSkin.Controls;
using SemanticVersioning;
using SplashScreen.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Version = SemanticVersioning.Version;

namespace UniversalPowerMonitor
{
    public partial class MainForm : MaterialForm
    {
        MaterialSkinManager matSkinManager = MaterialSkinManager.Instance;
        public DBHelper_SQLite dbManager;
        public PerformanceChecker pChecker = new PerformanceChecker();
        public NetworkChecker netChecker = new NetworkChecker();

        public string country = "";

        public MainForm()
        {
            var range = new Range("~1.2.3");
            var version = new Version("1.0.0");

            Splash();
            InitializeComponent();

            this.Icon = Properties.Resources.AppIcon;   // 앱 아이콘 수동 설정
            //this.Font = new Font(FontLibrary.Families[0], 12);    // 폼 폰트 수동 설정
            this.Width = 1300;
            this.Height = 700;

            ntfIcon.Icon = Properties.Resources.AppIcon;

            Properties.Settings.Default.Language = "en-US";
            Properties.Settings.Default.Theme = "Light";
            Properties.Settings.Default.Save();

            matCB1.Items.AddRange(new string[]
            {
                Properties.Resources.List_AllCategory_Item0,
                Properties.Resources.List_Category_Item0,
                Properties.Resources.List_Category_Item1,
                Properties.Resources.List_Category_Item2
            });
            this.matCB1.SelectedIndexChanged += new EventHandler(this.matCB1_SelectedIndexChanged);
            if (matCB1.Items.Count > 0) matCB1.SelectedIndex = 0;

            dbManager = new DBHelper_SQLite();
            dbManager.CopyDatabaseFile(Path.Combine(Application.StartupPath, "PUBLIC_DATA.db"));
        }

        private void Splash()
        {
            var splasher = new Splasher("Universal Power Monitor", "v1.0.0");

            splasher.Show();

            Thread.Sleep(3000); //HeavyMethod

            if(this.Enabled == true)
            {
                splasher.Close();
            }

            //Call Activate() because the MainForm is going backwards.
            this.Activate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Activate();
            timer.Start();
            ThemeChanger();
            ChartVisualizer();
            CheckInternetConnection();
            matCB_DBLoc.SelectedIndex = 0;
            this.matBtn_Refresh.Text = "더보기";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exitConfirmator = MessageBox.Show(Properties.Resources.App_ExitConfirm_Message,
                Properties.Resources.App_ExitConfirm_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exitConfirmator == DialogResult.Yes) { Application.ExitThread(); } else { e.Cancel = true; }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fProc = pProc.NextValue();
            float fMem = pMem.NextValue();
            TSSI_ProcSt.Value = (int)fProc;
            TSSI_MemSt.Value = (int)fMem;
            CheckInternetConnection();
            BatteryStatus();
        }

        private void CheckInternetConnection()
        {
            if (netChecker.IsInternetConnected())
            {
                TSSI_NetSt.Text = "ONLINE";
                TSSI_NetSt.ForeColor = Color.Green;
            }
            else
            {
                TSSI_NetSt.Text = "OFFLINE";
                TSSI_NetSt.ForeColor = Color.Red;
            }
        }

        private void BatteryStatus()
        {
            int estimatedChargeRemaining = pChecker.GetEstimatedChargeRemaining();
            int estimatedRunTime = pChecker.GetEstimatedRunTime();

            TSSI_BattSt.Value = estimatedChargeRemaining;
            TSSI_BattLS.Text = estimatedRunTime + " hr";
        }

        private void LoadDataFromSQLite()
        {
            try
            {
                string query = "SELECT * FROM POWER_PLANTS"; // 실행할 쿼리
                var dataTable = dbManager.LoadData(query);
                dgv_TotalResult.DataSource = dataTable; // DataGridView에 데이터 표시
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadMetroDataToComboBox()
        {
            try
            {
                var metroData = dbManager.LoadMetroData(); // "metro" 컬럼 데이터 불러오기
                matCB_Metro.Items.Clear(); // 기존 항목을 모두 제거
                foreach (var metroValue in metroData)
                {
                    matCB_Metro.Items.Add(metroValue); // 새 항목 추가
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //추가된 코드로 db 연동 차트 구현 메서드임
        private void LoadDataFromMSSQL()
        {
            try
            {
                // DBHelper_MSSQL 클래스 인스턴스 생성
                DBHelper_MSSQL dbManager = DBHelper_MSSQL.getInstance;

                // DBHelper_MSSQL 클래스의 DoQuery() 메서드 호출하여 데이터 가져오기
                dbManager.DoQuery();

                // 가져온 데이터를 차트에 바인딩
                DataTable dataTable = dbManager.dt;
                cht_PwrProd1.DataSource = dataTable;

                // 시리즈 추가 (먼저 추가해야 함)
                cht_PwrProd1.Series.Clear();
                cht_PwrProd1.Series.Add("생산량");
                cht_PwrProd1.Series.Add("발전량");
                cht_PwrProd1.Series.Add("누적보급량");

                // 시리즈 설정
                cht_PwrProd1.Series["생산량"].XValueMember = "metro";
                cht_PwrProd1.Series["생산량"].YValueMembers = "toe";
                cht_PwrProd1.Series["생산량"].ChartType = SeriesChartType.Line;

                cht_PwrProd1.Series["발전량"].XValueMember = "metro";
                cht_PwrProd1.Series["발전량"].YValueMembers = "MWh";
                cht_PwrProd1.Series["발전량"].ChartType = SeriesChartType.Line;

                cht_PwrProd1.Series["누적보급량"].XValueMember = "metro";
                cht_PwrProd1.Series["누적보급량"].YValueMembers = "kWTotal";
                cht_PwrProd1.Series["누적보급량"].ChartType = SeriesChartType.Line;

                cht_PwrProd1.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadProductionDataAndDisplayTotals()
        {
            // DBHelper_MSSQL 클래스 인스턴스 생성
            DBHelper_MSSQL dbManager = DBHelper_MSSQL.getInstance;

            // DBHelper_MSSQL 클래스의 DoQuery() 메서드 호출하여 데이터 가져오기
            dbManager.DoQuery();

            // 가져온 데이터의 총합 계산
            int totalGeneration = 0;
            int totalSupplyCapacity = 0;
            int totalProduction = 0;

            foreach (DataRow row in dbManager.dt.Rows)
            {
                totalGeneration += Convert.ToInt32(row["Mwh"]);
                totalSupplyCapacity += Convert.ToInt32(row["kWTotal"]);
                totalProduction += Convert.ToInt32(row["toe"]);
            }

            // 각 항목의 총합을 라벨에 표시
            lbl_Gen1.Text = totalGeneration.ToString();
            lbl_SpCapT1.Text = totalSupplyCapacity.ToString();
            lbl_Prod1.Text = totalProduction.ToString();
        }

        private void LoadConsumptionDataAndDisplayChart()
        {
            // 임의의 데이터 생성
            Random random = new Random();
            List<int> storageCapacity = new List<int>();
            List<int> generation = new List<int>();
            List<int> idlePower = new List<int>();
            List<int> consumption = new List<int>();

            int totalStorageCapacity = 0;
            int totalGeneration = 0;
            int totalIdlePower = 0;
            int totalConsumption = 0;

            for (int i = 0; i < 10; i++)
            {
                int sc = random.Next(1000, 2000);
                int gen = random.Next(800, 1500);
                int ip = random.Next(100, 500);
                int cons = random.Next(700, 1300);

                storageCapacity.Add(sc);
                generation.Add(gen);
                idlePower.Add(ip);
                consumption.Add(cons);

                totalStorageCapacity += sc;
                totalGeneration += gen;
                totalIdlePower += ip;
                totalConsumption += cons;
            }

            // 차트에 데이터 추가
            cht_PwrCons1.Series.Clear();
            cht_PwrCons1.Series.Add("Storage Capacity");
            cht_PwrCons1.Series.Add("Generation");
            cht_PwrCons1.Series.Add("Idle Power");
            cht_PwrCons1.Series.Add("Consumption");

            for (int i = 0; i < storageCapacity.Count; i++)
            {
                cht_PwrCons1.Series["Storage Capacity"].Points.AddY(storageCapacity[i]);
                cht_PwrCons1.Series["Generation"].Points.AddY(generation[i]);
                cht_PwrCons1.Series["Idle Power"].Points.AddY(idlePower[i]);
                cht_PwrCons1.Series["Consumption"].Points.AddY(consumption[i]);
            }

            // 각 항목의 총합을 라벨에 표시
            lbl_Cons1.Text = totalStorageCapacity.ToString();
            label14.Text = totalGeneration.ToString();
            label15.Text = totalIdlePower.ToString();
            label16.Text = totalConsumption.ToString();

            // 범례 설정
            cht_PwrCons1.Series["Storage Capacity"].LegendText = "저장용량";
            cht_PwrCons1.Series["Generation"].LegendText = "발전량";
            cht_PwrCons1.Series["Idle Power"].LegendText = "유휴 전력";
            cht_PwrCons1.Series["Consumption"].LegendText = "소비량";
        }

        // 테마 변경
        private void ThemeChanger()
        {
            if (Properties.Settings.Default.Theme == "Light")
            {
                matSkinManager.AddFormToManage(this);
                matSkinManager.EnforceBackcolorOnAllComponents = true;
                matSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                matSkinManager.ColorScheme = new ColorScheme(
                    Primary.LightBlue800,
                    Primary.LightBlue900,
                    Primary.LightBlue500,
                    Accent.Cyan700,
                    TextShade.WHITE
                ); IconTheme_Light();
            }
            else if (Properties.Settings.Default.Theme == "Dark")
            {
                matSkinManager.AddFormToManage(this);
                matSkinManager.EnforceBackcolorOnAllComponents = true;
                matSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                matSkinManager.ColorScheme = new ColorScheme(
                    Primary.LightBlue800,
                    Primary.LightBlue900,
                    Primary.LightBlue500,
                    Accent.Cyan200,
                    TextShade.WHITE
                ); IconTheme_Dark();
            }
        }

        // 아이콘 테마 변경
        private void IconTheme_Light()
        {
            // Do something
        }

        private void IconTheme_Dark()
        {
            // Do something
        }

        // 언어 변경
        private void LocaleChanger()
        {
            if (Properties.Settings.Default.Language == "en-US")
            {

            }
            else if (Properties.Settings.Default.Language == "ko-KR")
            {

            }
        }

        // 차트 뷰어
        private void ChartVisualizer()
        {
            
        }

        // 메뉴바 이벤트 핸들러
        private void TSMI_App_Pref_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_App_Refresh_Click(object sender, EventArgs e)
        {
            
        }

        private void TSMI_App_Restart_Click(object sender, EventArgs e)
        {
            DialogResult restartConfirmator = MessageBox.Show(Properties.Resources.App_RestartConfirm_Message,
                Properties.Resources.App_RestartConfirm_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (restartConfirmator == DialogResult.Yes) { Application.Restart(); }
        }

        private void TSMI_App_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSMI_View_QuickTheme_LT_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = "Light";
            Properties.Settings.Default.Save();
            ThemeChanger();
        }

        private void TSMI_View_QuickTheme_DT_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = "Dark";
            Properties.Settings.Default.Save();
            ThemeChanger();
        }

        private void TSMI_View_QuickTheme_OpenPref_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_View_QuickLocale_ENG_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "en-US";
            Properties.Settings.Default.Save();
            LocaleChanger();
        }

        private void TSMI_View_QuickLocale_KOR_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "ko-KR";
            Properties.Settings.Default.Save();
            LocaleChanger();
        }

        private void TSMI_View_QuickLocale_JPN_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_View_QuickLocale_OpenPref_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Help_About_Click(object sender, EventArgs e)
        {
            AppAboutBox aboutBox = new AppAboutBox();
            aboutBox.ShowDialog();
        }

        private void TSMI_Help_Homepage_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Help_Wiki_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Help_Update_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Help_Changelog_Click(object sender, EventArgs e)
        {

        }

        // 메인 화면 이벤트 핸들러
        private void matCB_DBLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matCB_DBLoc.SelectedIndex == 0)
            {
                matBtn_Add.Enabled = false;
                matBtn_Edit.Enabled = false;
                matBtn_Remove.Enabled = false;

                matBtn_Add.BackColor = Color.Gray;
                matBtn_Edit.BackColor = Color.Gray;
                matBtn_Remove.BackColor = Color.Gray;
            }
            else if (matCB_DBLoc.SelectedIndex == 1)
            {
                matBtn_Add.Enabled = true;
                matBtn_Edit.Enabled = true;
                matBtn_Remove.Enabled = true;

                matBtn_Add.BackColor = Color.FromArgb(0, 191, 255);
                matBtn_Edit.BackColor = Color.FromArgb(0, 191, 255);
                matBtn_Remove.BackColor = Color.FromArgb(0, 191, 255);
            }
        }

        private void matBtn_Connect_Click(object sender, EventArgs e)
        {
            if (matCB_DBLoc.SelectedIndex == 0)
            {// 온라인 DB 연결
                try
                {
                    LoadProductionDataAndDisplayTotals();
                    LoadConsumptionDataAndDisplayChart();
                    LoadDataFromMSSQL();
                    dgv_TotalResult.DataSource = DataManager.ppList;
                    MessageBox.Show(Properties.Resources.App_InfoMessage_Content_DBConnection+
                        "\n"+Properties.Resources.App_InfoMessage_Content_DBServiceName1,
                        Properties.Resources.App_InfoMessage_Title_DBConnection,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error loading production data: " + ex.Message);
                    DialogResult result = MessageBox.Show(Properties.Resources.App_ErrorMessage_Content_DBConnection+
                        Properties.Resources.App_InfoMessage_Content_DBServiceName1+
                        "\n\n"+Properties.Resources.App_Shared_ErrorMessage_AskRetry,
                        Properties.Resources.App_InfoMessage_Title_DBConnection,
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else if (matCB_DBLoc.SelectedIndex == 1)
            {// 오프라인 파일 불러오기
                try
                {
                    LoadProductionDataAndDisplayTotals();
                    LoadConsumptionDataAndDisplayChart();
                    LoadDataFromMSSQL();
                    LoadDataFromSQLite();
                    LoadMetroDataToComboBox();
                    MessageBox.Show(Properties.Resources.App_InfoMessage_Content_DBConnection +
                        "\n"+Properties.Resources.App_InfoMessage_Content_DBServiceName2,
                        Properties.Resources.App_InfoMessage_Title_DBConnection,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error loading production data: " + ex.Message);
                    DialogResult result = MessageBox.Show(Properties.Resources.App_ErrorMessage_Content_DBConnection +
                        Properties.Resources.App_InfoMessage_Content_DBServiceName2 +
                        "\n\n" + Properties.Resources.App_Shared_ErrorMessage_AskRetry,
                        Properties.Resources.App_InfoMessage_Title_DBConnection,
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            
        }

        private void matBtn_Refresh_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void matBtn_Add_Click(object sender, EventArgs e)
        {

        }

        private void matBtn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void matBtn_Remove_Click(object sender, EventArgs e)
        {

        }

        private void matCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            matCB2.Items.Clear();

            switch (matCB1.SelectedIndex)
            {
                case 0:
                    matCB2.Items.AddRange(new string[]
                    {
                        Properties.Resources.List_AllCategory_Item0
                    });
                    break;
                case 1:
                    matCB2.Items.AddRange(new string[]
                    {
                        Properties.Resources.List_AllCategory_Item0,
                        Properties.Resources.List_SubCategory1_Item0,
                        Properties.Resources.List_SubCategory1_Item1,
                        Properties.Resources.List_SubCategory1_Item2,
                        Properties.Resources.List_SubCategory1_Item3,
                        Properties.Resources.List_SubCategory1_Item4,
                        Properties.Resources.List_SubCategory1_Item5
                    });
                    break;
                case 2:
                    matCB2.Items.AddRange(new string[]
                    {
                        Properties.Resources.List_AllCategory_Item0,
                        Properties.Resources.List_SubCategory2_Item0,
                        Properties.Resources.List_SubCategory2_Item1,
                        Properties.Resources.List_SubCategory2_Item2,
                        Properties.Resources.List_SubCategory2_Item3,
                        Properties.Resources.List_SubCategory2_Item4,
                        Properties.Resources.List_SubCategory2_Item5,
                        Properties.Resources.List_SubCategory2_Item6,
                        Properties.Resources.List_SubCategory2_Item7,
                        Properties.Resources.List_SubCategory2_Item8
                    });
                    break;
                case 3:
                    matCB2.Items.AddRange(new string[]
                    {
                        Properties.Resources.List_AllCategory_Item0,
                        Properties.Resources.List_SubCategory3_Item0,
                        Properties.Resources.List_SubCategory3_Item1,
                        Properties.Resources.List_SubCategory3_Item2,
                        Properties.Resources.List_SubCategory3_Item3,
                        Properties.Resources.List_SubCategory3_Item4
                    });
                    break;
            }

            if (matCB2.Items.Count > 0) matCB2.SelectedIndex = 0;
        }

        private void matCB2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void matTB_Country_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
