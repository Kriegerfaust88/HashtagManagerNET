using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;

namespace HashtagManager
{
    public partial class MainForm : Form
    {
        private FileInfo[] files;

        private string CurrentFilePath { get; set; }

        public MainForm()
        {
            InitializeComponent();

            CatSelectorManage.CategoryChanged += HandleManagerCategoryChanged;
            CatSelectorGen.CategoryChanged += HandleGenCategoryChanged;

            // Load default file path from config file
            CurrentFilePath = ConfigurationManager.AppSettings["saveDirectory"];

            if (!string.IsNullOrWhiteSpace(CurrentFilePath))
            {
                this.files = DataLoader.LoadFilesFromDirectory(CurrentFilePath);

                if (this.files.Length > 0)
                {
                    selectedDirectoryLabel.Text = CurrentFilePath;

                    CatSelectorGen.PopulateCategories(this.files);
                    CatSelectorManage.PopulateCategories(this.files);

                    btnGenerateTags.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No .txt files found in this directory.");
                }
            }
        }

        private void BtnGenerateTags_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();

            int numTags = 0;

            try
            {
                numTags = Convert.ToInt32(txtNumTags.Text);
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Enter a valid number");
                return;
            }

            List<string> HashTags = DataLoader.LoadTagsFromFile(CatSelectorGen.SelectedValue.FullName);

            if (numTags <= HashTags.Count && numTags > 0)
            {
                HashSet<int> numbers = SelectRandomIndexes(numTags, HashTags.Count);

                foreach (int i in numbers)
                {
                    resultTextBox.AppendText(HashTags[i]);
                    resultTextBox.AppendText(" ");
                    resultTextBox.AppendText("\n");
                }
            }
            else
            {
                MessageBox.Show("Enter a number between 1 and " + HashTags.Count);
                return;
            }
        }

        private HashSet<int> SelectRandomIndexes(int numTags, int availableTags)
        {
            Random rand = new Random();

            HashSet<int> numbers = new HashSet<int>();

            while (numbers.Count < numTags)
            {
                numbers.Add(rand.Next(0, availableTags));
            }

            return numbers;
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (resultTextBox.TextLength > 0)
            {
                Clipboard.Clear();
                Clipboard.SetText(resultTextBox.Text);
                lblClipboardConfirm.Text = "Copied to clipboard";
            }
        }

        private void SelectDirectoryButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.files = DataLoader.LoadFilesFromDirectory(fbd.SelectedPath);

                    if (this.files.Length > 0)
                    {
                        selectedDirectoryLabel.Text = fbd.SelectedPath;

                        CatSelectorGen.PopulateCategories(this.files);
                        CatSelectorManage.PopulateCategories(this.files);

                        CatSelectorGen.ResetCombo();
                        CatSelectorManage.ResetCombo();

                        this.CurrentFilePath = fbd.SelectedPath;
                    }
                    else
                    {
                        MessageBox.Show("No .txt files found in this directory.");
                    }
                }
            }
        }

        private void SaveDirDefaultButton_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["saveDirectory"].Value = selectedDirectoryLabel.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

        private void PopulateEditTextbox(string filePath)
        {
            editorTextBox.Clear();

            List<string> HashTags = DataLoader.LoadTagsFromFile(filePath);

            foreach (string tag in HashTags)
            {
                editorTextBox.AppendText(tag);
                editorTextBox.AppendText(" ");
                editorTextBox.AppendText("\n");
            }
        }

        private void HandleManagerCategoryChanged(object sender, CategoryChangedEventArgs args)
        {
            PopulateEditTextbox(args.NewCategory.FullName);
        }

        private void HandleGenCategoryChanged(object sender, CategoryChangedEventArgs args)
        {
            List<string> HashTags = DataLoader.LoadTagsFromFile(CatSelectorGen.SelectedValue.FullName);
            lblMaximumTags.Text = "(Maximum " + HashTags.Count.ToString() + ")";
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.CurrentFilePath))
            {
                CreateNewFile();
            }
        }

        private void CreateNewFile()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "Text files (*.txt)|*.txt";
            saveDialog.FilterIndex = 1;
            saveDialog.RestoreDirectory = true;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using(FileStream fs = File.Create(saveDialog.FileName))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("Write your new hashtags here, separated by a line break");
                    fs.Write(info, 0, info.Length);
                }
                //TODO Use CurrentFilePath instead
                RefreshComboBoxes(saveDialog.InitialDirectory);
            }
        }

        private void RefreshComboBoxes(string directory)
        {
            this.files = DataLoader.LoadFilesFromDirectory(directory);

            if (this.files.Length > 0)
            {                 selectedDirectoryLabel.Text = directory;

                CatSelectorGen.PopulateCategories(this.files);
                CatSelectorManage.PopulateCategories(this.files);

                CatSelectorGen.ResetCombo();
                CatSelectorManage.ResetCombo();       
            }
        }
    }
}
