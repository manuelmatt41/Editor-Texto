using Editor_Texto;
using System.Diagnostics;

namespace Editor_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeEvents();
            LoadConfig();
            textBox1.Size = GetFormFreeSpace();
            this.Text = "SinTitulo.txt";
            saved = true;
        }

        private void InitializeEvents()
        {
            //
            // Resize Event
            //
            this.Resize += new EventHandler((sender, e) => textBox1.Size = GetFormFreeSpace());
            //
            // Edit Menu Events
            //
            undoMenu.Click += new EventHandler((sender, e) => textBox1.Undo());
            copyMenu.Click += new EventHandler((sender, e) => textBox1.Copy());
            cutMenu.Click += new EventHandler((sender, e) => textBox1.Cut());
            pasteMenu.Click += new EventHandler((sender, e) => textBox1.Paste());
            selectAllMenu.Click += new EventHandler((sender, e) => textBox1.SelectAll());
            selectAllMenu.Click += new EventHandler(UpdateSelectionInfo);
            //
            // Tools Menu Events
            //
            wordWrapMenu.Click += new EventHandler((sender, e) => textBox1.WordWrap = ((ToolStripMenuItem)sender).Checked);
            wordWrapMenu.Click += new EventHandler((sender, e) => textBox1.ScrollBars = ((ToolStripMenuItem)sender).Checked ? ScrollBars.Vertical : ScrollBars.Both);
            uppercaseToolStripMenuItem.Click += new EventHandler((sender, e) => ChangeCheckWriteMode((ToolStripMenuItem)sender));
            lowercaseToolStripMenuItem.Click += new EventHandler((sender, e) => ChangeCheckWriteMode((ToolStripMenuItem)sender));
            normalToolStripMenuItem.Click += new EventHandler((sender, e) => ChangeCheckWriteMode((ToolStripMenuItem)sender));
            uppercaseToolStripMenuItem.CheckedChanged += new EventHandler(ChangeWriteMode);
            lowercaseToolStripMenuItem.CheckedChanged += new EventHandler(ChangeWriteMode);
            normalToolStripMenuItem.CheckedChanged += new EventHandler(ChangeWriteMode);
            textColorMenu.Click += new EventHandler(ChangeColor);
            backgroundColorMenu.Click += new EventHandler(ChangeColor);
            fontMenu.Click += new EventHandler((sender, e) => ChangeFont(sender, e));
            //
            // ToolStripIcons Events
            //
            newDocumentToolStripButton1.Click += new EventHandler((sender, e) => newDocumentMenu.PerformClick());
            saveToolStripButton2.Click += new EventHandler((sender, e) => saveFileMenu.PerformClick());
            openToolStripButton3.Click += new EventHandler((sender, e) => openFileMenu.PerformClick());
            undoToolStripButton4.Click += new EventHandler((sender, e) => textBox1.Undo());
            copyToolStripButton5.Click += new EventHandler((sender, e) => textBox1.Copy());
            cutToolStripButton6.Click += new EventHandler((sender, e) => textBox1.Cut());
            pasteToolStripButton7.Click += new EventHandler((sender, e) => textBox1.Paste());
            selectAllToolStripButton8.Click += new EventHandler((sender, e) => textBox1.SelectAll());
            selectAllToolStripButton8.Click += new EventHandler(UpdateSelectionInfo);

            //
            // TextBox "Document" Event
            //
            textBox1.TextChanged += new EventHandler(TextModified);
            textBox1.TextChanged += new EventHandler((sender, e) => UpdateInfo(phrasesToolStripLabel1, wordsToolStripLabel1, charactersToolStripLabel1, textBox1.Text));
            textBox1.MouseMove += new MouseEventHandler(UpdateSelectionInfo);
            textBox1.KeyDown += new KeyEventHandler(UpdateSelectionInfo);
            textBox1.KeyUp += new KeyEventHandler(UpdateSelectionInfo);
            //
            // Context Menu
            //
            undoToolStripMenuItem.Click += new EventHandler((sender, e) => textBox1.Undo());
            copyToolStripMenuItem.Click += new EventHandler((sender, e) => textBox1.Copy());
            cutToolStripMenuItem.Click += new EventHandler((sender, e) => textBox1.Cut());
            pasteToolStripMenuItem.Click += new EventHandler((sender, e) => textBox1.Paste());
            selectAllToolStripMenuItem.Click += new EventHandler((sender, e) => textBox1.SelectAll());
        }

        private void CreateConfigDirectory()
        {
            try
            {
                Directory.CreateDirectory(saveDirectory.FullName);
            }
            catch (Exception e) when (e is IOException || e is FileNotFoundException || e is DirectoryNotFoundException)
            {
            }
        }

        private void LoadConfig()
        {
            try
            {
                using (BinaryReaderConfiguration b = new BinaryReaderConfiguration(new FileStream(saveDirectory.FullName + "\\config", FileMode.Open)))
                {
                    configuration = b.Read();
                }
            }
            catch (Exception e) when (e is IOException || e is FileNotFoundException || e is DirectoryNotFoundException)
            {
                CreateConfigDirectory();
                configuration = new Configuration();
            }
            InitializeDocumentConfig();
        }

        private void InitializeDocumentConfig()
        {
            //
            // WordWrap
            //
            wordWrapMenu.Checked = configuration.wordWrap;
            textBox1.WordWrap = configuration.wordWrap;
            //
            // CharacterCasing
            //
            uppercaseToolStripMenuItem.Tag = CharacterCasing.Upper;
            lowercaseToolStripMenuItem.Tag = CharacterCasing.Lower;
            normalToolStripMenuItem.Tag = CharacterCasing.Normal;
            ChangeCheckWriteMode(configuration.characterCasing);
            //
            // ForeColor
            //
            Image foreColor;
            textColorMenu.Tag = configuration.foreColor;
            textColorMenu.Image = GetColorImage(out foreColor, saveDirectory.FullName + "\\foreColor.png") ? foreColor : Properties.Resources.foreColor;
            textBox1.ForeColor = configuration.foreColor;
            //
            // BackColor
            //
            backgroundColorMenu.Tag = configuration.backColor;
            Image backColor;
            backgroundColorMenu.Image = GetColorImage(out backColor, saveDirectory.FullName + "\\backColor.png") ? backColor : Properties.Resources.backColor;
            textBox1.BackColor = configuration.backColor;
            //
            // Font
            //
            textBox1.Font = new Font(configuration.familyName, (float)configuration.fontEmSize, configuration.fontStyle);
            fontMenu.ToolTipText = $"Family: {textBox1.Font.FontFamily.Name} | Size: {textBox1.Font.Size} | Style: {textBox1.Font.Style}";
            //
            // Recent files
            //
            for (int i = 0; i < configuration.recentFiles.Count; i++)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(configuration.recentFiles[i]);
                menuItem.Click += new EventHandler((sender, e) => OpenDocument(menuItem.Text));
                recentFilesMenu.DropDownItems.Add(menuItem);
            }
        }
        private void SaveConfiguration()
        {
            if (!saved)
            {
                saveFileMenu.PerformClick();
            }
            configuration.wordWrap = wordWrapMenu.Checked;
            configuration.characterCasing = (CharacterCasing)GetWriteMode().Tag;
            configuration.foreColor = textBox1.ForeColor;
            configuration.backColor = textBox1.BackColor;
            configuration.familyName = textBox1.Font.FontFamily.Name;
            configuration.fontEmSize = textBox1.Font.Size;
            configuration.fontStyle = textBox1.Font.Style;
            configuration.recentFiles = new List<string>();
            for (int i = 0; i < recentFilesMenu.DropDownItems.Count; i++)
            {
                configuration.recentFiles.Add(recentFilesMenu.DropDownItems[i].Text);
            }

            try
            {
                using (BinaryWriterConfiguration b = new BinaryWriterConfiguration(new FileStream(saveDirectory.FullName + "\\config", FileMode.OpenOrCreate)))
                {
                    b.Write(configuration);
                }
            }
            catch (Exception e) when (e is IOException || e is FileNotFoundException || e is DirectoryNotFoundException)
            {
                //TODO Poner un indicativo al error
            }
        }

        private ToolStripMenuItem GetWriteMode()
        {
            foreach (ToolStripMenuItem item in writeModeMenu.DropDownItems)
            {
                if (item.Checked)
                {
                    return item;
                }
            }
            return null;
        }

        private void ChangeCheckWriteMode(ToolStripMenuItem itemChecked)
        {
            foreach (ToolStripMenuItem menuItem in writeModeMenu.DropDownItems)
            {
                menuItem.Checked = false;
            }
            itemChecked.Checked = true;
        }

        private void ChangeCheckWriteMode(CharacterCasing characterCasing)
        {
            switch (characterCasing)
            {
                case CharacterCasing.Normal:
                    normalToolStripMenuItem.Checked = true;
                    break;
                case CharacterCasing.Upper:
                    uppercaseToolStripMenuItem.Checked = true;
                    break;
                case CharacterCasing.Lower:
                    lowercaseToolStripMenuItem.Checked = true;
                    break;
            }
        }

        private void ChangeWriteMode(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Checked)
            {
                textBox1.CharacterCasing = (CharacterCasing)((ToolStripMenuItem)sender).Tag;
            }
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            ((ToolStripMenuItem)sender).Tag = c.Color;
            ((ToolStripMenuItem)sender).BackColor = c.Color;
            if ((ToolStripMenuItem)sender == textColorMenu)
            {
                textBox1.ForeColor = c.Color;
                new Thread(() => ((ToolStripMenuItem)sender).Image = SetColorImage(((ToolStripMenuItem)sender).Image, c.Color)).Start();
            }
            if ((ToolStripMenuItem)sender == backgroundColorMenu)
            {
                textBox1.BackColor = c.Color;
                new Thread(() => ((ToolStripMenuItem)sender).Image = SetColorImage(((ToolStripMenuItem)sender).Image, c.Color)).Start();
            }
        }

        private bool GetColorImage(out Image image, string pathImage)
        {
            try
            {
                using (FileStream f = new FileStream(pathImage, FileMode.Open))
                {
                    image = Image.FromStream(f);
                }
            }
            catch (Exception e) when (e is IOException || e is FileNotFoundException || e is DirectoryNotFoundException)
            {
                image = null;
                return false;
            }

            return true;
        }

        private Image SetColorImage(Image image, Color saveColor)
        {
            Bitmap bitMap = new Bitmap(image);
            for (int i = 0; i < bitMap.Width; i++)
            {
                for (int j = 0; j < bitMap.Height; j++)
                {
                    bitMap.SetPixel(i, j, saveColor);
                }
            }
            return Image.FromHbitmap(bitMap.GetHbitmap());
        }

        private void SaveColorsImages()
        {
            textColorMenu.Image.Save(saveDirectory.FullName + "\\foreColor.png");
            backgroundColorMenu.Image.Save(saveDirectory.FullName + "\\backColor.png");
        }

        public void ChangeFont(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
                fontMenu.ToolTipText = $"Family: {textBox1.Font.FontFamily.Name} | Size: {textBox1.Font.Size} | Style: {textBox1.Font.Style}";
            }
        }

        public Size GetFormFreeSpace()
        {
            return new Size(this.Width - 15, this.Height - menuStrip1.Height - toolStrip1.Height - toolStrip2.Height - 40);
        }

        private void NewDocument(object sender, EventArgs e)
        {
            saveFileMenu.PerformClick();
            textBox1.Text = "";
            this.Text = "SinTitulo.txt";
        }

        private void SaveDocument(object sender, EventArgs e)
        {
            if (!saved)
            {
                saveFileDialog1.FileName = this.Text;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                        saved = true;
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("The file was not found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        saved = false;
                    }
                    catch (DirectoryNotFoundException)
                    {
                        MessageBox.Show("The directory was not found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        saved = false;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("The file could not be opened", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        saved = false;
                    }
                    if (this.Text.StartsWith("SinTitulo.txt"))
                    {
                        this.Text = new FileInfo(saveFileDialog1.FileName).Name;
                    }
                    this.Text.Remove(this.Text.Length - 1);
                }
            }
        }

        private void OpenDocument(object sender, EventArgs e)
        {

            saveFileMenu.PerformClick();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenDocument(openFileDialog1.FileName);
                SaveRecentFiles();
            }
        }

        private void OpenDocument(string path)
        {
            try
            {
                textBox1.Text = File.ReadAllText(path);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The file was not found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("The directory was not found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (IOException)
            {
                MessageBox.Show("The file could not be opened", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            saved = true;
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfiguration();
            SaveColorsImages();
        }

        private void UpdateInfo(ToolStripLabel phrasesLabel, ToolStripLabel wordsLabel, ToolStripLabel characterLabel, string text)
        {
            phrasesLabel.Text = $"Phrases: {text.Split('.', StringSplitOptions.RemoveEmptyEntries).Length}";
            wordsLabel.Text = $"Words: {text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length}";
            characterLabel.Text = $"Characters: {text.Length}";
        }

        private void UpdateSelectionInfo(object sender, EventArgs e)
        {
            selectedTextToolStripLabel1.Text = textBox1.SelectedText.Length > 0 ? $"Selected text from {textBox1.SelectionStart} to {textBox1.SelectionStart + textBox1.SelectionLength}" : "";
        }

        private void SaveRecentFiles()
        {
            for (int i = 0; i < recentFilesMenu.DropDownItems.Count; i++)
            {
                if (recentFilesMenu.DropDownItems[i].Text == openFileDialog1.FileName)
                {
                    return;
                }
            }
            ToolStripMenuItem menuItem = new ToolStripMenuItem(openFileDialog1.FileName);
            menuItem.Click += new EventHandler((sender, e) => OpenDocument(menuItem.Text));
            recentFilesMenu.DropDownItems.Insert(0, menuItem);
            if (recentFilesMenu.DropDownItems.Count > 5)
            {
                recentFilesMenu.DropDownItems.RemoveAt(recentFilesMenu.DropDownItems.Count - 1);
            }
        }

        private void TextModified(object sender, EventArgs e)
        {
            if (saved)
            {
                saved = false;
                this.Text = this.Text + "*";
            }
        }
        Configuration configuration;
        public bool saved;
        public DirectoryInfo saveDirectory = new DirectoryInfo($"{Environment.GetEnvironmentVariable("appdata")}\\ejer9");
    }
}
