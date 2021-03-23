using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool drw;
        int beginX, beginY;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drw = true;
            beginX = e.X;
            beginY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drw = false;

        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                Pen p = new Pen(colorDialog1.Color, 4);
                Point point1 = new Point(beginX, beginY);
                Point point2 = new Point(e.X, e.Y);
                if (drw == true)
                {
                    g.DrawLine(p, point1, point2);
                    beginX = e.X;
                    beginY = e.Y;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {

                Pen p = new Pen(Color.White, 4);
                Point point1 = new Point(beginX, beginY);
                Point point2 = new Point(e.X, e.Y);
                if (drw == true)
                {
                    g.DrawLine(p, point1, point2);
                    beginX = e.X;
                    beginY = e.Y;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "csharp-console-examples.com";
            this.BackColor = Color.Black;
        }
    }
}
