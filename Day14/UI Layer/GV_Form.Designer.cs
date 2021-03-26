
namespace UI_Layer
{
    partial class GV_Form
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
            this.dgvTitle = new System.Windows.Forms.DataGridView();
            this.btnHomeFromGV = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTitle
            // 
            this.dgvTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTitle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitle.Location = new System.Drawing.Point(12, 12);
            this.dgvTitle.Name = "dgvTitle";
            this.dgvTitle.RowTemplate.Height = 25;
            this.dgvTitle.Size = new System.Drawing.Size(776, 348);
            this.dgvTitle.TabIndex = 0;
            this.dgvTitle.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTitle_RowHeaderMouseClick);
            this.dgvTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTitle_KeyDown);
            // 
            // btnHomeFromGV
            // 
            this.btnHomeFromGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHomeFromGV.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnHomeFromGV.Location = new System.Drawing.Point(117, 387);
            this.btnHomeFromGV.Name = "btnHomeFromGV";
            this.btnHomeFromGV.Size = new System.Drawing.Size(116, 51);
            this.btnHomeFromGV.TabIndex = 1;
            this.btnHomeFromGV.Text = "Home";
            this.btnHomeFromGV.UseVisualStyleBackColor = false;
            this.btnHomeFromGV.Click += new System.EventHandler(this.btnHomeFromGV_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUpdate.Location = new System.Drawing.Point(454, 387);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 51);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Svae Changes";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // GV_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHomeFromGV);
            this.Controls.Add(this.dgvTitle);
            this.Name = "GV_Form";
            this.Text = "GV_Form";
            this.Load += new System.EventHandler(this.GV_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTitle;
        private System.Windows.Forms.Button btnHomeFromGV;
        private System.Windows.Forms.Button btnUpdate;
    }
}