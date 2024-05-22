namespace UniversalPowerMonitor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.form2_metro_label = new System.Windows.Forms.Label();
            this.form2_year_label = new System.Windows.Forms.Label();
            this.form2_metro_comboBox = new System.Windows.Forms.ComboBox();
            this.form2_year_comboBox = new System.Windows.Forms.ComboBox();
            this.form2_search_button = new System.Windows.Forms.Button();
            this.form2_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.form2_init_data_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.form2_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // form2_metro_label
            // 
            this.form2_metro_label.AutoSize = true;
            this.form2_metro_label.Location = new System.Drawing.Point(10, 5);
            this.form2_metro_label.Name = "form2_metro_label";
            this.form2_metro_label.Size = new System.Drawing.Size(37, 12);
            this.form2_metro_label.TabIndex = 0;
            this.form2_metro_label.Text = "metro";
            // 
            // form2_year_label
            // 
            this.form2_year_label.AutoSize = true;
            this.form2_year_label.Location = new System.Drawing.Point(198, 5);
            this.form2_year_label.Name = "form2_year_label";
            this.form2_year_label.Size = new System.Drawing.Size(30, 12);
            this.form2_year_label.TabIndex = 1;
            this.form2_year_label.Text = "year";
            // 
            // form2_metro_comboBox
            // 
            this.form2_metro_comboBox.FormattingEnabled = true;
            this.form2_metro_comboBox.Location = new System.Drawing.Point(54, 2);
            this.form2_metro_comboBox.Name = "form2_metro_comboBox";
            this.form2_metro_comboBox.Size = new System.Drawing.Size(121, 20);
            this.form2_metro_comboBox.TabIndex = 2;
            // 
            // form2_year_comboBox
            // 
            this.form2_year_comboBox.FormattingEnabled = true;
            this.form2_year_comboBox.Location = new System.Drawing.Point(234, 2);
            this.form2_year_comboBox.Name = "form2_year_comboBox";
            this.form2_year_comboBox.Size = new System.Drawing.Size(121, 20);
            this.form2_year_comboBox.TabIndex = 3;
            // 
            // form2_search_button
            // 
            this.form2_search_button.Location = new System.Drawing.Point(384, 2);
            this.form2_search_button.Name = "form2_search_button";
            this.form2_search_button.Size = new System.Drawing.Size(75, 23);
            this.form2_search_button.TabIndex = 4;
            this.form2_search_button.Text = "부분 검색";
            this.form2_search_button.UseVisualStyleBackColor = true;
            this.form2_search_button.Click += new System.EventHandler(this.form2_search_button_Click);
            // 
            // form2_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.form2_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.form2_chart.Legends.Add(legend1);
            this.form2_chart.Location = new System.Drawing.Point(12, 28);
            this.form2_chart.Name = "form2_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.form2_chart.Series.Add(series1);
            this.form2_chart.Size = new System.Drawing.Size(776, 410);
            this.form2_chart.TabIndex = 5;
            this.form2_chart.Text = "chart1";
            // 
            // form2_init_data_button
            // 
            this.form2_init_data_button.Location = new System.Drawing.Point(542, 2);
            this.form2_init_data_button.Name = "form2_init_data_button";
            this.form2_init_data_button.Size = new System.Drawing.Size(165, 23);
            this.form2_init_data_button.TabIndex = 6;
            this.form2_init_data_button.Text = "데이터 초기화";
            this.form2_init_data_button.UseVisualStyleBackColor = true;
            this.form2_init_data_button.Click += new System.EventHandler(this.form2_init_data_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.form2_init_data_button);
            this.Controls.Add(this.form2_chart);
            this.Controls.Add(this.form2_search_button);
            this.Controls.Add(this.form2_year_comboBox);
            this.Controls.Add(this.form2_metro_comboBox);
            this.Controls.Add(this.form2_year_label);
            this.Controls.Add(this.form2_metro_label);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form2_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form2_metro_label;
        private System.Windows.Forms.Label form2_year_label;
        private System.Windows.Forms.ComboBox form2_metro_comboBox;
        private System.Windows.Forms.ComboBox form2_year_comboBox;
        private System.Windows.Forms.Button form2_search_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart form2_chart;
        private System.Windows.Forms.Button form2_init_data_button;
    }
}