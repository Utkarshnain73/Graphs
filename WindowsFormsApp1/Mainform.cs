using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PieChartWithLegendApp
{
    public partial class MainForm : Form
    {
        private List<PieSlice> slices = new List<PieSlice>();
        private Color currentColor = Color.Gray;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentColor = colorDialog.Color;
                }
            }
        }

        private void btnAddSlice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSliceLabel.Text) ||
                !float.TryParse(txtSliceValue.Text, out float value))
            {
                MessageBox.Show("Please enter a valid label and value.");
                return;
            }

            
            PieSlice newSlice = new PieSlice(txtSliceLabel.Text, value, currentColor);
            slices.Add(newSlice);
            lstSlices.Items.Add($"{newSlice.Label}: {newSlice.Value}");

            
            txtSliceLabel.Clear();
            txtSliceValue.Clear();
            currentColor = Color.Gray;
        }

        private void btnDrawPieChart_Click(object sender, EventArgs e)
        {
            DrawPieChart(slices);
        }

        private void DrawPieChart(List<PieSlice> slices)
        {
            if (chartPanel == null || slices.Count == 0) return;

            float totalValue = slices.Sum(s => s.Value);
            float startAngle = 0f;
            int legendX = chartPanel.Width - 100;
            int legendY = 20;
            int legendHeight = 20;

            using (Graphics g = chartPanel.CreateGraphics())
            {
                g.Clear(Color.White);

                foreach (var slice in slices)
                {
                    float sweepAngle = (slice.Value / totalValue) * 360;
                    using (Brush brush = new SolidBrush(slice.Color))
                    {
                        
                        g.FillPie(brush, 20, 20, chartPanel.Width - 150, chartPanel.Height - 50, startAngle, sweepAngle);

                        
                        g.FillRectangle(brush, legendX, legendY, legendHeight, legendHeight);
                        g.DrawString(slice.Label, this.Font, Brushes.Black, legendX + legendHeight + 5, legendY);
                        legendY += legendHeight + 5;
                    }

                    startAngle += sweepAngle;
                }
            }
        }
    }

    public class PieSlice
    {
        public string Label { get; }
        public float Value { get; }
        public Color Color { get; }

        public PieSlice(string label, float value, Color color)
        {
            Label = label;
            Value = value;
            Color = color;
        }
    }
}
