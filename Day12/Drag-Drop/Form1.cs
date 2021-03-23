using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drag_Drop
{
	public partial class Form1 : Form
	{
		

		
		Rectangle rec = new Rectangle(10, 10, 100, 100);
		public Form1()
		{
			InitializeComponent();
		}
		private void OnPaint(object sender, PaintEventArgs r)
		{
			r.Graphics.FillRectangle(Brushes.LightBlue, rec);
		}
		private void recmousedown(object sender, MouseEventArgs m)
		{
			if (m.Button != MouseButtons.Left)
				return;
			
			rec = new Rectangle(m.X - 50 / 2, m.Y - 50 / 2, 100, 100);
		}


		private void recmousemove(object sender, MouseEventArgs m)
		{
			

			if (m.Button != MouseButtons.Left)
				return;
			rec = new Rectangle(m.X - 50 / 2, m.Y - 50 / 2, 100, 100);
			Invalidate();
		}
	}
}
