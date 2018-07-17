namespace HashtagManager
{
    partial class MainForm
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGenerateTags = new System.Windows.Forms.Button();
            this.txtNumTags = new System.Windows.Forms.TextBox();
            this.lblNumTags = new System.Windows.Forms.Label();
            this.lblClipboardConfirm = new System.Windows.Forms.Label();
            this.lblMaximumTags = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CatSelectorGen = new HashtagManager.CategorySelector();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CatSelectorManage = new HashtagManager.CategorySelector();
            this.SaveDirDefaultButton = new System.Windows.Forms.Button();
            this.selectedDirectoryLabel = new System.Windows.Forms.Label();
            this.selectDirectoryButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.editorTextBox = new System.Windows.Forms.TextBox();
            this.removeCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(9, 87);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(407, 292);
            this.resultTextBox.TabIndex = 2;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(307, 399);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(109, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy To Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // btnGenerateTags
            // 
            this.btnGenerateTags.Enabled = false;
            this.btnGenerateTags.Location = new System.Drawing.Point(314, 10);
            this.btnGenerateTags.Name = "btnGenerateTags";
            this.btnGenerateTags.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateTags.TabIndex = 4;
            this.btnGenerateTags.Text = "Randomize";
            this.btnGenerateTags.UseVisualStyleBackColor = true;
            this.btnGenerateTags.Click += new System.EventHandler(this.BtnGenerateTags_Click);
            // 
            // txtNumTags
            // 
            this.txtNumTags.Location = new System.Drawing.Point(161, 53);
            this.txtNumTags.Name = "txtNumTags";
            this.txtNumTags.Size = new System.Drawing.Size(29, 20);
            this.txtNumTags.TabIndex = 5;
            // 
            // lblNumTags
            // 
            this.lblNumTags.AutoSize = true;
            this.lblNumTags.Location = new System.Drawing.Point(16, 55);
            this.lblNumTags.Name = "lblNumTags";
            this.lblNumTags.Size = new System.Drawing.Size(139, 13);
            this.lblNumTags.TabIndex = 6;
            this.lblNumTags.Text = "Number of tags to generate:";
            // 
            // lblClipboardConfirm
            // 
            this.lblClipboardConfirm.AutoSize = true;
            this.lblClipboardConfirm.Location = new System.Drawing.Point(274, 349);
            this.lblClipboardConfirm.Name = "lblClipboardConfirm";
            this.lblClipboardConfirm.Size = new System.Drawing.Size(0, 13);
            this.lblClipboardConfirm.TabIndex = 8;
            // 
            // lblMaximumTags
            // 
            this.lblMaximumTags.AutoSize = true;
            this.lblMaximumTags.Location = new System.Drawing.Point(205, 56);
            this.lblMaximumTags.Name = "lblMaximumTags";
            this.lblMaximumTags.Size = new System.Drawing.Size(0, 13);
            this.lblMaximumTags.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(411, 428);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(430, 462);
            this.tabControl2.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CatSelectorGen);
            this.tabPage3.Controls.Add(this.resultTextBox);
            this.tabPage3.Controls.Add(this.tabControl1);
            this.tabPage3.Controls.Add(this.lblMaximumTags);
            this.tabPage3.Controls.Add(this.lblClipboardConfirm);
            this.tabPage3.Controls.Add(this.btnCopy);
            this.tabPage3.Controls.Add(this.lblNumTags);
            this.tabPage3.Controls.Add(this.btnGenerateTags);
            this.tabPage3.Controls.Add(this.txtNumTags);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(422, 436);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Generate Random";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CatSelectorGen
            // 
            this.CatSelectorGen.Location = new System.Drawing.Point(9, 10);
            this.CatSelectorGen.Name = "CatSelectorGen";
            this.CatSelectorGen.Size = new System.Drawing.Size(233, 37);
            this.CatSelectorGen.TabIndex = 11;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.CatSelectorManage);
            this.tabPage4.Controls.Add(this.SaveDirDefaultButton);
            this.tabPage4.Controls.Add(this.selectedDirectoryLabel);
            this.tabPage4.Controls.Add(this.selectDirectoryButton);
            this.tabPage4.Controls.Add(this.saveChangesButton);
            this.tabPage4.Controls.Add(this.editorTextBox);
            this.tabPage4.Controls.Add(this.removeCategoryButton);
            this.tabPage4.Controls.Add(this.addCategoryButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(422, 436);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Manage";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // CatSelectorManage
            // 
            this.CatSelectorManage.Location = new System.Drawing.Point(9, 39);
            this.CatSelectorManage.Name = "CatSelectorManage";
            this.CatSelectorManage.Size = new System.Drawing.Size(234, 37);
            this.CatSelectorManage.TabIndex = 9;
            // 
            // SaveDirDefaultButton
            // 
            this.SaveDirDefaultButton.Location = new System.Drawing.Point(314, 10);
            this.SaveDirDefaultButton.Name = "SaveDirDefaultButton";
            this.SaveDirDefaultButton.Size = new System.Drawing.Size(98, 23);
            this.SaveDirDefaultButton.TabIndex = 8;
            this.SaveDirDefaultButton.Text = "Save as Default";
            this.SaveDirDefaultButton.UseVisualStyleBackColor = true;
            this.SaveDirDefaultButton.Click += new System.EventHandler(this.SaveDirDefaultButton_Click);
            // 
            // selectedDirectoryLabel
            // 
            this.selectedDirectoryLabel.AutoSize = true;
            this.selectedDirectoryLabel.Location = new System.Drawing.Point(106, 15);
            this.selectedDirectoryLabel.Name = "selectedDirectoryLabel";
            this.selectedDirectoryLabel.Size = new System.Drawing.Size(10, 13);
            this.selectedDirectoryLabel.TabIndex = 7;
            this.selectedDirectoryLabel.Text = "-";
            // 
            // selectDirectoryButton
            // 
            this.selectDirectoryButton.Location = new System.Drawing.Point(9, 10);
            this.selectDirectoryButton.Name = "selectDirectoryButton";
            this.selectDirectoryButton.Size = new System.Drawing.Size(91, 23);
            this.selectDirectoryButton.TabIndex = 6;
            this.selectDirectoryButton.Text = "Select Directory";
            this.selectDirectoryButton.UseVisualStyleBackColor = true;
            this.selectDirectoryButton.Click += new System.EventHandler(this.SelectDirectoryButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(306, 396);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(110, 23);
            this.saveChangesButton.TabIndex = 5;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // editorTextBox
            // 
            this.editorTextBox.Location = new System.Drawing.Point(9, 87);
            this.editorTextBox.Multiline = true;
            this.editorTextBox.Name = "editorTextBox";
            this.editorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.editorTextBox.Size = new System.Drawing.Size(407, 292);
            this.editorTextBox.TabIndex = 4;
            // 
            // removeCategoryButton
            // 
            this.removeCategoryButton.Location = new System.Drawing.Point(280, 45);
            this.removeCategoryButton.Name = "removeCategoryButton";
            this.removeCategoryButton.Size = new System.Drawing.Size(25, 25);
            this.removeCategoryButton.TabIndex = 3;
            this.removeCategoryButton.Text = "-";
            this.removeCategoryButton.UseVisualStyleBackColor = true;
            this.removeCategoryButton.Click += new System.EventHandler(this.RemoveCategoryButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(249, 45);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(25, 25);
            this.addCategoryButton.TabIndex = 2;
            this.addCategoryButton.Text = "+";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 486);
            this.Controls.Add(this.tabControl2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnGenerateTags;
        private System.Windows.Forms.TextBox txtNumTags;
        private System.Windows.Forms.Label lblNumTags;
        private System.Windows.Forms.Label lblClipboardConfirm;
        private System.Windows.Forms.Label lblMaximumTags;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox editorTextBox;
        private System.Windows.Forms.Button removeCategoryButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Label selectedDirectoryLabel;
        private System.Windows.Forms.Button selectDirectoryButton;
        private System.Windows.Forms.Button SaveDirDefaultButton;
        private CategorySelector CatSelectorGen;
        private CategorySelector CatSelectorManage;
    }
}

