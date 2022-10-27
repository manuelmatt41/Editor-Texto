namespace Editor_Texto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newDocumentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.selectInformationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.writeModeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uppercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newDocumentToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.selectAllToolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.selectedTextToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.phrasesToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.wordsToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.charactersToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.toolsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDocumentMenu,
            this.saveFileMenu,
            this.openFileMenu,
            this.recentFilesMenu,
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // newDocumentMenu
            // 
            this.newDocumentMenu.Name = "newDocumentMenu";
            this.newDocumentMenu.Size = new System.Drawing.Size(157, 22);
            this.newDocumentMenu.Text = "New Document";
            this.newDocumentMenu.Click += new System.EventHandler(this.NewDocument);
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.Size = new System.Drawing.Size(157, 22);
            this.saveFileMenu.Text = "Save File";
            this.saveFileMenu.Click += new System.EventHandler(this.SaveDocument);
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.Size = new System.Drawing.Size(157, 22);
            this.openFileMenu.Text = "Open File";
            this.openFileMenu.Click += new System.EventHandler(this.OpenDocument);
            // 
            // recentFilesMenu
            // 
            this.recentFilesMenu.Name = "recentFilesMenu";
            this.recentFilesMenu.Size = new System.Drawing.Size(157, 22);
            this.recentFilesMenu.Text = "Recent Files";
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(157, 22);
            this.exitMenu.Text = "Exit";
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenu,
            this.copyMenu,
            this.cutMenu,
            this.pasteMenu,
            this.selectAllMenu,
            this.selectInformationMenu});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // undoMenu
            // 
            this.undoMenu.Name = "undoMenu";
            this.undoMenu.Size = new System.Drawing.Size(171, 22);
            this.undoMenu.Text = "Undo";
            // 
            // copyMenu
            // 
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.Size = new System.Drawing.Size(171, 22);
            this.copyMenu.Text = "Copy";
            // 
            // cutMenu
            // 
            this.cutMenu.Name = "cutMenu";
            this.cutMenu.Size = new System.Drawing.Size(171, 22);
            this.cutMenu.Text = "Cut";
            // 
            // pasteMenu
            // 
            this.pasteMenu.Name = "pasteMenu";
            this.pasteMenu.Size = new System.Drawing.Size(171, 22);
            this.pasteMenu.Text = "Paste";
            // 
            // selectAllMenu
            // 
            this.selectAllMenu.Name = "selectAllMenu";
            this.selectAllMenu.Size = new System.Drawing.Size(171, 22);
            this.selectAllMenu.Text = "Select All";
            // 
            // selectInformationMenu
            // 
            this.selectInformationMenu.Name = "selectInformationMenu";
            this.selectInformationMenu.Size = new System.Drawing.Size(171, 22);
            this.selectInformationMenu.Text = "Select information";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapMenu,
            this.writeModeMenu,
            this.textColorMenu,
            this.backgroundColorMenu,
            this.aboutMenu});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(46, 20);
            this.toolsMenu.Text = "Tools";
            // 
            // wordWrapMenu
            // 
            this.wordWrapMenu.CheckOnClick = true;
            this.wordWrapMenu.Name = "wordWrapMenu";
            this.wordWrapMenu.Size = new System.Drawing.Size(170, 22);
            this.wordWrapMenu.Text = "WordWrap";
            // 
            // writeModeMenu
            // 
            this.writeModeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uppercaseToolStripMenuItem,
            this.lowercaseToolStripMenuItem,
            this.normalToolStripMenuItem});
            this.writeModeMenu.Name = "writeModeMenu";
            this.writeModeMenu.Size = new System.Drawing.Size(170, 22);
            this.writeModeMenu.Text = "Write Mode";
            // 
            // uppercaseToolStripMenuItem
            // 
            this.uppercaseToolStripMenuItem.CheckOnClick = true;
            this.uppercaseToolStripMenuItem.Name = "uppercaseToolStripMenuItem";
            this.uppercaseToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.uppercaseToolStripMenuItem.Text = "Uppercase";
            // 
            // lowercaseToolStripMenuItem
            // 
            this.lowercaseToolStripMenuItem.CheckOnClick = true;
            this.lowercaseToolStripMenuItem.Name = "lowercaseToolStripMenuItem";
            this.lowercaseToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.lowercaseToolStripMenuItem.Text = "Lowercase";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.CheckOnClick = true;
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            // 
            // textColorMenu
            // 
            this.textColorMenu.Name = "textColorMenu";
            this.textColorMenu.Size = new System.Drawing.Size(170, 22);
            this.textColorMenu.Text = "Text Color";
            // 
            // backgroundColorMenu
            // 
            this.backgroundColorMenu.Name = "backgroundColorMenu";
            this.backgroundColorMenu.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorMenu.Text = "Background Color";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(170, 22);
            this.aboutMenu.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDocumentToolStripButton1,
            this.saveToolStripButton2,
            this.openToolStripButton3,
            this.toolStripSeparator1,
            this.undoToolStripButton4,
            this.copyToolStripButton5,
            this.cutToolStripButton6,
            this.pasteToolStripButton7,
            this.selectAllToolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newDocumentToolStripButton1
            // 
            this.newDocumentToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newDocumentToolStripButton1.Image = global::Editor_Texto.Properties.Resources.outline_note_add_black_24dp;
            this.newDocumentToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newDocumentToolStripButton1.Name = "newDocumentToolStripButton1";
            this.newDocumentToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.newDocumentToolStripButton1.Text = "toolStripButton1";
            // 
            // saveToolStripButton2
            // 
            this.saveToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton2.Image = global::Editor_Texto.Properties.Resources.outline_save_black_24dp;
            this.saveToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton2.Name = "saveToolStripButton2";
            this.saveToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton2.Text = "toolStripButton2";
            // 
            // openToolStripButton3
            // 
            this.openToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton3.Image = global::Editor_Texto.Properties.Resources.outline_folder_open_black_24dp;
            this.openToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton3.Name = "openToolStripButton3";
            this.openToolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.undoToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoToolStripButton4.Image = global::Editor_Texto.Properties.Resources.outline_undo_black_24dp;
            this.undoToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoToolStripButton4.Name = "toolStripButton4";
            this.undoToolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.undoToolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.copyToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton5.Image = global::Editor_Texto.Properties.Resources.outline_content_copy_black_24dp;
            this.copyToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton5.Name = "toolStripButton5";
            this.copyToolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.cutToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton6.Image = global::Editor_Texto.Properties.Resources.outline_content_cut_black_24dp;
            this.cutToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton6.Name = "toolStripButton6";
            this.cutToolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            this.pasteToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton7.Image = global::Editor_Texto.Properties.Resources.outline_content_paste_black_24dp;
            this.pasteToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton7.Name = "toolStripButton7";
            this.pasteToolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripButton8
            // 
            this.selectAllToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectAllToolStripButton8.Image = global::Editor_Texto.Properties.Resources.outline_select_all_black_24dp;
            this.selectAllToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectAllToolStripButton8.Name = "toolStripButton8";
            this.selectAllToolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.selectAllToolStripButton8.Text = "toolStripButton8";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.InitialDirectory = "c:\\";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Texto (*.txt)|*.txt";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedTextToolStripLabel1,
            this.toolStripSeparator2,
            this.phrasesToolStripLabel1,
            this.toolStripSeparator3,
            this.wordsToolStripLabel1,
            this.toolStripSeparator4,
            this.charactersToolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 425);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // selectedTextToolStripLabel1
            // 
            this.selectedTextToolStripLabel1.Name = "selectedTextToolStripLabel1";
            this.selectedTextToolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // phrasesToolStripLabel1
            // 
            this.phrasesToolStripLabel1.Name = "phrasesToolStripLabel1";
            this.phrasesToolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // wordsToolStripLabel1
            // 
            this.wordsToolStripLabel1.Name = "wordsToolStripLabel1";
            this.wordsToolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // charactersToolStripLabel1
            // 
            this.charactersToolStripLabel1.Name = "charactersToolStripLabel1";
            this.charactersToolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem newDocumentMenu;
        private ToolStripMenuItem saveFileMenu;
        private ToolStripMenuItem openFileMenu;
        private ToolStripMenuItem recentFilesMenu;
        private ToolStripMenuItem exitMenu;
        private ToolStripMenuItem editMenu;
        private ToolStripMenuItem undoMenu;
        private ToolStripMenuItem copyMenu;
        private ToolStripMenuItem cutMenu;
        private ToolStripMenuItem pasteMenu;
        private ToolStripMenuItem selectAllMenu;
        private ToolStripMenuItem selectInformationMenu;
        private ToolStripMenuItem toolsMenu;
        private ToolStripMenuItem wordWrapMenu;
        private ToolStripMenuItem writeModeMenu;
        private ToolStripMenuItem textColorMenu;
        private ToolStripMenuItem backgroundColorMenu;
        private ToolStripMenuItem aboutMenu;
        private ToolStrip toolStrip1;
        private ToolStripButton newDocumentToolStripButton1;
        private ToolStripButton saveToolStripButton2;
        private ToolStripButton openToolStripButton3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton undoToolStripButton4;
        private ToolStripButton copyToolStripButton5;
        private ToolStripButton cutToolStripButton6;
        private ToolStripButton pasteToolStripButton7;
        private ToolStripButton selectAllToolStripButton8;
        private TextBox textBox1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem uppercaseToolStripMenuItem;
        private ToolStripMenuItem lowercaseToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip2;
        private ToolStripLabel selectedTextToolStripLabel1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel phrasesToolStripLabel1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel wordsToolStripLabel1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripLabel charactersToolStripLabel1;
    }
}