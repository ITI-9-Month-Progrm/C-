using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Rectangle r = new Rectangle(150, 350, 70, 70);
		private void Ball_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.FillEllipse(Brushes.Black, 90, 90, 100, 100);
			e.Graphics.FillEllipse(Brushes.Black, 680, 90, 100, 100);
			Pen p = new Pen(Color.Black, 4);
			e.Graphics.DrawLine(p, 140, 100, 140, 700);
			e.Graphics.DrawLine(p, 730, 100, 730, 700);

			e.Graphics.FillEllipse(Brushes.DarkCyan, r);



		}

		int f = 0;
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (r.X <= 150)
			{
				f = 1;
			}
			else if (r.X >= 630)
			{

				f = -1;
			}

			r.X += f * 5;
			Invalidate();
		}
	}
}
