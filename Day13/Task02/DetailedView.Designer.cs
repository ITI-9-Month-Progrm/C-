
namespace Task02
{
    partial class DVForm
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblRoy = new System.Windows.Forms.Label();
            this.lblAdvance = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPupName = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtRoy = new System.Windows.Forms.TextBox();
            this.txtAdv = new System.Windows.Forms.TextBox();
            this.txtPubName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(330, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Save Changes";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(391, 220);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(389, 181);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(33, 15);
            this.lblNote.TabIndex = 18;
            this.lblNote.Text = "Note";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(391, 157);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(33, 15);
            this.lblSal.TabIndex = 17;
            this.lblSal.Text = "Sales";
            // 
            // lblRoy
            // 
            this.lblRoy.AutoSize = true;
            this.lblRoy.Location = new System.Drawing.Point(391, 119);
            this.lblRoy.Name = "lblRoy";
            this.lblRoy.Size = new System.Drawing.Size(46, 15);
            this.lblRoy.TabIndex = 16;
            this.lblRoy.Text = "royallty";
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Location = new System.Drawing.Point(391, 73);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(53, 15);
            this.lblAdvance.TabIndex = 15;
            this.lblAdvance.Text = "Advance";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(50, 229);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price";
            // 
            // lblPupName
            // 
            this.lblPupName.AutoSize = true;
            this.lblPupName.Location = new System.Drawing.Point(23, 195);
            this.lblPupName.Name = "lblPupName";
            this.lblPupName.Size = new System.Drawing.Size(91, 15);
            this.lblPupName.TabIndex = 13;
            this.lblPupName.Text = "Publisher Name";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(50, 162);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(31, 15);
            this.lbltype.TabIndex = 12;
            this.lbltype.Text = "Type";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(50, 121);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(29, 15);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Title";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 70);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(213, 23);
            this.txtID.TabIndex = 10;
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(463, 146);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(325, 23);
            this.txtSales.TabIndex = 9;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(463, 175);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(325, 23);
            this.txtNote.TabIndex = 8;
            // 
            // txtRoy
            // 
            this.txtRoy.Location = new System.Drawing.Point(463, 108);
            this.txtRoy.Name = "txtRoy";
            this.txtRoy.Size = new System.Drawing.Size(325, 23);
            this.txtRoy.TabIndex = 7;
            // 
            // txtAdv
            // 
            this.txtAdv.Location = new System.Drawing.Point(463, 67);
            this.txtAdv.Name = "txtAdv";
            this.txtAdv.Size = new System.Drawing.Size(325, 23);
            this.txtAdv.TabIndex = 6;
            // 
            // txtPubName
            // 
            this.txtPubName.Location = new System.Drawing.Point(120, 192);
            this.txtPubName.Name = "txtPubName";
            this.txtPubName.Size = new System.Drawing.Size(213, 23);
            this.txtPubName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(120, 221);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(213, 23);
            this.txtPrice.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(50, 70);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(120, 154);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(213, 23);
            this.txtType.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(120, 113);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(213, 23);
            this.txtTitle.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(463, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(325, 23);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(120, 316);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(347, 316);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 23;
            this.btnModify.Text = "Update";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(532, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblRoy);
            this.Controls.Add(this.lblAdvance);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPupName);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtRoy);
            this.Controls.Add(this.txtAdv);
            this.Controls.Add(this.txtPubName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblId);
            this.Name = "DVForm";
            this.Text = "Detailed View";
            this.Load += new System.EventHandler(this.DVForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblRoy;
        private System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPupName;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtRoy;
        private System.Windows.Forms.TextBox txtAdv;
        private System.Windows.Forms.TextBox txtPubName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
    }
}

