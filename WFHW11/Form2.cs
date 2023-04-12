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
    public partial class Form2 : Form
    {
        int c = 0;
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Draw_Rectangle(Graphics g)
        {
            Rectangle rectangle = new Rectangle(50, 50, 200, 100);
            g.DrawRectangle(Pens.Black, rectangle);
        }
        private void Draw_Square(Graphics g)
        {
            Rectangle rectangle = new Rectangle(50, 50, 100, 100);
            g.DrawRectangle(Pens.Black, rectangle);
        }
        private void Draw_Circle(Graphics g)
        {
            Rectangle rectangle = new Rectangle(50, 50, 100, 100);
            g.DrawEllipse(Pens.Black, rectangle);
        }
        private void Draw_Triangle(Graphics g)
        {
            PointF[] points = new PointF[3] 
            {
                new PointF(50, 150),
                new PointF(100, 50),
                new PointF(150, 150),
            };
            g.DrawPolygon(Pens.Black, points);
        }
        private void Draw_Plus(Graphics g)
        {
            PointF[] points = new PointF[12]
            {
                new PointF(50, 115),
                new PointF(50, 85),
                new PointF(85, 85),
                new PointF(85, 50),
                new PointF(115, 50),
                new PointF(115, 85),
                new PointF(150, 85),
                new PointF(150, 115),
                new PointF(115, 115),
                new PointF(115, 150),
                new PointF(85, 150),
                new PointF(85, 115),
            };
            g.DrawPolygon(Pens.Black, points);
        }
        private void Draw_Star(Graphics g)
        {
            PointF[] points = new PointF[10]
            {
                new PointF(100, 50),
                new PointF(110, 90),
                new PointF(150, 90),
                new PointF(120, 110),
                new PointF(130, 150),
                new PointF(100, 125),
                new PointF(70, 150),
                new PointF(80, 110),
                new PointF(50, 90),
                new PointF(90, 90),
            };
            g.DrawPolygon(Pens.Black, points);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            switch (c)
            {
                case 1: Draw_Rectangle(g); break;
                case 2: Draw_Square(g); break;
                case 3: Draw_Circle(g); break;
                case 4: Draw_Triangle(g); break;
                case 5: Draw_Plus(g); break;
                case 6: Draw_Star(g); break;
            }
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = 1;
            pictureBox1.Invalidate();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            c = 2;
            pictureBox1.Invalidate();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            c = 3;
            pictureBox1.Invalidate();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            c = 4;
            pictureBox1.Invalidate();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            c = 5;
            pictureBox1.Invalidate();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            c = 6;
            pictureBox1.Invalidate();
        }
    }
}
