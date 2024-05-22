namespace UniversalPowerMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnStrip = new System.Windows.Forms.MenuStrip();
            this.TSMI_App = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_App_Pref = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_App_Sp1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_App_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_App_Sp2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_App_Restart = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_App_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_QuickTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_QuickTheme_LT = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_QuickTheme_DT = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_QuickTheme_OpenPref = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_QuickLocale = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_QuickLocale_ENG = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_QuickLocale_KOR = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_QuickLocale_JPN = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_QuickLocale_OpenPref = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_Sp1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_View_Spare1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_Spare2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_Spare3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Tool_Spare1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Tool_Spare2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Tool_Spare3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Tool_Spare4 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Window = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Window_Spare1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Window_Spare2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Homepage = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Wiki = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Sp1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Help_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Changelog = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Sp2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Help_Debug = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Debug_DevMode = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Debug_Sp1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Help_Debug_ViewRTLog = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Debug_RecordRTLog = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Debug_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.stStrip = new System.Windows.Forms.StatusStrip();
            this.TSSI_ProcLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_ProcSt = new System.Windows.Forms.ToolStripProgressBar();
            this.TSSI_Sp1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_MemLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_MemSt = new System.Windows.Forms.ToolStripProgressBar();
            this.TSSI_Sp2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_NetLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_NetSt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_Sp3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_LocLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_LocName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_Sp4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_ProdLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_ProdSt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_Sp5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_ConsLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_ConsSt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_Sp6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_BattLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSI_BattSt = new System.Windows.Forms.ToolStripProgressBar();
            this.TSSI_BattLS = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgProc = new System.ComponentModel.BackgroundWorker();
            this.iconList_AUTO24 = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ntfIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pProc = new System.Diagnostics.PerformanceCounter();
            this.pMem = new System.Diagnostics.PerformanceCounter();
            this.tabP4 = new System.Windows.Forms.TabPage();
            this.tblLP_D1 = new System.Windows.Forms.TableLayoutPanel();
            this.gBox_D1 = new System.Windows.Forms.GroupBox();
            this.matLV_GenSrcList = new MaterialSkin.Controls.MaterialListView();
            this.matTB_Search = new MaterialSkin.Controls.MaterialTextBox2();
            this.gBox_D2 = new System.Windows.Forms.GroupBox();
            this.wb_Map = new System.Windows.Forms.WebBrowser();
            this.tabP3 = new System.Windows.Forms.TabPage();
            this.tblLP_C1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabP2 = new System.Windows.Forms.TabPage();
            this.tblLP_B1 = new System.Windows.Forms.TableLayoutPanel();
            this.cht_PwrProd2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.matCB_Metro = new MaterialSkin.Controls.MaterialComboBox();
            this.tabP1 = new System.Windows.Forms.TabPage();
            this.tblLP_A1 = new System.Windows.Forms.TableLayoutPanel();
            this.gBox_A4 = new System.Windows.Forms.GroupBox();
            this.splC_A2 = new System.Windows.Forms.SplitContainer();
            this.tblLP_A4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.lbl14 = new System.Windows.Forms.Label();
            this.lbl15 = new System.Windows.Forms.Label();
            this.lbl_Cons1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cht_PwrCons1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gBox_A3 = new System.Windows.Forms.GroupBox();
            this.dgv_TotalResult = new System.Windows.Forms.DataGridView();
            this.gBox_A1 = new System.Windows.Forms.GroupBox();
            this.tblLP_A2 = new System.Windows.Forms.TableLayoutPanel();
            this.matEP_A1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.tblLP_A5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.matTB_State = new MaterialSkin.Controls.MaterialTextBox2();
            this.matTB_Country = new MaterialSkin.Controls.MaterialTextBox2();
            this.matTB_City = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtp_Timestamp = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.matCB_DBLoc = new MaterialSkin.Controls.MaterialComboBox();
            this.matBtn_Connect = new MaterialSkin.Controls.MaterialButton();
            this.matBtn_Refresh = new MaterialSkin.Controls.MaterialButton();
            this.matBtn_Add = new MaterialSkin.Controls.MaterialButton();
            this.matBtn_Edit = new MaterialSkin.Controls.MaterialButton();
            this.matBtn_Remove = new MaterialSkin.Controls.MaterialButton();
            this.lbl7 = new System.Windows.Forms.Label();
            this.matTB5 = new MaterialSkin.Controls.MaterialTextBox2();
            this.lbl5 = new System.Windows.Forms.Label();
            this.matCB1 = new MaterialSkin.Controls.MaterialComboBox();
            this.matCB2 = new MaterialSkin.Controls.MaterialComboBox();
            this.gBox_A2 = new System.Windows.Forms.GroupBox();
            this.splC_A1 = new System.Windows.Forms.SplitContainer();
            this.tblLP_A3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl_Gen1 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl_SpCapT1 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl_Prod1 = new System.Windows.Forms.Label();
            this.cht_PwrProd1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.matTabC = new MaterialSkin.Controls.MaterialTabControl();
            this.mnStrip.SuspendLayout();
            this.stStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMem)).BeginInit();
            this.tabP4.SuspendLayout();
            this.tblLP_D1.SuspendLayout();
            this.gBox_D1.SuspendLayout();
            this.gBox_D2.SuspendLayout();
            this.tabP3.SuspendLayout();
            this.tabP2.SuspendLayout();
            this.tblLP_B1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_PwrProd2)).BeginInit();
            this.tabP1.SuspendLayout();
            this.tblLP_A1.SuspendLayout();
            this.gBox_A4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splC_A2)).BeginInit();
            this.splC_A2.Panel1.SuspendLayout();
            this.splC_A2.Panel2.SuspendLayout();
            this.splC_A2.SuspendLayout();
            this.tblLP_A4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_PwrCons1)).BeginInit();
            this.gBox_A3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TotalResult)).BeginInit();
            this.gBox_A1.SuspendLayout();
            this.tblLP_A2.SuspendLayout();
            this.matEP_A1.SuspendLayout();
            this.tblLP_A5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gBox_A2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splC_A1)).BeginInit();
            this.splC_A1.Panel1.SuspendLayout();
            this.splC_A1.Panel2.SuspendLayout();
            this.splC_A1.SuspendLayout();
            this.tblLP_A3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_PwrProd1)).BeginInit();
            this.matTabC.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnStrip
            // 
            this.mnStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_App,
            this.TSMI_View,
            this.TSMI_Tool,
            this.TSMI_Window,
            this.TSMI_Help});
            resources.ApplyResources(this.mnStrip, "mnStrip");
            this.mnStrip.Name = "mnStrip";
            // 
            // TSMI_App
            // 
            this.TSMI_App.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_App_Pref,
            this.TSMI_App_Sp1,
            this.TSMI_App_Refresh,
            this.TSMI_App_Sp2,
            this.TSMI_App_Restart,
            this.TSMI_App_Close});
            this.TSMI_App.Name = "TSMI_App";
            resources.ApplyResources(this.TSMI_App, "TSMI_App");
            // 
            // TSMI_App_Pref
            // 
            this.TSMI_App_Pref.Name = "TSMI_App_Pref";
            resources.ApplyResources(this.TSMI_App_Pref, "TSMI_App_Pref");
            this.TSMI_App_Pref.Click += new System.EventHandler(this.TSMI_App_Pref_Click);
            // 
            // TSMI_App_Sp1
            // 
            this.TSMI_App_Sp1.Name = "TSMI_App_Sp1";
            resources.ApplyResources(this.TSMI_App_Sp1, "TSMI_App_Sp1");
            // 
            // TSMI_App_Refresh
            // 
            this.TSMI_App_Refresh.Name = "TSMI_App_Refresh";
            resources.ApplyResources(this.TSMI_App_Refresh, "TSMI_App_Refresh");
            this.TSMI_App_Refresh.Click += new System.EventHandler(this.TSMI_App_Refresh_Click);
            // 
            // TSMI_App_Sp2
            // 
            this.TSMI_App_Sp2.Name = "TSMI_App_Sp2";
            resources.ApplyResources(this.TSMI_App_Sp2, "TSMI_App_Sp2");
            // 
            // TSMI_App_Restart
            // 
            this.TSMI_App_Restart.Name = "TSMI_App_Restart";
            resources.ApplyResources(this.TSMI_App_Restart, "TSMI_App_Restart");
            this.TSMI_App_Restart.Click += new System.EventHandler(this.TSMI_App_Restart_Click);
            // 
            // TSMI_App_Close
            // 
            this.TSMI_App_Close.Name = "TSMI_App_Close";
            resources.ApplyResources(this.TSMI_App_Close, "TSMI_App_Close");
            this.TSMI_App_Close.Click += new System.EventHandler(this.TSMI_App_Close_Click);
            // 
            // TSMI_View
            // 
            this.TSMI_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_View_QuickTheme,
            this.TSMI_View_QuickLocale,
            this.TSMI_View_Sp1,
            this.TSMI_View_Spare1,
            this.TSMI_View_Spare2,
            this.TSMI_View_Spare3});
            this.TSMI_View.Name = "TSMI_View";
            resources.ApplyResources(this.TSMI_View, "TSMI_View");
            // 
            // TSMI_View_QuickTheme
            // 
            this.TSMI_View_QuickTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_View_QuickTheme_LT,
            this.TSMI_View_QuickTheme_DT,
            this.TSMI_View_QuickTheme_OpenPref});
            this.TSMI_View_QuickTheme.Name = "TSMI_View_QuickTheme";
            resources.ApplyResources(this.TSMI_View_QuickTheme, "TSMI_View_QuickTheme");
            // 
            // TSMI_View_QuickTheme_LT
            // 
            this.TSMI_View_QuickTheme_LT.Name = "TSMI_View_QuickTheme_LT";
            resources.ApplyResources(this.TSMI_View_QuickTheme_LT, "TSMI_View_QuickTheme_LT");
            this.TSMI_View_QuickTheme_LT.Click += new System.EventHandler(this.TSMI_View_QuickTheme_LT_Click);
            // 
            // TSMI_View_QuickTheme_DT
            // 
            this.TSMI_View_QuickTheme_DT.Name = "TSMI_View_QuickTheme_DT";
            resources.ApplyResources(this.TSMI_View_QuickTheme_DT, "TSMI_View_QuickTheme_DT");
            this.TSMI_View_QuickTheme_DT.Click += new System.EventHandler(this.TSMI_View_QuickTheme_DT_Click);
            // 
            // TSMI_View_QuickTheme_OpenPref
            // 
            this.TSMI_View_QuickTheme_OpenPref.Name = "TSMI_View_QuickTheme_OpenPref";
            resources.ApplyResources(this.TSMI_View_QuickTheme_OpenPref, "TSMI_View_QuickTheme_OpenPref");
            this.TSMI_View_QuickTheme_OpenPref.Click += new System.EventHandler(this.TSMI_View_QuickTheme_OpenPref_Click);
            // 
            // TSMI_View_QuickLocale
            // 
            this.TSMI_View_QuickLocale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_View_QuickLocale_ENG,
            this.TSMI_View_QuickLocale_KOR,
            this.TSMI_View_QuickLocale_JPN,
            this.TSMI_View_QuickLocale_OpenPref});
            this.TSMI_View_QuickLocale.Name = "TSMI_View_QuickLocale";
            resources.ApplyResources(this.TSMI_View_QuickLocale, "TSMI_View_QuickLocale");
            // 
            // TSMI_View_QuickLocale_ENG
            // 
            this.TSMI_View_QuickLocale_ENG.Name = "TSMI_View_QuickLocale_ENG";
            resources.ApplyResources(this.TSMI_View_QuickLocale_ENG, "TSMI_View_QuickLocale_ENG");
            this.TSMI_View_QuickLocale_ENG.Click += new System.EventHandler(this.TSMI_View_QuickLocale_ENG_Click);
            // 
            // TSMI_View_QuickLocale_KOR
            // 
            this.TSMI_View_QuickLocale_KOR.Name = "TSMI_View_QuickLocale_KOR";
            resources.ApplyResources(this.TSMI_View_QuickLocale_KOR, "TSMI_View_QuickLocale_KOR");
            this.TSMI_View_QuickLocale_KOR.Click += new System.EventHandler(this.TSMI_View_QuickLocale_KOR_Click);
            // 
            // TSMI_View_QuickLocale_JPN
            // 
            resources.ApplyResources(this.TSMI_View_QuickLocale_JPN, "TSMI_View_QuickLocale_JPN");
            this.TSMI_View_QuickLocale_JPN.Name = "TSMI_View_QuickLocale_JPN";
            this.TSMI_View_QuickLocale_JPN.Click += new System.EventHandler(this.TSMI_View_QuickLocale_JPN_Click);
            // 
            // TSMI_View_QuickLocale_OpenPref
            // 
            this.TSMI_View_QuickLocale_OpenPref.Name = "TSMI_View_QuickLocale_OpenPref";
            resources.ApplyResources(this.TSMI_View_QuickLocale_OpenPref, "TSMI_View_QuickLocale_OpenPref");
            this.TSMI_View_QuickLocale_OpenPref.Click += new System.EventHandler(this.TSMI_View_QuickLocale_OpenPref_Click);
            // 
            // TSMI_View_Sp1
            // 
            this.TSMI_View_Sp1.Name = "TSMI_View_Sp1";
            resources.ApplyResources(this.TSMI_View_Sp1, "TSMI_View_Sp1");
            // 
            // TSMI_View_Spare1
            // 
            resources.ApplyResources(this.TSMI_View_Spare1, "TSMI_View_Spare1");
            this.TSMI_View_Spare1.Name = "TSMI_View_Spare1";
            // 
            // TSMI_View_Spare2
            // 
            resources.ApplyResources(this.TSMI_View_Spare2, "TSMI_View_Spare2");
            this.TSMI_View_Spare2.Name = "TSMI_View_Spare2";
            // 
            // TSMI_View_Spare3
            // 
            resources.ApplyResources(this.TSMI_View_Spare3, "TSMI_View_Spare3");
            this.TSMI_View_Spare3.Name = "TSMI_View_Spare3";
            // 
            // TSMI_Tool
            // 
            this.TSMI_Tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Tool_Spare1,
            this.TSMI_Tool_Spare2,
            this.TSMI_Tool_Spare3,
            this.TSMI_Tool_Spare4});
            this.TSMI_Tool.Name = "TSMI_Tool";
            resources.ApplyResources(this.TSMI_Tool, "TSMI_Tool");
            // 
            // TSMI_Tool_Spare1
            // 
            resources.ApplyResources(this.TSMI_Tool_Spare1, "TSMI_Tool_Spare1");
            this.TSMI_Tool_Spare1.Name = "TSMI_Tool_Spare1";
            // 
            // TSMI_Tool_Spare2
            // 
            resources.ApplyResources(this.TSMI_Tool_Spare2, "TSMI_Tool_Spare2");
            this.TSMI_Tool_Spare2.Name = "TSMI_Tool_Spare2";
            // 
            // TSMI_Tool_Spare3
            // 
            resources.ApplyResources(this.TSMI_Tool_Spare3, "TSMI_Tool_Spare3");
            this.TSMI_Tool_Spare3.Name = "TSMI_Tool_Spare3";
            // 
            // TSMI_Tool_Spare4
            // 
            resources.ApplyResources(this.TSMI_Tool_Spare4, "TSMI_Tool_Spare4");
            this.TSMI_Tool_Spare4.Name = "TSMI_Tool_Spare4";
            // 
            // TSMI_Window
            // 
            this.TSMI_Window.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Window_Spare1,
            this.TSMI_Window_Spare2});
            this.TSMI_Window.Name = "TSMI_Window";
            resources.ApplyResources(this.TSMI_Window, "TSMI_Window");
            // 
            // TSMI_Window_Spare1
            // 
            resources.ApplyResources(this.TSMI_Window_Spare1, "TSMI_Window_Spare1");
            this.TSMI_Window_Spare1.Name = "TSMI_Window_Spare1";
            // 
            // TSMI_Window_Spare2
            // 
            resources.ApplyResources(this.TSMI_Window_Spare2, "TSMI_Window_Spare2");
            this.TSMI_Window_Spare2.Name = "TSMI_Window_Spare2";
            // 
            // TSMI_Help
            // 
            this.TSMI_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Help_About,
            this.TSMI_Help_Homepage,
            this.TSMI_Help_Wiki,
            this.TSMI_Help_Sp1,
            this.TSMI_Help_Update,
            this.TSMI_Help_Changelog,
            this.TSMI_Help_Sp2,
            this.TSMI_Help_Debug});
            this.TSMI_Help.Name = "TSMI_Help";
            resources.ApplyResources(this.TSMI_Help, "TSMI_Help");
            // 
            // TSMI_Help_About
            // 
            this.TSMI_Help_About.Name = "TSMI_Help_About";
            resources.ApplyResources(this.TSMI_Help_About, "TSMI_Help_About");
            this.TSMI_Help_About.Click += new System.EventHandler(this.TSMI_Help_About_Click);
            // 
            // TSMI_Help_Homepage
            // 
            this.TSMI_Help_Homepage.Name = "TSMI_Help_Homepage";
            resources.ApplyResources(this.TSMI_Help_Homepage, "TSMI_Help_Homepage");
            this.TSMI_Help_Homepage.Click += new System.EventHandler(this.TSMI_Help_Homepage_Click);
            // 
            // TSMI_Help_Wiki
            // 
            this.TSMI_Help_Wiki.Name = "TSMI_Help_Wiki";
            resources.ApplyResources(this.TSMI_Help_Wiki, "TSMI_Help_Wiki");
            this.TSMI_Help_Wiki.Click += new System.EventHandler(this.TSMI_Help_Wiki_Click);
            // 
            // TSMI_Help_Sp1
            // 
            this.TSMI_Help_Sp1.Name = "TSMI_Help_Sp1";
            resources.ApplyResources(this.TSMI_Help_Sp1, "TSMI_Help_Sp1");
            // 
            // TSMI_Help_Update
            // 
            this.TSMI_Help_Update.Name = "TSMI_Help_Update";
            resources.ApplyResources(this.TSMI_Help_Update, "TSMI_Help_Update");
            this.TSMI_Help_Update.Click += new System.EventHandler(this.TSMI_Help_Update_Click);
            // 
            // TSMI_Help_Changelog
            // 
            this.TSMI_Help_Changelog.Name = "TSMI_Help_Changelog";
            resources.ApplyResources(this.TSMI_Help_Changelog, "TSMI_Help_Changelog");
            this.TSMI_Help_Changelog.Click += new System.EventHandler(this.TSMI_Help_Changelog_Click);
            // 
            // TSMI_Help_Sp2
            // 
            this.TSMI_Help_Sp2.Name = "TSMI_Help_Sp2";
            resources.ApplyResources(this.TSMI_Help_Sp2, "TSMI_Help_Sp2");
            // 
            // TSMI_Help_Debug
            // 
            this.TSMI_Help_Debug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Help_Debug_DevMode,
            this.TSMI_Help_Debug_Sp1,
            this.TSMI_Help_Debug_ViewRTLog,
            this.TSMI_Help_Debug_RecordRTLog,
            this.TSMI_Help_Debug_Report});
            this.TSMI_Help_Debug.Name = "TSMI_Help_Debug";
            resources.ApplyResources(this.TSMI_Help_Debug, "TSMI_Help_Debug");
            // 
            // TSMI_Help_Debug_DevMode
            // 
            this.TSMI_Help_Debug_DevMode.Name = "TSMI_Help_Debug_DevMode";
            resources.ApplyResources(this.TSMI_Help_Debug_DevMode, "TSMI_Help_Debug_DevMode");
            // 
            // TSMI_Help_Debug_Sp1
            // 
            this.TSMI_Help_Debug_Sp1.Name = "TSMI_Help_Debug_Sp1";
            resources.ApplyResources(this.TSMI_Help_Debug_Sp1, "TSMI_Help_Debug_Sp1");
            // 
            // TSMI_Help_Debug_ViewRTLog
            // 
            this.TSMI_Help_Debug_ViewRTLog.Name = "TSMI_Help_Debug_ViewRTLog";
            resources.ApplyResources(this.TSMI_Help_Debug_ViewRTLog, "TSMI_Help_Debug_ViewRTLog");
            // 
            // TSMI_Help_Debug_RecordRTLog
            // 
            this.TSMI_Help_Debug_RecordRTLog.Name = "TSMI_Help_Debug_RecordRTLog";
            resources.ApplyResources(this.TSMI_Help_Debug_RecordRTLog, "TSMI_Help_Debug_RecordRTLog");
            // 
            // TSMI_Help_Debug_Report
            // 
            this.TSMI_Help_Debug_Report.Name = "TSMI_Help_Debug_Report";
            resources.ApplyResources(this.TSMI_Help_Debug_Report, "TSMI_Help_Debug_Report");
            // 
            // stStrip
            // 
            this.stStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSI_ProcLbl,
            this.TSSI_ProcSt,
            this.TSSI_Sp1,
            this.TSSI_MemLbl,
            this.TSSI_MemSt,
            this.TSSI_Sp2,
            this.TSSI_NetLbl,
            this.TSSI_NetSt,
            this.TSSI_Sp3,
            this.TSSI_LocLbl,
            this.TSSI_LocName,
            this.TSSI_Sp4,
            this.TSSI_ProdLbl,
            this.TSSI_ProdSt,
            this.TSSI_Sp5,
            this.TSSI_ConsLbl,
            this.TSSI_ConsSt,
            this.TSSI_Sp6,
            this.TSSI_BattLbl,
            this.TSSI_BattSt,
            this.TSSI_BattLS});
            this.stStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            resources.ApplyResources(this.stStrip, "stStrip");
            this.stStrip.Name = "stStrip";
            this.stStrip.SizingGrip = false;
            this.stStrip.Stretch = false;
            // 
            // TSSI_ProcLbl
            // 
            this.TSSI_ProcLbl.Name = "TSSI_ProcLbl";
            resources.ApplyResources(this.TSSI_ProcLbl, "TSSI_ProcLbl");
            // 
            // TSSI_ProcSt
            // 
            this.TSSI_ProcSt.Name = "TSSI_ProcSt";
            resources.ApplyResources(this.TSSI_ProcSt, "TSSI_ProcSt");
            // 
            // TSSI_Sp1
            // 
            this.TSSI_Sp1.Name = "TSSI_Sp1";
            resources.ApplyResources(this.TSSI_Sp1, "TSSI_Sp1");
            // 
            // TSSI_MemLbl
            // 
            this.TSSI_MemLbl.Name = "TSSI_MemLbl";
            resources.ApplyResources(this.TSSI_MemLbl, "TSSI_MemLbl");
            // 
            // TSSI_MemSt
            // 
            this.TSSI_MemSt.Name = "TSSI_MemSt";
            resources.ApplyResources(this.TSSI_MemSt, "TSSI_MemSt");
            // 
            // TSSI_Sp2
            // 
            this.TSSI_Sp2.Name = "TSSI_Sp2";
            resources.ApplyResources(this.TSSI_Sp2, "TSSI_Sp2");
            // 
            // TSSI_NetLbl
            // 
            this.TSSI_NetLbl.Name = "TSSI_NetLbl";
            resources.ApplyResources(this.TSSI_NetLbl, "TSSI_NetLbl");
            // 
            // TSSI_NetSt
            // 
            resources.ApplyResources(this.TSSI_NetSt, "TSSI_NetSt");
            this.TSSI_NetSt.Name = "TSSI_NetSt";
            // 
            // TSSI_Sp3
            // 
            this.TSSI_Sp3.Name = "TSSI_Sp3";
            resources.ApplyResources(this.TSSI_Sp3, "TSSI_Sp3");
            // 
            // TSSI_LocLbl
            // 
            this.TSSI_LocLbl.Name = "TSSI_LocLbl";
            resources.ApplyResources(this.TSSI_LocLbl, "TSSI_LocLbl");
            // 
            // TSSI_LocName
            // 
            this.TSSI_LocName.Name = "TSSI_LocName";
            resources.ApplyResources(this.TSSI_LocName, "TSSI_LocName");
            // 
            // TSSI_Sp4
            // 
            this.TSSI_Sp4.Name = "TSSI_Sp4";
            resources.ApplyResources(this.TSSI_Sp4, "TSSI_Sp4");
            // 
            // TSSI_ProdLbl
            // 
            this.TSSI_ProdLbl.Name = "TSSI_ProdLbl";
            resources.ApplyResources(this.TSSI_ProdLbl, "TSSI_ProdLbl");
            // 
            // TSSI_ProdSt
            // 
            this.TSSI_ProdSt.Name = "TSSI_ProdSt";
            resources.ApplyResources(this.TSSI_ProdSt, "TSSI_ProdSt");
            // 
            // TSSI_Sp5
            // 
            this.TSSI_Sp5.Name = "TSSI_Sp5";
            resources.ApplyResources(this.TSSI_Sp5, "TSSI_Sp5");
            // 
            // TSSI_ConsLbl
            // 
            this.TSSI_ConsLbl.Name = "TSSI_ConsLbl";
            resources.ApplyResources(this.TSSI_ConsLbl, "TSSI_ConsLbl");
            // 
            // TSSI_ConsSt
            // 
            this.TSSI_ConsSt.Name = "TSSI_ConsSt";
            resources.ApplyResources(this.TSSI_ConsSt, "TSSI_ConsSt");
            // 
            // TSSI_Sp6
            // 
            this.TSSI_Sp6.Name = "TSSI_Sp6";
            resources.ApplyResources(this.TSSI_Sp6, "TSSI_Sp6");
            // 
            // TSSI_BattLbl
            // 
            this.TSSI_BattLbl.Name = "TSSI_BattLbl";
            resources.ApplyResources(this.TSSI_BattLbl, "TSSI_BattLbl");
            // 
            // TSSI_BattSt
            // 
            this.TSSI_BattSt.Name = "TSSI_BattSt";
            resources.ApplyResources(this.TSSI_BattSt, "TSSI_BattSt");
            this.TSSI_BattSt.Value = 50;
            // 
            // TSSI_BattLS
            // 
            this.TSSI_BattLS.Name = "TSSI_BattLS";
            resources.ApplyResources(this.TSSI_BattLS, "TSSI_BattLS");
            // 
            // iconList_AUTO24
            // 
            this.iconList_AUTO24.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList_AUTO24.ImageStream")));
            this.iconList_AUTO24.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList_AUTO24.Images.SetKeyName(0, "icon_total_status_LT.ico");
            this.iconList_AUTO24.Images.SetKeyName(1, "icon_power_production_LT.ico");
            this.iconList_AUTO24.Images.SetKeyName(2, "icon_power_consumption_LT.ico");
            this.iconList_AUTO24.Images.SetKeyName(3, "icon_gensrc_location_LT.ico");
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ntfIcon
            // 
            resources.ApplyResources(this.ntfIcon, "ntfIcon");
            // 
            // pProc
            // 
            this.pProc.CategoryName = "Processor";
            this.pProc.CounterName = "% Processor Time";
            this.pProc.InstanceName = "_Total";
            // 
            // pMem
            // 
            this.pMem.CategoryName = "Memory";
            this.pMem.CounterName = "% Committed Bytes In Use";
            // 
            // tabP4
            // 
            this.tabP4.Controls.Add(this.tblLP_D1);
            resources.ApplyResources(this.tabP4, "tabP4");
            this.tabP4.Name = "tabP4";
            this.tabP4.UseVisualStyleBackColor = true;
            // 
            // tblLP_D1
            // 
            resources.ApplyResources(this.tblLP_D1, "tblLP_D1");
            this.tblLP_D1.Controls.Add(this.gBox_D1, 0, 0);
            this.tblLP_D1.Controls.Add(this.gBox_D2, 1, 0);
            this.tblLP_D1.Name = "tblLP_D1";
            // 
            // gBox_D1
            // 
            this.gBox_D1.Controls.Add(this.matLV_GenSrcList);
            this.gBox_D1.Controls.Add(this.matTB_Search);
            resources.ApplyResources(this.gBox_D1, "gBox_D1");
            this.gBox_D1.Name = "gBox_D1";
            this.gBox_D1.TabStop = false;
            // 
            // matLV_GenSrcList
            // 
            this.matLV_GenSrcList.AutoSizeTable = false;
            this.matLV_GenSrcList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matLV_GenSrcList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matLV_GenSrcList.Depth = 0;
            resources.ApplyResources(this.matLV_GenSrcList, "matLV_GenSrcList");
            this.matLV_GenSrcList.FullRowSelect = true;
            this.matLV_GenSrcList.HideSelection = false;
            this.matLV_GenSrcList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("matLV_GenSrcList.Items"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("matLV_GenSrcList.Items1"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("matLV_GenSrcList.Items2")))});
            this.matLV_GenSrcList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matLV_GenSrcList.MouseState = MaterialSkin.MouseState.OUT;
            this.matLV_GenSrcList.Name = "matLV_GenSrcList";
            this.matLV_GenSrcList.OwnerDraw = true;
            this.matLV_GenSrcList.UseCompatibleStateImageBehavior = false;
            this.matLV_GenSrcList.View = System.Windows.Forms.View.Details;
            // 
            // matTB_Search
            // 
            this.matTB_Search.AnimateReadOnly = false;
            resources.ApplyResources(this.matTB_Search, "matTB_Search");
            this.matTB_Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.matTB_Search.Depth = 0;
            this.matTB_Search.HideSelection = true;
            this.matTB_Search.LeadingIcon = null;
            this.matTB_Search.MaxLength = 32767;
            this.matTB_Search.MouseState = MaterialSkin.MouseState.OUT;
            this.matTB_Search.Name = "matTB_Search";
            this.matTB_Search.PasswordChar = '\0';
            this.matTB_Search.ReadOnly = false;
            this.matTB_Search.SelectedText = "";
            this.matTB_Search.SelectionLength = 0;
            this.matTB_Search.SelectionStart = 0;
            this.matTB_Search.ShortcutsEnabled = true;
            this.matTB_Search.TabStop = false;
            this.matTB_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.matTB_Search.TrailingIcon = null;
            this.matTB_Search.UseSystemPasswordChar = false;
            // 
            // gBox_D2
            // 
            this.gBox_D2.Controls.Add(this.wb_Map);
            resources.ApplyResources(this.gBox_D2, "gBox_D2");
            this.gBox_D2.Name = "gBox_D2";
            this.gBox_D2.TabStop = false;
            // 
            // wb_Map
            // 
            resources.ApplyResources(this.wb_Map, "wb_Map");
            this.wb_Map.Name = "wb_Map";
            // 
            // tabP3
            // 
            this.tabP3.Controls.Add(this.tblLP_C1);
            resources.ApplyResources(this.tabP3, "tabP3");
            this.tabP3.Name = "tabP3";
            this.tabP3.UseVisualStyleBackColor = true;
            // 
            // tblLP_C1
            // 
            resources.ApplyResources(this.tblLP_C1, "tblLP_C1");
            this.tblLP_C1.Name = "tblLP_C1";
            // 
            // tabP2
            // 
            this.tabP2.Controls.Add(this.tblLP_B1);
            resources.ApplyResources(this.tabP2, "tabP2");
            this.tabP2.Name = "tabP2";
            this.tabP2.UseVisualStyleBackColor = true;
            // 
            // tblLP_B1
            // 
            resources.ApplyResources(this.tblLP_B1, "tblLP_B1");
            this.tblLP_B1.Controls.Add(this.cht_PwrProd2, 0, 1);
            this.tblLP_B1.Controls.Add(this.matCB_Metro, 0, 0);
            this.tblLP_B1.Name = "tblLP_B1";
            // 
            // cht_PwrProd2
            // 
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.Name = "ChartArea1";
            this.cht_PwrProd2.ChartAreas.Add(chartArea1);
            resources.ApplyResources(this.cht_PwrProd2, "cht_PwrProd2");
            legend1.Name = "Legend1";
            this.cht_PwrProd2.Legends.Add(legend1);
            this.cht_PwrProd2.Name = "cht_PwrProd2";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.DeepSkyBlue;
            series1.Legend = "Legend1";
            series1.Name = "GEN";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Orange;
            series2.Legend = "Legend1";
            series2.Name = "ASC";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.MediumSpringGreen;
            series3.Legend = "Legend1";
            series3.Name = "TOE";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.cht_PwrProd2.Series.Add(series1);
            this.cht_PwrProd2.Series.Add(series2);
            this.cht_PwrProd2.Series.Add(series3);
            // 
            // matCB_Metro
            // 
            this.matCB_Metro.AutoResize = false;
            this.matCB_Metro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matCB_Metro.Depth = 0;
            this.matCB_Metro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.matCB_Metro.DropDownHeight = 174;
            this.matCB_Metro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matCB_Metro.DropDownWidth = 121;
            resources.ApplyResources(this.matCB_Metro, "matCB_Metro");
            this.matCB_Metro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matCB_Metro.FormattingEnabled = true;
            this.matCB_Metro.MouseState = MaterialSkin.MouseState.OUT;
            this.matCB_Metro.Name = "matCB_Metro";
            this.matCB_Metro.StartIndex = 0;
            // 
            // tabP1
            // 
            this.tabP1.Controls.Add(this.tblLP_A1);
            resources.ApplyResources(this.tabP1, "tabP1");
            this.tabP1.Name = "tabP1";
            this.tabP1.UseVisualStyleBackColor = true;
            // 
            // tblLP_A1
            // 
            resources.ApplyResources(this.tblLP_A1, "tblLP_A1");
            this.tblLP_A1.Controls.Add(this.gBox_A4, 1, 1);
            this.tblLP_A1.Controls.Add(this.gBox_A3, 0, 1);
            this.tblLP_A1.Controls.Add(this.gBox_A1, 0, 0);
            this.tblLP_A1.Controls.Add(this.gBox_A2, 1, 0);
            this.tblLP_A1.Name = "tblLP_A1";
            // 
            // gBox_A4
            // 
            this.gBox_A4.Controls.Add(this.splC_A2);
            resources.ApplyResources(this.gBox_A4, "gBox_A4");
            this.gBox_A4.Name = "gBox_A4";
            this.gBox_A4.TabStop = false;
            // 
            // splC_A2
            // 
            resources.ApplyResources(this.splC_A2, "splC_A2");
            this.splC_A2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splC_A2.Name = "splC_A2";
            // 
            // splC_A2.Panel1
            // 
            this.splC_A2.Panel1.Controls.Add(this.tblLP_A4);
            // 
            // splC_A2.Panel2
            // 
            this.splC_A2.Panel2.Controls.Add(this.cht_PwrCons1);
            // 
            // tblLP_A4
            // 
            resources.ApplyResources(this.tblLP_A4, "tblLP_A4");
            this.tblLP_A4.Controls.Add(this.lbl12, 0, 0);
            this.tblLP_A4.Controls.Add(this.lbl13, 0, 1);
            this.tblLP_A4.Controls.Add(this.lbl14, 0, 2);
            this.tblLP_A4.Controls.Add(this.lbl15, 0, 3);
            this.tblLP_A4.Controls.Add(this.lbl_Cons1, 1, 0);
            this.tblLP_A4.Controls.Add(this.label14, 1, 1);
            this.tblLP_A4.Controls.Add(this.label15, 1, 2);
            this.tblLP_A4.Controls.Add(this.label16, 1, 3);
            this.tblLP_A4.Name = "tblLP_A4";
            // 
            // lbl12
            // 
            resources.ApplyResources(this.lbl12, "lbl12");
            this.lbl12.Name = "lbl12";
            // 
            // lbl13
            // 
            resources.ApplyResources(this.lbl13, "lbl13");
            this.lbl13.Name = "lbl13";
            // 
            // lbl14
            // 
            resources.ApplyResources(this.lbl14, "lbl14");
            this.lbl14.Name = "lbl14";
            // 
            // lbl15
            // 
            resources.ApplyResources(this.lbl15, "lbl15");
            this.lbl15.Name = "lbl15";
            // 
            // lbl_Cons1
            // 
            resources.ApplyResources(this.lbl_Cons1, "lbl_Cons1");
            this.lbl_Cons1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Cons1.Name = "lbl_Cons1";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Name = "label16";
            // 
            // cht_PwrCons1
            // 
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.Name = "ChartArea1";
            this.cht_PwrCons1.ChartAreas.Add(chartArea2);
            resources.ApplyResources(this.cht_PwrCons1, "cht_PwrCons1");
            legend2.Name = "Legend1";
            this.cht_PwrCons1.Legends.Add(legend2);
            this.cht_PwrCons1.Name = "cht_PwrCons1";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.MediumSpringGreen;
            series4.Legend = "Legend1";
            series4.Name = "CAP";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.DeepSkyBlue;
            series5.Legend = "Legend1";
            series5.Name = "GEN";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Silver;
            series6.Legend = "Legend1";
            series6.Name = "IDLE";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Orange;
            series7.Legend = "Legend1";
            series7.Name = "CON";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.cht_PwrCons1.Series.Add(series4);
            this.cht_PwrCons1.Series.Add(series5);
            this.cht_PwrCons1.Series.Add(series6);
            this.cht_PwrCons1.Series.Add(series7);
            // 
            // gBox_A3
            // 
            this.gBox_A3.Controls.Add(this.dgv_TotalResult);
            resources.ApplyResources(this.gBox_A3, "gBox_A3");
            this.gBox_A3.Name = "gBox_A3";
            this.gBox_A3.TabStop = false;
            // 
            // dgv_TotalResult
            // 
            this.dgv_TotalResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_TotalResult, "dgv_TotalResult");
            this.dgv_TotalResult.Name = "dgv_TotalResult";
            this.dgv_TotalResult.RowTemplate.Height = 27;
            // 
            // gBox_A1
            // 
            this.gBox_A1.Controls.Add(this.tblLP_A2);
            resources.ApplyResources(this.gBox_A1, "gBox_A1");
            this.gBox_A1.Name = "gBox_A1";
            this.gBox_A1.TabStop = false;
            // 
            // tblLP_A2
            // 
            resources.ApplyResources(this.tblLP_A2, "tblLP_A2");
            this.tblLP_A2.Controls.Add(this.matEP_A1, 0, 2);
            this.tblLP_A2.Controls.Add(this.flowLayoutPanel1, 0, 5);
            this.tblLP_A2.Controls.Add(this.lbl7, 0, 0);
            this.tblLP_A2.Controls.Add(this.matTB5, 1, 0);
            this.tblLP_A2.Controls.Add(this.lbl5, 0, 1);
            this.tblLP_A2.Controls.Add(this.matCB1, 1, 1);
            this.tblLP_A2.Controls.Add(this.matCB2, 2, 1);
            this.tblLP_A2.Name = "tblLP_A2";
            // 
            // matEP_A1
            // 
            this.matEP_A1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matEP_A1.CancelButtonText = "RESET";
            this.matEP_A1.Collapse = true;
            this.tblLP_A2.SetColumnSpan(this.matEP_A1, 3);
            this.matEP_A1.Controls.Add(this.tblLP_A5);
            this.matEP_A1.Depth = 0;
            this.matEP_A1.Description = "For advanced users";
            resources.ApplyResources(this.matEP_A1, "matEP_A1");
            this.matEP_A1.ExpandHeight = 200;
            this.matEP_A1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matEP_A1.MouseState = MaterialSkin.MouseState.HOVER;
            this.matEP_A1.Name = "matEP_A1";
            this.matEP_A1.Title = "Advanced Search Filter";
            this.matEP_A1.ValidationButtonEnable = true;
            // 
            // tblLP_A5
            // 
            resources.ApplyResources(this.tblLP_A5, "tblLP_A5");
            this.tblLP_A5.Controls.Add(this.lbl1, 0, 0);
            this.tblLP_A5.Controls.Add(this.lbl3, 0, 1);
            this.tblLP_A5.Controls.Add(this.matTB_State, 2, 0);
            this.tblLP_A5.Controls.Add(this.matTB_Country, 1, 0);
            this.tblLP_A5.Controls.Add(this.matTB_City, 3, 0);
            this.tblLP_A5.Controls.Add(this.dtp_Timestamp, 1, 1);
            this.tblLP_A5.Name = "tblLP_A5";
            // 
            // lbl1
            // 
            resources.ApplyResources(this.lbl1, "lbl1");
            this.lbl1.Name = "lbl1";
            // 
            // lbl3
            // 
            resources.ApplyResources(this.lbl3, "lbl3");
            this.lbl3.Name = "lbl3";
            // 
            // matTB_State
            // 
            this.matTB_State.AnimateReadOnly = false;
            resources.ApplyResources(this.matTB_State, "matTB_State");
            this.matTB_State.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.matTB_State.Depth = 0;
            this.matTB_State.HideSelection = true;
            this.matTB_State.LeadingIcon = null;
            this.matTB_State.MaxLength = 32767;
            this.matTB_State.MouseState = MaterialSkin.MouseState.OUT;
            this.matTB_State.Name = "matTB_State";
            this.matTB_State.PasswordChar = '\0';
            this.matTB_State.ReadOnly = false;
            this.matTB_State.SelectedText = "";
            this.matTB_State.SelectionLength = 0;
            this.matTB_State.SelectionStart = 0;
            this.matTB_State.ShortcutsEnabled = true;
            this.matTB_State.TabStop = false;
            this.matTB_State.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.matTB_State.TrailingIcon = null;
            this.matTB_State.UseSystemPasswordChar = false;
            // 
            // matTB_Country
            // 
            this.matTB_Country.AnimateReadOnly = false;
            resources.ApplyResources(this.matTB_Country, "matTB_Country");
            this.matTB_Country.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.matTB_Country.Depth = 0;
            this.matTB_Country.HideSelection = true;
            this.matTB_Country.LeadingIcon = null;
            this.matTB_Country.MaxLength = 32767;
            this.matTB_Country.MouseState = MaterialSkin.MouseState.OUT;
            this.matTB_Country.Name = "matTB_Country";
            this.matTB_Country.PasswordChar = '\0';
            this.matTB_Country.ReadOnly = false;
            this.matTB_Country.SelectedText = "";
            this.matTB_Country.SelectionLength = 0;
            this.matTB_Country.SelectionStart = 0;
            this.matTB_Country.ShortcutsEnabled = true;
            this.matTB_Country.TabStop = false;
            this.matTB_Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.matTB_Country.TrailingIcon = null;
            this.matTB_Country.UseSystemPasswordChar = false;
            this.matTB_Country.TextChanged += new System.EventHandler(this.matTB_Country_TextChanged);
            // 
            // matTB_City
            // 
            this.matTB_City.AnimateReadOnly = false;
            resources.ApplyResources(this.matTB_City, "matTB_City");
            this.matTB_City.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.matTB_City.Depth = 0;
            this.matTB_City.HideSelection = true;
            this.matTB_City.LeadingIcon = null;
            this.matTB_City.MaxLength = 32767;
            this.matTB_City.MouseState = MaterialSkin.MouseState.OUT;
            this.matTB_City.Name = "matTB_City";
            this.matTB_City.PasswordChar = '\0';
            this.matTB_City.ReadOnly = false;
            this.matTB_City.SelectedText = "";
            this.matTB_City.SelectionLength = 0;
            this.matTB_City.SelectionStart = 0;
            this.matTB_City.ShortcutsEnabled = true;
            this.matTB_City.TabStop = false;
            this.matTB_City.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.matTB_City.TrailingIcon = null;
            this.matTB_City.UseSystemPasswordChar = false;
            // 
            // dtp_Timestamp
            // 
            resources.ApplyResources(this.dtp_Timestamp, "dtp_Timestamp");
            this.dtp_Timestamp.Name = "dtp_Timestamp";
            // 
            // flowLayoutPanel1
            // 
            this.tblLP_A2.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Controls.Add(this.matCB_DBLoc);
            this.flowLayoutPanel1.Controls.Add(this.matBtn_Connect);
            this.flowLayoutPanel1.Controls.Add(this.matBtn_Refresh);
            this.flowLayoutPanel1.Controls.Add(this.matBtn_Add);
            this.flowLayoutPanel1.Controls.Add(this.matBtn_Edit);
            this.flowLayoutPanel1.Controls.Add(this.matBtn_Remove);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // matCB_DBLoc
            // 
            this.matCB_DBLoc.AutoResize = false;
            this.matCB_DBLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matCB_DBLoc.Depth = 0;
            this.matCB_DBLoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.matCB_DBLoc.DropDownHeight = 174;
            this.matCB_DBLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matCB_DBLoc.DropDownWidth = 121;
            resources.ApplyResources(this.matCB_DBLoc, "matCB_DBLoc");
            this.matCB_DBLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matCB_DBLoc.FormattingEnabled = true;
            this.matCB_DBLoc.Items.AddRange(new object[] {
            resources.GetString("matCB_DBLoc.Items"),
            resources.GetString("matCB_DBLoc.Items1")});
            this.matCB_DBLoc.MouseState = MaterialSkin.MouseState.OUT;
            this.matCB_DBLoc.Name = "matCB_DBLoc";
            this.matCB_DBLoc.StartIndex = 1;
            this.matCB_DBLoc.SelectedIndexChanged += new System.EventHandler(this.matCB_DBLoc_SelectedIndexChanged);
            // 
            // matBtn_Connect
            // 
            resources.ApplyResources(this.matBtn_Connect, "matBtn_Connect");
            this.matBtn_Connect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtn_Connect.Depth = 0;
            this.matBtn_Connect.HighEmphasis = true;
            this.matBtn_Connect.Icon = null;
            this.matBtn_Connect.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtn_Connect.Name = "matBtn_Connect";
            this.matBtn_Connect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtn_Connect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtn_Connect.UseAccentColor = false;
            this.matBtn_Connect.UseVisualStyleBackColor = true;
            this.matBtn_Connect.Click += new System.EventHandler(this.matBtn_Connect_Click);
            // 
            // matBtn_Refresh
            // 
            resources.ApplyResources(this.matBtn_Refresh, "matBtn_Refresh");
            this.matBtn_Refresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtn_Refresh.Depth = 0;
            this.matBtn_Refresh.HighEmphasis = true;
            this.matBtn_Refresh.Icon = null;
            this.matBtn_Refresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtn_Refresh.Name = "matBtn_Refresh";
            this.matBtn_Refresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtn_Refresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtn_Refresh.UseAccentColor = false;
            this.matBtn_Refresh.UseVisualStyleBackColor = true;
            this.matBtn_Refresh.Click += new System.EventHandler(this.matBtn_Refresh_Click);
            // 
            // matBtn_Add
            // 
            resources.ApplyResources(this.matBtn_Add, "matBtn_Add");
            this.matBtn_Add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtn_Add.Depth = 0;
            this.matBtn_Add.HighEmphasis = true;
            this.matBtn_Add.Icon = null;
            this.matBtn_Add.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtn_Add.Name = "matBtn_Add";
            this.matBtn_Add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtn_Add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtn_Add.UseAccentColor = false;
            this.matBtn_Add.UseVisualStyleBackColor = true;
            this.matBtn_Add.Click += new System.EventHandler(this.matBtn_Add_Click);
            // 
            // matBtn_Edit
            // 
            resources.ApplyResources(this.matBtn_Edit, "matBtn_Edit");
            this.matBtn_Edit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtn_Edit.Depth = 0;
            this.matBtn_Edit.HighEmphasis = true;
            this.matBtn_Edit.Icon = null;
            this.matBtn_Edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtn_Edit.Name = "matBtn_Edit";
            this.matBtn_Edit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtn_Edit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtn_Edit.UseAccentColor = false;
            this.matBtn_Edit.UseVisualStyleBackColor = true;
            this.matBtn_Edit.Click += new System.EventHandler(this.matBtn_Edit_Click);
            // 
            // matBtn_Remove
            // 
            resources.ApplyResources(this.matBtn_Remove, "matBtn_Remove");
            this.matBtn_Remove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtn_Remove.Depth = 0;
            this.matBtn_Remove.HighEmphasis = true;
            this.matBtn_Remove.Icon = null;
            this.matBtn_Remove.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtn_Remove.Name = "matBtn_Remove";
            this.matBtn_Remove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtn_Remove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtn_Remove.UseAccentColor = false;
            this.matBtn_Remove.UseVisualStyleBackColor = true;
            this.matBtn_Remove.Click += new System.EventHandler(this.matBtn_Remove_Click);
            // 
            // lbl7
            // 
            resources.ApplyResources(this.lbl7, "lbl7");
            this.lbl7.Name = "lbl7";
            // 
            // matTB5
            // 
            this.matTB5.AnimateReadOnly = false;
            resources.ApplyResources(this.matTB5, "matTB5");
            this.matTB5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tblLP_A2.SetColumnSpan(this.matTB5, 2);
            this.matTB5.Depth = 0;
            this.matTB5.HideSelection = true;
            this.matTB5.LeadingIcon = null;
            this.matTB5.MaxLength = 32767;
            this.matTB5.MouseState = MaterialSkin.MouseState.OUT;
            this.matTB5.Name = "matTB5";
            this.matTB5.PasswordChar = '\0';
            this.matTB5.ReadOnly = false;
            this.matTB5.SelectedText = "";
            this.matTB5.SelectionLength = 0;
            this.matTB5.SelectionStart = 0;
            this.matTB5.ShortcutsEnabled = true;
            this.matTB5.TabStop = false;
            this.matTB5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.matTB5.TrailingIcon = null;
            this.matTB5.UseSystemPasswordChar = false;
            // 
            // lbl5
            // 
            resources.ApplyResources(this.lbl5, "lbl5");
            this.lbl5.Name = "lbl5";
            // 
            // matCB1
            // 
            this.matCB1.AutoResize = false;
            this.matCB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matCB1.Depth = 0;
            resources.ApplyResources(this.matCB1, "matCB1");
            this.matCB1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.matCB1.DropDownHeight = 174;
            this.matCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matCB1.DropDownWidth = 121;
            this.matCB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matCB1.FormattingEnabled = true;
            this.matCB1.MouseState = MaterialSkin.MouseState.OUT;
            this.matCB1.Name = "matCB1";
            this.matCB1.StartIndex = 2;
            this.matCB1.SelectedIndexChanged += new System.EventHandler(this.matCB1_SelectedIndexChanged);
            // 
            // matCB2
            // 
            this.matCB2.AutoResize = false;
            this.matCB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matCB2.Depth = 0;
            resources.ApplyResources(this.matCB2, "matCB2");
            this.matCB2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.matCB2.DropDownHeight = 174;
            this.matCB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matCB2.DropDownWidth = 121;
            this.matCB2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matCB2.FormattingEnabled = true;
            this.matCB2.MouseState = MaterialSkin.MouseState.OUT;
            this.matCB2.Name = "matCB2";
            this.matCB2.StartIndex = 0;
            this.matCB2.SelectedIndexChanged += new System.EventHandler(this.matCB2_SelectedIndexChanged);
            // 
            // gBox_A2
            // 
            this.gBox_A2.Controls.Add(this.splC_A1);
            resources.ApplyResources(this.gBox_A2, "gBox_A2");
            this.gBox_A2.Name = "gBox_A2";
            this.gBox_A2.TabStop = false;
            // 
            // splC_A1
            // 
            resources.ApplyResources(this.splC_A1, "splC_A1");
            this.splC_A1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splC_A1.Name = "splC_A1";
            // 
            // splC_A1.Panel1
            // 
            this.splC_A1.Panel1.Controls.Add(this.tblLP_A3);
            // 
            // splC_A1.Panel2
            // 
            this.splC_A1.Panel2.Controls.Add(this.cht_PwrProd1);
            // 
            // tblLP_A3
            // 
            resources.ApplyResources(this.tblLP_A3, "tblLP_A3");
            this.tblLP_A3.Controls.Add(this.lbl8, 0, 0);
            this.tblLP_A3.Controls.Add(this.lbl_Gen1, 1, 0);
            this.tblLP_A3.Controls.Add(this.lbl10, 0, 1);
            this.tblLP_A3.Controls.Add(this.lbl_SpCapT1, 1, 1);
            this.tblLP_A3.Controls.Add(this.lbl11, 0, 2);
            this.tblLP_A3.Controls.Add(this.lbl_Prod1, 1, 2);
            this.tblLP_A3.Name = "tblLP_A3";
            // 
            // lbl8
            // 
            resources.ApplyResources(this.lbl8, "lbl8");
            this.lbl8.Name = "lbl8";
            // 
            // lbl_Gen1
            // 
            resources.ApplyResources(this.lbl_Gen1, "lbl_Gen1");
            this.lbl_Gen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Gen1.Name = "lbl_Gen1";
            // 
            // lbl10
            // 
            resources.ApplyResources(this.lbl10, "lbl10");
            this.lbl10.Name = "lbl10";
            // 
            // lbl_SpCapT1
            // 
            resources.ApplyResources(this.lbl_SpCapT1, "lbl_SpCapT1");
            this.lbl_SpCapT1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SpCapT1.Name = "lbl_SpCapT1";
            // 
            // lbl11
            // 
            resources.ApplyResources(this.lbl11, "lbl11");
            this.lbl11.Name = "lbl11";
            // 
            // lbl_Prod1
            // 
            resources.ApplyResources(this.lbl_Prod1, "lbl_Prod1");
            this.lbl_Prod1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Prod1.Name = "lbl_Prod1";
            // 
            // cht_PwrProd1
            // 
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.Name = "ChartArea1";
            this.cht_PwrProd1.ChartAreas.Add(chartArea3);
            resources.ApplyResources(this.cht_PwrProd1, "cht_PwrProd1");
            legend3.Name = "Legend1";
            this.cht_PwrProd1.Legends.Add(legend3);
            this.cht_PwrProd1.Name = "cht_PwrProd1";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.DeepSkyBlue;
            series8.Legend = "Legend1";
            series8.Name = "GEN";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Orange;
            series9.Legend = "Legend1";
            series9.Name = "ASC";
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series9.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.MediumSpringGreen;
            series10.Legend = "Legend1";
            series10.Name = "TOE";
            series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series10.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.cht_PwrProd1.Series.Add(series8);
            this.cht_PwrProd1.Series.Add(series9);
            this.cht_PwrProd1.Series.Add(series10);
            // 
            // matTabC
            // 
            this.matTabC.Controls.Add(this.tabP1);
            this.matTabC.Controls.Add(this.tabP2);
            this.matTabC.Controls.Add(this.tabP3);
            this.matTabC.Controls.Add(this.tabP4);
            this.matTabC.Depth = 0;
            resources.ApplyResources(this.matTabC, "matTabC");
            this.matTabC.ImageList = this.iconList_AUTO24;
            this.matTabC.MouseState = MaterialSkin.MouseState.HOVER;
            this.matTabC.Multiline = true;
            this.matTabC.Name = "matTabC";
            this.matTabC.SelectedIndex = 0;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.matTabC);
            this.Controls.Add(this.stStrip);
            this.Controls.Add(this.mnStrip);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.matTabC;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.mnStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mnStrip.ResumeLayout(false);
            this.mnStrip.PerformLayout();
            this.stStrip.ResumeLayout(false);
            this.stStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMem)).EndInit();
            this.tabP4.ResumeLayout(false);
            this.tblLP_D1.ResumeLayout(false);
            this.gBox_D1.ResumeLayout(false);
            this.gBox_D2.ResumeLayout(false);
            this.tabP3.ResumeLayout(false);
            this.tabP2.ResumeLayout(false);
            this.tblLP_B1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cht_PwrProd2)).EndInit();
            this.tabP1.ResumeLayout(false);
            this.tblLP_A1.ResumeLayout(false);
            this.gBox_A4.ResumeLayout(false);
            this.splC_A2.Panel1.ResumeLayout(false);
            this.splC_A2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splC_A2)).EndInit();
            this.splC_A2.ResumeLayout(false);
            this.tblLP_A4.ResumeLayout(false);
            this.tblLP_A4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_PwrCons1)).EndInit();
            this.gBox_A3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TotalResult)).EndInit();
            this.gBox_A1.ResumeLayout(false);
            this.tblLP_A2.ResumeLayout(false);
            this.tblLP_A2.PerformLayout();
            this.matEP_A1.ResumeLayout(false);
            this.matEP_A1.PerformLayout();
            this.tblLP_A5.ResumeLayout(false);
            this.tblLP_A5.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.gBox_A2.ResumeLayout(false);
            this.splC_A1.Panel1.ResumeLayout(false);
            this.splC_A1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splC_A1)).EndInit();
            this.splC_A1.ResumeLayout(false);
            this.tblLP_A3.ResumeLayout(false);
            this.tblLP_A3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_PwrProd1)).EndInit();
            this.matTabC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnStrip;
        private System.Windows.Forms.StatusStrip stStrip;
        private System.ComponentModel.BackgroundWorker bgProc;
        private System.Windows.Forms.ToolStripMenuItem TSMI_App;
        private System.Windows.Forms.ToolStripMenuItem TSMI_App_Pref;
        private System.Windows.Forms.ToolStripSeparator TSMI_App_Sp1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_App_Restart;
        private System.Windows.Forms.ToolStripMenuItem TSMI_App_Close;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Tool;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Window;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help;
        private System.Windows.Forms.ToolStripMenuItem TSMI_App_Refresh;
        private System.Windows.Forms.ToolStripSeparator TSMI_App_Sp2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_QuickTheme;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_QuickTheme_LT;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_QuickTheme_DT;
        private System.Windows.Forms.ToolStripSeparator TSMI_View_Sp1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_Spare1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_Spare2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_Spare3;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Tool_Spare1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Tool_Spare2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Tool_Spare3;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Tool_Spare4;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Window_Spare1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Window_Spare2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_About;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Homepage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Wiki;
        private System.Windows.Forms.ToolStripSeparator TSMI_Help_Sp1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Update;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Changelog;
        private System.Windows.Forms.ToolStripSeparator TSMI_Help_Sp2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Debug;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Debug_DevMode;
        private System.Windows.Forms.ToolStripSeparator TSMI_Help_Debug_Sp1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Debug_ViewRTLog;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Debug_RecordRTLog;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Debug_Report;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ImageList iconList_AUTO24;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_QuickTheme_OpenPref;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_QuickLocale;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_QuickLocale_ENG;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_QuickLocale_KOR;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_QuickLocale_JPN;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_QuickLocale_OpenPref;
        private System.Windows.Forms.NotifyIcon ntfIcon;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_ProcLbl;
        private System.Windows.Forms.ToolStripProgressBar TSSI_ProcSt;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_Sp1;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_MemLbl;
        private System.Windows.Forms.ToolStripProgressBar TSSI_MemSt;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_Sp2;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_NetLbl;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_NetSt;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_Sp3;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_LocLbl;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_LocName;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_Sp4;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_ProdLbl;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_ProdSt;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_Sp5;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_ConsLbl;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_ConsSt;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_Sp6;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_BattLbl;
        private System.Windows.Forms.ToolStripProgressBar TSSI_BattSt;
        private System.Windows.Forms.ToolStripStatusLabel TSSI_BattLS;
        private System.Diagnostics.PerformanceCounter pProc;
        private System.Diagnostics.PerformanceCounter pMem;
        private System.Windows.Forms.TabPage tabP4;
        private System.Windows.Forms.TableLayoutPanel tblLP_D1;
        private System.Windows.Forms.GroupBox gBox_D1;
        private MaterialSkin.Controls.MaterialListView matLV_GenSrcList;
        private MaterialSkin.Controls.MaterialTextBox2 matTB_Search;
        private System.Windows.Forms.GroupBox gBox_D2;
        private System.Windows.Forms.WebBrowser wb_Map;
        private System.Windows.Forms.TabPage tabP3;
        private System.Windows.Forms.TableLayoutPanel tblLP_C1;
        private System.Windows.Forms.TabPage tabP2;
        private System.Windows.Forms.TableLayoutPanel tblLP_B1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_PwrProd2;
        private MaterialSkin.Controls.MaterialComboBox matCB_Metro;
        private System.Windows.Forms.TabPage tabP1;
        private System.Windows.Forms.TableLayoutPanel tblLP_A1;
        private System.Windows.Forms.GroupBox gBox_A4;
        private System.Windows.Forms.SplitContainer splC_A2;
        private System.Windows.Forms.TableLayoutPanel tblLP_A4;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.Label lbl_Cons1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_PwrCons1;
        private System.Windows.Forms.GroupBox gBox_A3;
        private System.Windows.Forms.DataGridView dgv_TotalResult;
        private System.Windows.Forms.GroupBox gBox_A1;
        private System.Windows.Forms.TableLayoutPanel tblLP_A2;
        private MaterialSkin.Controls.MaterialExpansionPanel matEP_A1;
        private System.Windows.Forms.TableLayoutPanel tblLP_A5;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private MaterialSkin.Controls.MaterialTextBox2 matTB_State;
        private MaterialSkin.Controls.MaterialTextBox2 matTB_Country;
        private MaterialSkin.Controls.MaterialTextBox2 matTB_City;
        private System.Windows.Forms.DateTimePicker dtp_Timestamp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialComboBox matCB_DBLoc;
        private MaterialSkin.Controls.MaterialButton matBtn_Connect;
        private MaterialSkin.Controls.MaterialButton matBtn_Refresh;
        private MaterialSkin.Controls.MaterialButton matBtn_Add;
        private MaterialSkin.Controls.MaterialButton matBtn_Edit;
        private MaterialSkin.Controls.MaterialButton matBtn_Remove;
        private System.Windows.Forms.Label lbl7;
        private MaterialSkin.Controls.MaterialTextBox2 matTB5;
        private System.Windows.Forms.Label lbl5;
        private MaterialSkin.Controls.MaterialComboBox matCB1;
        private MaterialSkin.Controls.MaterialComboBox matCB2;
        private System.Windows.Forms.GroupBox gBox_A2;
        private System.Windows.Forms.SplitContainer splC_A1;
        private System.Windows.Forms.TableLayoutPanel tblLP_A3;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl_Gen1;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl_SpCapT1;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl_Prod1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_PwrProd1;
        private MaterialSkin.Controls.MaterialTabControl matTabC;
    }
}

