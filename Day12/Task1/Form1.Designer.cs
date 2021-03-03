
namespace Task1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUserInput = new System.Windows.Forms.RichTextBox();
            this.colorDia = new System.Windows.Forms.ColorDialog();
            this.fontDia = new System.Windows.Forms.FontDialog();
            this.openFileDia = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDia = new System.Windows.Forms.SaveFileDialog();
            this.notepadMenus = new System.Windows.Forms.MenuStrip();
            this.fileMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this._fileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.fontFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileContext = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileContext = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileContext = new System.Windows.Forms.ToolStripMenuItem();
            this.fontFileContext = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFileContext = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStrip = new System.Windows.Forms.ToolStrip();
            this.openStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveStripButton = new System.Windows.Forms.ToolStripButton();
            this.closeStripButton = new System.Windows.Forms.ToolStripButton();
            this.fontStripButton = new System.Windows.Forms.ToolStripButton();
            this.colorStripButton = new System.Windows.Forms.ToolStripButton();
            this.notepadMenus.SuspendLayout();
            this.notepadeContextMenu.SuspendLayout();
            this.notepadToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(12, 65);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(776, 373);
            this.txtUserInput.TabIndex = 0;
            this.txtUserInput.Text = "";
            // 
            // openFileDia
            // 
            this.openFileDia.InitialDirectory = "D:\\CSharp\\Day12\\Task1\\notepadFiles";
            // 
            // notepadMenus
            // 
            this.notepadMenus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notepadMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItems,
            this.editMenuItems});
            this.notepadMenus.Location = new System.Drawing.Point(0, 0);
            this.notepadMenus.Name = "notepadMenus";
            this.notepadMenus.Size = new System.Drawing.Size(800, 24);
            this.notepadMenus.TabIndex = 1;
            this.notepadMenus.Text = "fileMenu";
            // 
            // fileMenuItems
            // 
            this.fileMenuItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileItem,
            this.saveFileItem,
            this._fileItem,
            this.closeFileItem});
            this.fileMenuItems.Name = "fileMenuItems";
            this.fileMenuItems.Size = new System.Drawing.Size(38, 20);
            this.fileMenuItems.Text = "File";
            // 
            // openFileItem
            // 
            this.openFileItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openFileItem.Name = "openFileItem";
            this.openFileItem.Size = new System.Drawing.Size(138, 22);
            this.openFileItem.Text = "open";
            this.openFileItem.Click += new System.EventHandler(this.openFileItem_Click);
            // 
            // saveFileItem
            // 
            this.saveFileItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveFileItem.Name = "saveFileItem";
            this.saveFileItem.Size = new System.Drawing.Size(138, 22);
            this.saveFileItem.Text = "save";
            this.saveFileItem.Click += new System.EventHandler(this.saveFileItem_Click);
            // 
            // _fileItem
            // 
            this._fileItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fileItem.Name = "_fileItem";
            this._fileItem.Size = new System.Drawing.Size(138, 22);
            this._fileItem.Text = "-";
            this._fileItem.Click += new System.EventHandler(this._fileItem_Click);
            // 
            // closeFileItem
            // 
            this.closeFileItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeFileItem.Name = "closeFileItem";
            this.closeFileItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.closeFileItem.Size = new System.Drawing.Size(138, 22);
            this.closeFileItem.Text = "close";
            this.closeFileItem.Click += new System.EventHandler(this.closeFileItem_Click);
            // 
            // editMenuItems
            // 
            this.editMenuItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontFileItem,
            this.colorFileItem});
            this.editMenuItems.Name = "editMenuItems";
            this.editMenuItems.Size = new System.Drawing.Size(40, 20);
            this.editMenuItems.Text = "Edit";
            // 
            // fontFileItem
            // 
            this.fontFileItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fontFileItem.Name = "fontFileItem";
            this.fontFileItem.Size = new System.Drawing.Size(101, 22);
            this.fontFileItem.Text = "Font";
            this.fontFileItem.Click += new System.EventHandler(this.fontFileItem_Click);
            // 
            // colorFileItem
            // 
            this.colorFileItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorFileItem.Name = "colorFileItem";
            this.colorFileItem.Size = new System.Drawing.Size(101, 22);
            this.colorFileItem.Text = "color";
            this.colorFileItem.Click += new System.EventHandler(this.colorFileItem_Click);
            // 
            // notepadeContextMenu
            // 
            this.notepadeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenu1});
            this.notepadeContextMenu.Name = "notepadeContextMenu";
            this.notepadeContextMenu.Size = new System.Drawing.Size(89, 26);
            this.notepadeContextMenu.Text = "contextMenu";
            this.notepadeContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.notepadeContextMenu_Opening);
            this.notepadeContextMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notepadeContextMenu_MouseClick);
            // 
            // contextMenu1
            // 
            this.contextMenu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileContext,
            this.saveFileContext,
            this.closeFileContext,
            this.fontFileContext,
            this.colorFileContext});
            this.contextMenu1.Name = "contextMenu1";
            this.contextMenu1.Size = new System.Drawing.Size(88, 22);
            this.contextMenu1.Text = "All";
            // 
            // openFileContext
            // 
            this.openFileContext.Name = "openFileContext";
            this.openFileContext.Size = new System.Drawing.Size(101, 22);
            this.openFileContext.Text = "open";
            this.openFileContext.Click += new System.EventHandler(this.openFileContext_Click);
            // 
            // saveFileContext
            // 
            this.saveFileContext.Name = "saveFileContext";
            this.saveFileContext.Size = new System.Drawing.Size(101, 22);
            this.saveFileContext.Text = "save";
            this.saveFileContext.Click += new System.EventHandler(this.saveFileContext_Click);
            // 
            // closeFileContext
            // 
            this.closeFileContext.Name = "closeFileContext";
            this.closeFileContext.Size = new System.Drawing.Size(101, 22);
            this.closeFileContext.Text = "close";
            this.closeFileContext.Click += new System.EventHandler(this.closeFileContext_Click);
            // 
            // fontFileContext
            // 
            this.fontFileContext.Name = "fontFileContext";
            this.fontFileContext.Size = new System.Drawing.Size(101, 22);
            this.fontFileContext.Text = "font";
            this.fontFileContext.Click += new System.EventHandler(this.fontFileContext_Click);
            // 
            // colorFileContext
            // 
            this.colorFileContext.Name = "colorFileContext";
            this.colorFileContext.Size = new System.Drawing.Size(101, 22);
            this.colorFileContext.Text = "color";
            this.colorFileContext.Click += new System.EventHandler(this.colorFileContext_Click);
            // 
            // notepadToolStrip
            // 
            this.notepadToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStripButton,
            this.saveStripButton,
            this.closeStripButton,
            this.fontStripButton,
            this.colorStripButton});
            this.notepadToolStrip.Location = new System.Drawing.Point(0, 24);
            this.notepadToolStrip.Name = "notepadToolStrip";
            this.notepadToolStrip.Size = new System.Drawing.Size(800, 25);
            this.notepadToolStrip.TabIndex = 2;
            this.notepadToolStrip.Text = "open";
            // 
            // openStripButton
            // 
            this.openStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openStripButton.Image")));
            this.openStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openStripButton.Name = "openStripButton";
            this.openStripButton.Size = new System.Drawing.Size(23, 22);
            this.openStripButton.Text = "open";
            this.openStripButton.Click += new System.EventHandler(this.openStripButton_Click);
            // 
            // saveStripButton
            // 
            this.saveStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveStripButton.Image")));
            this.saveStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveStripButton.Name = "saveStripButton";
            this.saveStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveStripButton.Text = "save";
            this.saveStripButton.Click += new System.EventHandler(this.saveStripButton_Click);
            // 
            // closeStripButton
            // 
            this.closeStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeStripButton.Image = ((System.Drawing.Image)(resources.GetObject("closeStripButton.Image")));
            this.closeStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeStripButton.Name = "closeStripButton";
            this.closeStripButton.Size = new System.Drawing.Size(23, 22);
            this.closeStripButton.Text = "close";
            this.closeStripButton.Click += new System.EventHandler(this.closeStripButton_Click);
            // 
            // fontStripButton
            // 
            this.fontStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fontStripButton.Image")));
            this.fontStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontStripButton.Name = "fontStripButton";
            this.fontStripButton.Size = new System.Drawing.Size(23, 22);
            this.fontStripButton.Text = "font";
            this.fontStripButton.Click += new System.EventHandler(this.fontStripButton_Click);
            // 
            // colorStripButton
            // 
            this.colorStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colorStripButton.Image")));
            this.colorStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorStripButton.Name = "colorStripButton";
            this.colorStripButton.Size = new System.Drawing.Size(23, 22);
            this.colorStripButton.Text = "color";
            this.colorStripButton.Click += new System.EventHandler(this.colorStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notepadToolStrip);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.notepadMenus);
            this.MainMenuStrip = this.notepadMenus;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.notepadMenus.ResumeLayout(false);
            this.notepadMenus.PerformLayout();
            this.notepadeContextMenu.ResumeLayout(false);
            this.notepadToolStrip.ResumeLayout(false);
            this.notepadToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtUserInput;
        private System.Windows.Forms.ColorDialog colorDia;
        private System.Windows.Forms.FontDialog fontDia;
        private System.Windows.Forms.OpenFileDialog openFileDia;
        private System.Windows.Forms.SaveFileDialog saveFileDia;
        private System.Windows.Forms.MenuStrip notepadMenus;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItems;
        private System.Windows.Forms.ToolStripMenuItem openFileItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileItem;
        private System.Windows.Forms.ToolStripMenuItem _fileItem;
        private System.Windows.Forms.ToolStripMenuItem closeFileItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItems;
        private System.Windows.Forms.ToolStripMenuItem fontFileItem;
        private System.Windows.Forms.ToolStripMenuItem colorFileItem;
        private System.Windows.Forms.ContextMenuStrip notepadeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextMenu1;
        private System.Windows.Forms.ToolStripMenuItem openFileContext;
        private System.Windows.Forms.ToolStripMenuItem saveFileContext;
        private System.Windows.Forms.ToolStripMenuItem closeFileContext;
        private System.Windows.Forms.ToolStripMenuItem fontFileContext;
        private System.Windows.Forms.ToolStripMenuItem colorFileContext;
        private System.Windows.Forms.ToolStrip notepadToolStrip;
        private System.Windows.Forms.ToolStripButton openStripButton;
        private System.Windows.Forms.ToolStripButton saveStripButton;
        private System.Windows.Forms.ToolStripButton closeStripButton;
        private System.Windows.Forms.ToolStripButton fontStripButton;
        private System.Windows.Forms.ToolStripButton colorStripButton;
    }
}

