namespace PieChartWithLegendApp
{
    partial class MainForm
    {
        private System.Windows.Forms.TextBox txtSliceLabel;
        private System.Windows.Forms.TextBox txtSliceValue;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.Button btnAddSlice;
        private System.Windows.Forms.Button btnDrawPieChart;
        private System.Windows.Forms.ListBox lstSlices;
        private System.Windows.Forms.Panel chartPanel;

        private void InitializeComponent()
        {
            this.txtSliceLabel = new System.Windows.Forms.TextBox();
            this.txtSliceValue = new System.Windows.Forms.TextBox();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.btnAddSlice = new System.Windows.Forms.Button();
            this.btnDrawPieChart = new System.Windows.Forms.Button();
            this.lstSlices = new System.Windows.Forms.ListBox();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtSliceLabel
            // 
            this.txtSliceLabel.Location = new System.Drawing.Point(20, 20);
            this.txtSliceLabel.Name = "txtSliceLabel";
            this.txtSliceLabel.Size = new System.Drawing.Size(100, 22);
            this.txtSliceLabel.TabIndex = 0;
            // 
            // txtSliceValue
            // 
            this.txtSliceValue.Location = new System.Drawing.Point(130, 20);
            this.txtSliceValue.Name = "txtSliceValue";
            this.txtSliceValue.Size = new System.Drawing.Size(50, 22);
            this.txtSliceValue.TabIndex = 1;
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Location = new System.Drawing.Point(190, 20);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(75, 23);
            this.btnSelectColor.TabIndex = 2;
            this.btnSelectColor.Text = "Select Color";
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // btnAddSlice
            // 
            this.btnAddSlice.Location = new System.Drawing.Point(280, 20);
            this.btnAddSlice.Name = "btnAddSlice";
            this.btnAddSlice.Size = new System.Drawing.Size(75, 23);
            this.btnAddSlice.TabIndex = 3;
            this.btnAddSlice.Text = "Add Slice";
            this.btnAddSlice.Click += new System.EventHandler(this.btnAddSlice_Click);
            // 
            // btnDrawPieChart
            // 
            this.btnDrawPieChart.Location = new System.Drawing.Point(20, 60);
            this.btnDrawPieChart.Name = "btnDrawPieChart";
            this.btnDrawPieChart.Size = new System.Drawing.Size(100, 23);
            this.btnDrawPieChart.TabIndex = 4;
            this.btnDrawPieChart.Text = "Draw Pie Chart";
            this.btnDrawPieChart.Click += new System.EventHandler(this.btnDrawPieChart_Click);
            // 
            // lstSlices
            // 
            this.lstSlices.ItemHeight = 16;
            this.lstSlices.Location = new System.Drawing.Point(20, 100);
            this.lstSlices.Name = "lstSlices";
            this.lstSlices.Size = new System.Drawing.Size(335, 84);
            this.lstSlices.TabIndex = 5;
            // 
            // chartPanel
            // 
            this.chartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartPanel.Location = new System.Drawing.Point(370, 20);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(400, 300);
            this.chartPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSliceLabel);
            this.Controls.Add(this.txtSliceValue);
            this.Controls.Add(this.btnSelectColor);
            this.Controls.Add(this.btnAddSlice);
            this.Controls.Add(this.btnDrawPieChart);
            this.Controls.Add(this.lstSlices);
            this.Controls.Add(this.chartPanel);
            this.Name = "MainForm";
            this.Text = "Pie Chart with Legend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
