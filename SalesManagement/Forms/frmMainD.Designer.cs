namespace SalesManagement.Forms
{
    partial class frmMainD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainD));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pricePerMonthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.quantityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.receiptPerDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.salesPerMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pricePerMonthChart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPerMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // pricePerMonthChart
            // 
            this.pricePerMonthChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Name = "ChartArea1";
            this.pricePerMonthChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.Title = "Total Sales Per Day";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.pricePerMonthChart.Legends.Add(legend1);
            this.pricePerMonthChart.Location = new System.Drawing.Point(226, 12);
            this.pricePerMonthChart.Name = "pricePerMonthChart";
            this.pricePerMonthChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelAngle = 1;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.Name = "PerMonthSeries";
            this.pricePerMonthChart.Series.Add(series1);
            this.pricePerMonthChart.Size = new System.Drawing.Size(439, 256);
            this.pricePerMonthChart.TabIndex = 1;
            this.pricePerMonthChart.Text = "chart";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 531);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 469);
            this.panel3.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 487);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(196, 32);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "BACK";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // quantityChart
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Name = "ChartArea1";
            this.quantityChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Total Items Sold Per Day";
            legend2.TitleAlignment = System.Drawing.StringAlignment.Far;
            this.quantityChart.Legends.Add(legend2);
            this.quantityChart.Location = new System.Drawing.Point(226, 274);
            this.quantityChart.Name = "quantityChart";
            this.quantityChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series2.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelAngle = 1;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.White;
            series2.Name = "QuantitySeries";
            series2.YValuesPerPoint = 2;
            this.quantityChart.Series.Add(series2);
            this.quantityChart.Size = new System.Drawing.Size(529, 245);
            this.quantityChart.TabIndex = 3;
            this.quantityChart.Text = "chart2";
            // 
            // receiptPerDay
            // 
            this.receiptPerDay.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea3.Name = "ChartArea1";
            this.receiptPerDay.ChartAreas.Add(chartArea3);
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            legend3.Title = "Total Transactions Per Day";
            this.receiptPerDay.Legends.Add(legend3);
            this.receiptPerDay.Location = new System.Drawing.Point(671, 12);
            this.receiptPerDay.Name = "receiptPerDay";
            this.receiptPerDay.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            series3.BorderColor = System.Drawing.Color.Black;
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.LabelAngle = 1;
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.LabelBorderColor = System.Drawing.Color.Transparent;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.White;
            series3.Name = "RecSeries";
            this.receiptPerDay.Series.Add(series3);
            this.receiptPerDay.Size = new System.Drawing.Size(562, 256);
            this.receiptPerDay.TabIndex = 4;
            this.receiptPerDay.Text = "chart2";
            // 
            // salesPerMonth
            // 
            this.salesPerMonth.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Area3DStyle.Enable3D = true;
            chartArea4.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea4.Name = "ChartArea1";
            this.salesPerMonth.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend4.Name = "Legend1";
            legend4.Title = "Total Sales Per Month";
            legend4.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.salesPerMonth.Legends.Add(legend4);
            this.salesPerMonth.Location = new System.Drawing.Point(761, 274);
            this.salesPerMonth.Name = "salesPerMonth";
            this.salesPerMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            series4.BorderColor = System.Drawing.Color.Black;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.LabelAngle = 1;
            series4.LabelBackColor = System.Drawing.Color.Transparent;
            series4.LabelBorderColor = System.Drawing.Color.Transparent;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.White;
            series4.Name = "SalesPerMonthSeries";
            this.salesPerMonth.Series.Add(series4);
            this.salesPerMonth.Size = new System.Drawing.Size(472, 245);
            this.salesPerMonth.TabIndex = 5;
            this.salesPerMonth.Text = "chart";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1245, 531);
            this.panel2.TabIndex = 6;
            // 
            // frmMainD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 531);
            this.Controls.Add(this.salesPerMonth);
            this.Controls.Add(this.receiptPerDay);
            this.Controls.Add(this.quantityChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pricePerMonthChart);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmMainD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pricePerMonthChart)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPerMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pricePerMonthChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart quantityChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart receiptPerDay;
        private System.Windows.Forms.DataVisualization.Charting.Chart salesPerMonth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
    }
}