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
    public partial class Form3 : Form
    {
        double xMax = 0; double yMax = 0;
        double xMin = 0; double yMin = 0;
        double xScale = 0; double yScale = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Draw_Sin(Graphics g)
        {
            g.Clear(Color.White);
            xMax = Math.PI; xMin = -Math.PI;
            yMax = 1f; yMin = -1f;
            xScale = pictureBox1.Width/(xMax-xMin);
            yScale = pictureBox1.Height/(yMax-yMin);

            g.DrawLine(Pens.Black, 0, (float)(yScale * yMax), pictureBox1.Width, (float)(yScale * yMax));
            g.DrawLine(Pens.Black, (float)(xScale * -(xMin)), 0, (float)(xScale * -(xMin)), pictureBox1.Height);

            PointF[] points = new PointF[pictureBox1.Width];
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                float x = (float)(xMin + i / xScale);
                float y = (float)Math.Sin(x);
                points[i] = new PointF(i, (float)(pictureBox1.Height - (y - yMin) * yScale));
            }
            g.DrawCurve(Pens.Red, points);
        }
        private void Draw_Cos(Graphics g)
        {
            g.Clear(Color.White);
            xMax = Math.PI; xMin = -Math.PI;
            yMax = 1f; yMin = -1f;
            xScale = pictureBox1.Width / (xMax - xMin);
            yScale = pictureBox1.Height / (yMax - yMin);

            g.DrawLine(Pens.Black, 0, (float)(yScale * yMax), pictureBox1.Width, (float)(yScale * yMax));
            g.DrawLine(Pens.Black, (float)(xScale * -(xMin)), 0, (float)(xScale * -(xMin)), pictureBox1.Height);

            PointF[] points = new PointF[pictureBox1.Width];
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                float x = (float)(xMin + i / xScale);
                float y = (float)Math.Cos(x);
                points[i] = new PointF(i, (float)(pictureBox1.Height - (y - yMin) * yScale));
            }
            g.DrawCurve(Pens.Red, points);
        }
        private void Draw_Tan(Graphics g)
        {
            g.Clear(Color.White);
            xMax = Math.PI; xMin = -Math.PI;
            yMax = 5f; yMin = -5f;
            xScale = pictureBox1.Width / (xMax - xMin);
            yScale = pictureBox1.Height / (yMax - yMin);

            g.DrawLine(Pens.Black, 0, (float)(yScale * yMax), pictureBox1.Width, (float)(yScale * yMax));
            g.DrawLine(Pens.Black, (float)(xScale * -(xMin)), 0, (float)(xScale * -(xMin)), pictureBox1.Height);

            PointF[] points = new PointF[pictureBox1.Width];
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                float x = (float)(xMin + i / xScale);
                float y = (float)Math.Tan(x);
                points[i] = new PointF(i, (float)(pictureBox1.Height - (y - yMin) * yScale));
            }
            g.DrawCurve(Pens.Red, points);
        }
        private void Draw_Cot(Graphics g)
        {
            g.Clear(Color.White);
            xMax = Math.PI; xMin = -Math.PI;
            yMax = 5f; yMin = -5f;
            xScale = pictureBox1.Width / (xMax - xMin);
            yScale = pictureBox1.Height / (yMax - yMin);

            g.DrawLine(Pens.Black, 0, (float)(yScale * yMax), pictureBox1.Width, (float)(yScale * yMax));
            g.DrawLine(Pens.Black, (float)(xScale * -(xMin)), 0, (float)(xScale * -(xMin)), pictureBox1.Height);

            PointF[] points = new PointF[pictureBox1.Width];
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                float x = (float)(xMin + i / xScale);
                float y = 1 / (float)Math.Tan(x);
                points[i] = new PointF(i, (float)(pictureBox1.Height - (y - yMin) * yScale));
            }
            g.DrawCurve(Pens.Red, points);
        }
        private void Draw_Exp(Graphics g)
        {
            g.Clear(Color.White);
            xMax = 5f; xMin = -5f;
            yMax = 10f; yMin = -10f;
            xScale = pictureBox1.Width / (xMax - xMin);
            yScale = pictureBox1.Height / (yMax - yMin);

            g.DrawLine(Pens.Black, 0, (float)(yScale * yMax), pictureBox1.Width, (float)(yScale * yMax));
            g.DrawLine(Pens.Black, (float)(xScale * -(xMin)), 0, (float)(xScale * -(xMin)), pictureBox1.Height);

            PointF[] points = new PointF[pictureBox1.Width];
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                float x = (float)(xMin + i / xScale);
                float y = (float)Math.Exp(x);
                points[i] = new PointF(i, (float)(pictureBox1.Height - (y - yMin) * yScale));
            }
            g.DrawCurve(Pens.Red, points);
        }
        private void Draw_Pow(Graphics g)
        {
            g.Clear(Color.White);
            xMax = 5f; xMin = -5f;
            yMax = 10f; yMin = -10f;
            xScale = pictureBox1.Width / (xMax - xMin);
            yScale = pictureBox1.Height / (yMax - yMin);

            g.DrawLine(Pens.Black, 0, (float)(yScale * yMax), pictureBox1.Width, (float)(yScale * yMax));
            g.DrawLine(Pens.Black, (float)(xScale * -(xMin)), 0, (float)(xScale * -(xMin)), pictureBox1.Height);

            PointF[] points = new PointF[pictureBox1.Width];
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                float x = (float)(xMin + i / xScale);
                float y = (float)Math.Pow(x, 2);
                points[i] = new PointF(i, (float)(pictureBox1.Height - (y - yMin) * yScale));
            }
            g.DrawCurve(Pens.Red, points);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (radioButton1.Checked)
            {
                Draw_Sin(g);
            }
            if (radioButton2.Checked)
            {
                Draw_Cos(g);
            }
            if (radioButton3.Checked)
            {
                Draw_Tan(g);
            }
            if (radioButton4.Checked)
            {
                Draw_Cot(g);
            }
            if (radioButton5.Checked)
            {
                Draw_Exp(g);
            }
            if (radioButton6.Checked)
            {
                Draw_Pow(g);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }
    }
}
