namespace FeedbackApp
{
    partial class ChartReport
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnUpdateChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(72, 93);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Feedback";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(731, 360);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnUpdateChart
            // 
            this.btnUpdateChart.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateChart.Font = new System.Drawing.Font("Bookman Old Style", 7.8F);
            this.btnUpdateChart.Location = new System.Drawing.Point(628, 465);
            this.btnUpdateChart.Name = "btnUpdateChart";
            this.btnUpdateChart.Size = new System.Drawing.Size(150, 53);
            this.btnUpdateChart.TabIndex = 1;
            this.btnUpdateChart.Text = "Update the chart";
            this.btnUpdateChart.UseVisualStyleBackColor = false;
            this.btnUpdateChart.Click += new System.EventHandler(this.btnUpdateChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "The chart represents the feedback data provided by the user in diagram:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(51, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 509);
            this.panel1.TabIndex = 3;
            // 
            // ChartReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChartReport";
            this.Text = "ChartReport";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnUpdateChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}