
namespace UI_Layer
{
    partial class DV_Form
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.pubComboBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.sales = new System.Windows.Forms.NumericUpDown();
            this.royal = new System.Windows.Forms.NumericUpDown();
            this.advance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.titleID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.royal)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.deleteBtn.Location = new System.Drawing.Point(533, 356);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(82, 38);
            this.deleteBtn.TabIndex = 81;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.insertBtn.Location = new System.Drawing.Point(259, 356);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(82, 38);
            this.insertBtn.TabIndex = 80;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // pubComboBox
            // 
            this.pubComboBox.FormattingEnabled = true;
            this.pubComboBox.Location = new System.Drawing.Point(217, 251);
            this.pubComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pubComboBox.Name = "pubComboBox";
            this.pubComboBox.Size = new System.Drawing.Size(154, 23);
            this.pubComboBox.TabIndex = 79;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.saveBtn.Location = new System.Drawing.Point(391, 356);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(82, 38);
            this.saveBtn.TabIndex = 77;
            this.saveBtn.Text = "Update";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(533, 300);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(154, 23);
            this.date.TabIndex = 75;
            // 
            // sales
            // 
            this.sales.Location = new System.Drawing.Point(533, 208);
            this.sales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sales.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(153, 23);
            this.sales.TabIndex = 74;
            // 
            // royal
            // 
            this.royal.Location = new System.Drawing.Point(533, 164);
            this.royal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.royal.Name = "royal";
            this.royal.Size = new System.Drawing.Size(153, 23);
            this.royal.TabIndex = 73;
            // 
            // advance
            // 
            this.advance.Location = new System.Drawing.Point(533, 121);
            this.advance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.advance.Name = "advance";
            this.advance.Size = new System.Drawing.Size(154, 23);
            this.advance.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(412, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 71;
            this.label8.Text = "Publish date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(422, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 70;
            this.label9.Text = "Sales:";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(533, 252);
            this.notes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(154, 23);
            this.notes.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(422, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 68;
            this.label10.Text = "Notes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(422, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 67;
            this.label11.Text = "Royalty:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(422, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 66;
            this.label12.Text = "Advance:";
            // 
            // titleID
            // 
            this.titleID.Location = new System.Drawing.Point(217, 121);
            this.titleID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleID.Name = "titleID";
            this.titleID.Size = new System.Drawing.Size(154, 23);
            this.titleID.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.OliveDrab;
            this.label7.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(338, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 27);
            this.label7.TabIndex = 64;
            this.label7.Text = "Titles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(114, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Price";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(217, 300);
            this.price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(154, 23);
            this.price.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(118, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(114, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Type:";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(217, 208);
            this.type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(154, 23);
            this.type.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Title:";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(217, 164);
            this.title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(154, 23);
            this.title.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID:";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.OliveDrab;
            this.btnHome.Location = new System.Drawing.Point(74, 356);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(87, 38);
            this.btnHome.TabIndex = 82;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // DV_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.pubComboBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.date);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.royal);
            this.Controls.Add(this.advance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.titleID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Name = "DV_Form";
            this.Text = "DV_Form";
            this.Load += new System.EventHandler(this.DV_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.royal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.ComboBox pubComboBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.NumericUpDown sales;
        private System.Windows.Forms.NumericUpDown royal;
        private System.Windows.Forms.TextBox advance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox titleID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
    }
}