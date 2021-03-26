
namespace UI_Layer
{
    partial class LandingPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGV = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.btnDV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGV
            // 
            this.btnGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGV.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGV.Location = new System.Drawing.Point(87, 270);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(152, 48);
            this.btnGV.TabIndex = 0;
            this.btnGV.Text = "Show GridView";
            this.btnGV.UseVisualStyleBackColor = false;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Blackadder ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblChoose.ForeColor = System.Drawing.Color.Maroon;
            this.lblChoose.Location = new System.Drawing.Point(87, 92);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(571, 82);
            this.lblChoose.TabIndex = 1;
            this.lblChoose.Text = "Hello Please Choose ^^";
            // 
            // btnDV
            // 
            this.btnDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDV.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDV.Location = new System.Drawing.Point(454, 270);
            this.btnDV.Name = "btnDV";
            this.btnDV.Size = new System.Drawing.Size(152, 48);
            this.btnDV.TabIndex = 2;
            this.btnDV.Text = "Show DetailedView";
            this.btnDV.UseVisualStyleBackColor = false;
            this.btnDV.Click += new System.EventHandler(this.btnDV_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDV);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.btnGV);
            this.Name = "LandingPage";
            this.Text = "Landing Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button btnDV;
    }
}

