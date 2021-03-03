using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile()
        {
            if(openFileDia.ShowDialog() == DialogResult.OK)
            {
                txtUserInput.LoadFile(openFileDia.FileName, 
                    (RichTextBoxStreamType)(openFileDia.FilterIndex -1));
            }
        }
        private void saveFile()
        {
            if (saveFileDia.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDia.FilterIndex)
                {
                    case 1:
                        txtUserInput.SaveFile(saveFileDia.FileName, RichTextBoxStreamType.RichText);
                        break;
                    case 2:
                        txtUserInput.SaveFile(saveFileDia.FileName, RichTextBoxStreamType.PlainText);
                        break;
                }
            }
        }
        private void changeFont()
        {
            if (txtUserInput.SelectedText?.Length > 0)
                fontDia.Font = txtUserInput.SelectionFont;

            if (fontDia.ShowDialog() == DialogResult.OK)
                txtUserInput.SelectionFont = fontDia.Font;
        }
        private void changeColor()
        {
            if (txtUserInput.SelectedText?.Length > 0)
                colorDia.Color = txtUserInput.SelectionColor;

            if (colorDia.ShowDialog() == DialogResult.OK)
                txtUserInput.SelectionColor = colorDia.Color;
        }
        

        //----------------------------------------------------------------- 
        private void openFileItem_Click(object sender, EventArgs e)
        {
            openFile();

        }

        private void notepadeContextMenu_Opening(object sender, CancelEventArgs e)
        {
            contextMenu1.ShowDropDown();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDia.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
            saveFileDia.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
        }

        private void saveFileItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        

        private void fontFileItem_Click(object sender, EventArgs e)
        {
            changeFont();
        }

        private void fontStripButton_Click(object sender, EventArgs e)
        {
            changeFont();
        }

        private void colorFileItem_Click(object sender, EventArgs e)
        {
            changeColor();
        }

        private void colorStripButton_Click(object sender, EventArgs e)
        {
            changeColor();

        }

        private void closeFileItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void closeStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _fileItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void colorFileContext_Click(object sender, EventArgs e)
        {
            changeColor();
        }

        private void openFileContext_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveFileContext_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void closeFileContext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontFileContext_Click(object sender, EventArgs e)
        {
            changeFont();
        }

        private void notepadeContextMenu_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenu1.Enabled = true;
            contextMenu1.ShowDropDown();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
