using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UniversalPowerMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();
        }

        private void InitComboBox()
        {
            // ComboBox1 아이템 초기화
            comboBox1.Items.Clear();
            DataManager.GetMetroComboBox();
            comboBox1.Items.AddRange(DataManager.metroCombobox.ToArray());
            comboBox1.SelectedIndex = 1;

            // ComboBox2 아이템 초기화
            comboBox2.Items.Clear();
            DataManager.GetSourceComboBox();
            comboBox2.Items.AddRange(DataManager.sourceCombobox.ToArray());
            comboBox2.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataManager.Load();
            dataGridView1.DataSource = DataManager.ppList;
            InitComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metro = comboBox1.SelectedItem.ToString();
            string source = comboBox2.SelectedItem.ToString();
            DataManager.ppList.Clear();
            DataManager.GetPartData(metro, source);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataManager.ppList;

            DisplayChart(metro, source);
            /*
            chart1.DataSource = null;
            chart1.DataSource = DataManager.ppList;
            
            chart1.Series[0].Name = metro +" : "+source;
            chart1.Series[0].XValueMember = "year";
            chart1.Series[0].YValueMembers = "MWh";

            // 차트에 데이터 바인딩
            chart1.DataSource = DataManager.ppList;

            chart1.Series[0].ChartType = SeriesChartType.Line;

            // Set the minimum and maximum values for the X-axis
            chart1.ChartAreas[0].AxisX.Minimum = 2020; // Adjust this value as needed
            chart1.ChartAreas[0].AxisX.Maximum = 2022; // Adjust this value as needed
            // Set the interval for the X-axis labels
            chart1.ChartAreas[0].AxisX.Interval = 1; // Display a label for every year

            foreach (var item in DataManager.ppList)
            {
                chart1.Series[0].Points.AddXY(item.year, item.toe);                
            }
            //chart1.ChartAreas[0];
            //AxisY.Title = ""
            this.Controls.Add(chart1);

            /*
            // X축 바인딩
            chart1.Series[0].XValueMember = "year";

            // Y축 바인딩
            chart1.Series[0].YValueMembers = "toe";
            //chart1.Series.Add("1");
            //chart1.Series[1].YValueMembers = "MWh";
            //chart1.Series.Add("2");
            //chart1.Series[2].YValueMembers = "kWTotal";
            */

            //chart1.Series[0].YValueMembers = "MWh";
            //chart1.Series[0].YValueMembers = "kWTotal";
            //chart1.Series[0].ChartType = SeriesChartType.Column;
            //chart1.Series[0].ChartType = SeriesChartType.Pie;

            /*
            year toe MWh kWTotal
            chart1.Series[0].Points.AddXY(1, 2);
            chart1.Series[0].Points.AddXY(2, 1);
            chart1.Series[0].Points.AddXY(3, 5);
            */

            /*
            chart2.Series[0].Points.AddXY(0.0, 10);
            chart2.Series[0].Points.Add(new double[] { 40.0 });
            chart2.Series[0].Name = "lv";
            chart2.Series.Add("data");
            chart2.Series[1].Points.Add(new double[] { 20.0 });
            chart2.Series[1].Points.Add(new double[] { 50.0 });

            chart3.ChartAreas[0].AxisX.LabelStyle.Interval = 1; //x축 간격
            for (int i = 0; i < 10; i++)
                chart3.Series["Series1"].Points.AddXY(i, i + 10);
            */
        }

        private void DisplayChart(string metro, string source)
        {
            chart1.DataSource = null;
            chart1.DataSource = DataManager.ppList;
            chart1.Series.Add("toe");
            chart1.Series.Add("MWh");
            chart1.Series.Add("kWTotal");

            chart1.Series[0].Name = "toe";
            chart1.Series[0].XValueMember = "year";
            chart1.Series[0].YValueMembers = "toe";
            chart1.Series[1].XValueMember = "year";
            chart1.Series[1].YValueMembers = "MWh";
            chart1.Series[2].XValueMember = "year";
            chart1.Series[2].YValueMembers = "kWTotal";

            // 차트에 데이터 바인딩
            chart1.DataSource = DataManager.ppList;

            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[2].ChartType = SeriesChartType.Line;

            // Set the minimum and maximum values for the X-axis
            chart1.ChartAreas[0].AxisX.Minimum = 2020; // Adjust this value as needed
            chart1.ChartAreas[0].AxisX.Maximum = 2022; // Adjust this value as needed
            // chart1.ChartAreas[1].AxisX.Minimum = 2020; // Adjust this value as needed
            // chart1.ChartAreas[1].AxisX.Maximum = 2022; // Adjust this value as needed
            // Set the interval for the X-axis labels
            chart1.ChartAreas[0].AxisX.Interval = 1; // Display a label for every year
            // chart1.ChartAreas[1].AxisX.Interval = 1; // Display a label for every year

            foreach (var item in DataManager.ppList)
            {
                chart1.Series[0].Points.AddXY(item.year, item.toe);
                chart1.Series[1].Points.AddXY(item.year, item.MWh);
                chart1.Series[2].Points.AddXY(item.year, item.kWTotal);
            }
            //chart1.ChartAreas[0];
            //AxisY.Title = ""
            //this.Controls.Add(chart1);

            // X축 바인딩
            chart1.Series[0].XValueMember = "year";

            // Y축 바인딩
            chart1.Series[0].YValueMembers = "toe";
            chart1.Series[1].YValueMembers = "MWh";
            chart1.Series[2].YValueMembers = "kWTotal";

            /*
            chart2.Series[0].Points.AddXY(0.0, 10);
            chart2.Series[0].Points.Add(new double[] { 40.0 });
            chart2.Series[0].Name = "lv";
            chart2.Series.Add("data");
            chart2.Series[1].Points.Add(new double[] { 20.0 });
            chart2.Series[1].Points.Add(new double[] { 50.0 });

            chart3.ChartAreas[0].AxisX.LabelStyle.Interval = 1; //x축 간격
            for (int i = 0; i < 10; i++)
                chart3.Series["Series1"].Points.AddXY(i, i + 10);
            */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InitAllData();
        }

        private void InitAllData()
        {
            // DataGridView의 DataSource 속성을 null로 설정하여 데이터 소스를 제거합니다.
            dataGridView1.DataSource = null;

            // DataGridView의 Rows 컬렉션을 초기화합니다.
            dataGridView1.Rows.Clear();

            // DataGridView의 열 컬렉션을 초기화합니다.
            dataGridView1.Columns.Clear();

            // DataGridView의 스타일을 기본값으로 초기화합니다.
            // dataGridView1.DefaultCellStyle = null;

            // Chart 초기화
            // Chart의 Series 컬렉션을 초기화합니다.
            chart1.Series.Clear();

            // Chart의 Titles 컬렉션을 초기화합니다.
            chart1.Titles.Clear();

            // Chart의 Annotations 컬렉션을 초기화합니다.
            chart1.Annotations.Clear();

            // ComboBox1,2 아이템 초기화
            // 기본값 설정
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            //comboBox1.SelectedIndex = -1; // 0부터 시작하므로 "항목2"가 선택됨                           
            //comboBox2.SelectedIndex = -1; // 0부터 시작하므로 "항목2"가 선택됨
            //comboBox1.Items.Clear();
            //comboBox2.Items.Clear();
            //DataManager.metroCombobox = null;
            //DataManager.sourceCombobox = null;

            DataManager.ppList.Clear();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitAllData();
            new Form2().ShowDialog();
        }
    }
}