using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW11
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            if (radioButton1.Checked)
            {


                Brush[] brushes = { Brushes.Red, Brushes.Green, Brushes.Blue };
                int[] values = { 30, 50, 20 };
                float[] angles = new float[values.Length];
                float total = values.Sum();
                for (int i = 0; i < values.Length; i++)
                {
                    angles[i] = values[i] / total * 360f;
                }


                float startAngle = 0f;
                for (int i = 0; i < values.Length; i++)
                {
                    float sweepAngle = angles[i];
                    graphics.FillPie(brushes[i % brushes.Length], 0, 0, width, height, startAngle, sweepAngle);
                    startAngle += sweepAngle;
                }
            }
            else if (radioButton2.Checked)
            {
                Brush[] brushes = { Brushes.Red, Brushes.Green, Brushes.Blue };
                int[] values = { 40, 50, 10 };
                PointF[] points = { new PointF(0, height), new PointF(width, height), new PointF(width / 2f, 0) };
                Point[] polyPoints = Array.ConvertAll(points, p => Point.Round(p));
                int[] polyValues = { values[0], values[1], values[2] };

                graphics.FillPolygon(new SolidBrush(Color.White), polyPoints);
                float startAngle = -90f;
                for (int i = 0; i < polyValues.Length; i++)
                {
                    float sweepAngle = polyValues[i] / (float)values.Sum() * 360f;
                    graphics.FillPie(brushes[i % brushes.Length], 0, 0, width, height, startAngle, sweepAngle);
                    startAngle += sweepAngle;
                }
            }
            else if (radioButton3.Checked)
            {
                Brush[] brushes = { Brushes.Red, Brushes.Green, Brushes.Blue, Brushes.Yellow };
                int[] values = { 50, 20, 25, 15 };
                PointF[] points = { new PointF(0, height), new PointF(width / 3f, height), new PointF(width, height / 3f), new PointF(width, 0), new PointF(2 * width / 3f, 0), new PointF(0, 2 * height / 3f) };
                Point[] polyPoints = Array.ConvertAll(points, p => Point.Round(p));
                int[] polyValues = { values[0], values[1], values[2], values[3] };

                graphics.FillPolygon(new SolidBrush(Color.White), polyPoints);
                float startAngle = -90f;
                for (int i = 0; i < polyValues.Length; i++)
                {
                    float sweepAngle = polyValues[i] / (float)values.Sum() * 360f;
                    graphics.FillPie(brushes[i % brushes.Length], 0, 0, width, height, startAngle, sweepAngle);
                    startAngle += sweepAngle;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }
    }
}
