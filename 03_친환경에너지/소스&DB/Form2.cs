using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniversalPowerMonitor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            form2_chart.Series.Clear();
            InitComboBox();
        }

        private void InitComboBox()
        {
            // form2_metro_comboBox 아이템 초기화
            form2_metro_comboBox.Items.Clear();
            DataManager.GetMetroComboBox();
            form2_metro_comboBox.Items.AddRange(DataManager.metroCombobox.ToArray());
            form2_metro_comboBox.SelectedIndex = 1;

            // form2_year_comboBox 아이템 초기화
            form2_year_comboBox.Items.Clear();
            DataManager.GetYearComboBox();
            form2_year_comboBox.Items.AddRange(DataManager.yearCombobox.OfType<object>().ToArray());
            form2_year_comboBox.SelectedIndex = 1;
        }

        private void form2_search_button_Click(object sender, EventArgs e)
        {
            string metro = form2_metro_comboBox.SelectedItem.ToString();
            int year = (int)form2_year_comboBox.SelectedItem;
            DataManager.ppList.Clear();
            DataManager.GetPartData(metro, year);

            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = DataManager.ppList;

            DisplayChart(metro, year);
        }

        private void DisplayChart(string metro, int year)
        {
            /*
            // Add a data series to the chart
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.XValueMember = "source";
            series.YValueMembers = "toe";
            series.IsValueShownAsLabel = true;

            // Bind the data to the chart
            series.DataSource = dt;
            chart.Series.Add(series);

            // Set chart properties
            chart.Titles.Add("Power Plants in Seoul (2020)");
            chart.ChartAreas[0].AxisX.Title = "Source";
            chart.ChartAreas[0].AxisY.Title = "TOE";

            // Display the chart in a form or control
            Form form = new Form();
            form.Controls.Add(chart);
            form.ShowDialog();
            */



            form2_chart.DataSource = null;
            form2_chart.DataSource = DataManager.ppList;
            form2_chart.Series.Add("toe");
            form2_chart.Series.Add("MWh");
            form2_chart.Series.Add("kWTotal");

            // form2_chart.Series[0].Name = "toe";
            form2_chart.Series[0].XValueMember = "source";
            form2_chart.Series[0].YValueMembers = "toe";
            
            /*
            form2_chart.Series[1].XValueMember = "source";
            form2_chart.Series[1].YValueMembers = "MWh";
            form2_chart.Series[2].XValueMember = "source";
            form2_chart.Series[2].YValueMembers = "kWTotal";
            */

            // 차트에 데이터 바인딩
            form2_chart.DataSource = DataManager.ppList;

            // form2_chart.Series[0].ChartType = SeriesChartType.Line;
            // form2_chart.Series[1].ChartType = SeriesChartType.Line;
            // form2_chart.Series[2].ChartType = SeriesChartType.Line;
            
            // form2_chart.Series[0].ChartType = SeriesChartType.Line;
            // form2_chart.Series[1].ChartType = SeriesChartType.Line;
            // form2_chart.Series[2].ChartType = SeriesChartType.Line;

            // Set the minimum and maximum values for the X-axis

            // form2_chart.ChartAreas[0].AxisX.Minimum = 2020; // Adjust this value as needed
            // form2_chart.ChartAreas[0].AxisX.Maximum = 2022; // Adjust this value as needed

            // Set the interval for the X-axis labels           

            // form2_chart.ChartAreas[0].AxisX.Interval = 1; // Display a label for every year

            foreach (var item in DataManager.ppList)
            {
                // form2_chart.Series.XValueMember = "source";
                // form2_chart.Series.YValueMembers = "toe";
                // form2_chart.Series.IsValueShownAsLabel = true;
                // form2_chart.Series[0].Points.AddXY(item.source, item.toe);
                // form2_chart.Series[1].Points.AddXY(item.source, item.MWh);
                // form2_chart.Series[2].Points.AddXY(item.source, item.kWTotal);
            }
            //form2_chart.ChartAreas[0];
            //AxisY.Title = ""
            //this.Controls.Add(form2_chart);

            // X축 바인딩
            form2_chart.Series[0].XValueMember = "source";

            // Y축 바인딩
            form2_chart.Series[0].YValueMembers = "toe";
            form2_chart.Series[1].YValueMembers = "MWh";
            form2_chart.Series[2].YValueMembers = "kWTotal";

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

        private void form2_init_data_button_Click(object sender, EventArgs e)
        {
            InitAllData();            
        }

        private void InitAllData()
        {
            // Chart 초기화
            // Chart의 Series 컬렉션을 초기화합니다.
            form2_chart.Series.Clear();

            // Chart의 Titles 컬렉션을 초기화합니다.
            form2_chart.Titles.Clear();

            // Chart의 Annotations 컬렉션을 초기화합니다.
            form2_chart.Annotations.Clear();

            // ComboBox 아이템 초기화
            form2_metro_comboBox.SelectedItem = null;
            form2_year_comboBox.SelectedItem = null;            

            DataManager.ppList.Clear();
        }

    }
}
