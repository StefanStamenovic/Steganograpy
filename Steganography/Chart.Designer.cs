namespace Steganography
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Chart_Autocorrelation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Autocorrelation)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart_Autocorrelation
            // 
            this.Chart_Autocorrelation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Chart_Autocorrelation.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 9.134615F;
            legend1.Position.Width = 14.97525F;
            legend1.Position.X = 82.02475F;
            legend1.Position.Y = 9.222656F;
            this.Chart_Autocorrelation.Legends.Add(legend1);
            this.Chart_Autocorrelation.Location = new System.Drawing.Point(0, 0);
            this.Chart_Autocorrelation.Margin = new System.Windows.Forms.Padding(4);
            this.Chart_Autocorrelation.Name = "Chart_Autocorrelation";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Difference";
            series1.YValuesPerPoint = 32;
            this.Chart_Autocorrelation.Series.Add(series1);
            this.Chart_Autocorrelation.Size = new System.Drawing.Size(1079, 513);
            this.Chart_Autocorrelation.TabIndex = 0;
            this.Chart_Autocorrelation.Text = "Autocorrelation";
            title1.Name = "Autocorrelation differences";
            this.Chart_Autocorrelation.Titles.Add(title1);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 516);
            this.Controls.Add(this.Chart_Autocorrelation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Chart";
            this.Text = "Autocorrelation chart";
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Autocorrelation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Autocorrelation;
    }
}