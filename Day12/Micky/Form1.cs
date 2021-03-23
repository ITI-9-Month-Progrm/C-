using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Micky
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			//this.Opacity = .1;
			this.TransparencyKey = (BackColor);
		}


		private void mickey_Paint(object sender, PaintEventArgs e)
		{

			e.Graphics.FillEllipse(Brushes.Black, 90, 120, 120, 120);
			e.Graphics.FillEllipse(Brushes.Black, 390, 100, 120, 120);
			e.Graphics.FillEllipse(Brushes.NavajoWhite, 157, 157, 330, 300);

			e.Graphics.FillEllipse(Brushes.White, 350, 230, 50, 80);
			e.Graphics.FillEllipse(Brushes.Black, 350, 230, 30, 50);
			e.Graphics.FillEllipse(Brushes.White, 250, 230, 50, 80);
			e.Graphics.FillEllipse(Brushes.Black, 250, 230, 30, 50);
			e.Graphics.FillEllipse(Brushes.Black, 240, 370, 150, 20);
			


		}

		private void groupBox1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;

		private void label2_MouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}
		private void label2_MouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}

		private void label2_MouseUp(object sender, MouseEventArgs e)
		{

			dragging = false;
		}

       
    }
}
