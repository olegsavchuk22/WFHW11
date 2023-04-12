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
    public partial class Form1 : Form
    {
        const int cell_size = 32;
        string[,] map = new string[8, 8]
        {   {"R", "H", "B", "Q", "K", "B", "H", "R"},
            {"P", "P", "P", "P", "P", "P", "P", "P"},
            {"*", "*", "*", "*", "*", "*", "*", "*"},
            {"*", "*", "*", "*", "*", "*", "*", "*"},
            {"*", "*", "*", "*", "*", "*", "*", "*"},
            {"*", "*", "*", "*", "*", "*", "*", "*"},
            {"P", "P", "P", "P", "P", "P", "P", "P"},
            {"R", "H", "B", "K", "Q", "B", "H", "R"},
        };
        PictureBox[,] pictureBox = new PictureBox[8,8];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(cell_size * 8, cell_size * 8);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Brush brush = (i + j) % 2 == 0 ? Brushes.Coral : Brushes.Brown;
                    e.Graphics.FillRectangle(brush, j * cell_size, i * cell_size, cell_size, cell_size);
                    string map_element = map[i, j];
                    if (map[i, j] != "*")
                    {
                        Font font = new Font(FontFamily.GenericMonospace, cell_size / 2);
                        SizeF size = e.Graphics.MeasureString(map_element, font);
                        PointF point = new PointF(j * cell_size + (cell_size - size.Width - 6), i * cell_size + (cell_size - size.Height));
                        e.Graphics.DrawString(map_element, font, Brushes.Black, point);

                    }
                }
            }

            

        }
    }
}
