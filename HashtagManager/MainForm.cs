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
        private List<string> HashTags { get; set; }

        public MainForm()
        {
            InitializeComponent();

            // Load default file path from config file
            CurrentFilePath = ConfigurationManager.AppSettings["saveDirectory"];

            if (!string.IsNullOrWhiteSpace(CurrentFilePath))
            {
                this.files = DataLoader.LoadFilesFromDirectory(CurrentFilePath);
            }

        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                CurrentFilePath = fileName;
                lblFilePath.Text = fileName;
                LoadTagsFromFile(fileName);
                lblMaximumTags.Text = "(Maximum " + HashTags.Count.ToString() + ")";
            }

            btnGenerateTags.Enabled = true;
        }

        private void BtnGenerateTags_Click(object sender, EventArgs e)
        {
            txtResultTags.Clear();

            int numTags = 0;

            try
            {
                numTags = Convert.ToInt32(txtNumTags.Text);
            }
            catch
            {
                MessageBox.Show("Enter a valid number");
                return;
            }

            if (numTags <= HashTags.Count && numTags > 0)
            {
                var numbers = SelectRandomTags(numTags);
                PopulateResults(numbers);
            }
            else
            {
                MessageBox.Show("Enter a number between 1 and " + HashTags.Count);
                return;
            }
        }

        private HashSet<int> SelectRandomTags(int numTags)
        {
            Random rand = new Random();

            HashSet<int> numbers = new HashSet<int>();
            while (numbers.Count < numTags)
            {
                numbers.Add(rand.Next(0, HashTags.Count));
            }

            return numbers;
        }

        private void LoadTagsFromFile(string fileName)
        {
            HashTags = new List<string>();
            StreamReader reader = new StreamReader(fileName);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                HashTags.Add(line);
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (txtResultTags.TextLength > 0)
            {
                Clipboard.Clear();
                Clipboard.SetText(txtResultTags.Text);
                lblClipboardConfirm.Text = "Copied to clipboard";
            }
        }

        private void PopulateResults(HashSet<int> numbers)
        {
            foreach (int i in numbers)
            {
                txtResultTags.AppendText(HashTags[i]);
                txtResultTags.AppendText(" ");
                txtResultTags.AppendText("\n");
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
                    selectedDirectoryLabel.Text = fbd.SelectedPath;

                    categorySelector.DataSource = files;
                }
            }
        }

        private void SaveDirDefaultButton_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["saveDirectory"].Value = selectedDirectoryLabel.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

        private void CategorySelector_SelectedValueChanged(object sender, EventArgs e)
        {
            PopulateEditTextbox();
        }

        private void PopulateEditTextbox()
        {
            FileInfo file = categorySelector.SelectedValue as FileInfo;
            string fullPath = file.FullName;

            LoadTagsFromFile(fullPath);

            foreach (string tag in HashTags)
            {
                editorTextBox.AppendText(tag);
                editorTextBox.AppendText(" ");
                editorTextBox.AppendText("\n");
            }
        }
    }
}
