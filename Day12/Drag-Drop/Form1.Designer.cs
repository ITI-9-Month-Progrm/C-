﻿
namespace Drag_Drop
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// rectangle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 436);
			this.Name = "rectangle";
			this.Text = "rectangle";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.recmousedown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.recmousemove);
			this.ResumeLayout(false);

		}

		#endregion
	}
}

