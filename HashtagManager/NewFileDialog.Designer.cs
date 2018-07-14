namespace HashtagManager
{
    partial class NewFileDialog
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
            this.NewFileNameTxt = new System.Windows.Forms.TextBox();
            this.NewFileNameLbl = new System.Windows.Forms.Label();
            this.SubmitNewFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewFileNameTxt
            // 
            this.NewFileNameTxt.Location = new System.Drawing.Point(100, 66);
            this.NewFileNameTxt.Name = "NewFileNameTxt";
            this.NewFileNameTxt.Size = new System.Drawing.Size(100, 20);
            this.NewFileNameTxt.TabIndex = 0;
            this.NewFileNameTxt.Text = "\r\n";
            // 
            // NewFileNameLbl
            // 
            this.NewFileNameLbl.AutoSize = true;
            this.NewFileNameLbl.Location = new System.Drawing.Point(12, 69);
            this.NewFileNameLbl.Name = "NewFileNameLbl";
            this.NewFileNameLbl.Size = new System.Drawing.Size(82, 13);
            this.NewFileNameLbl.TabIndex = 1;
            this.NewFileNameLbl.Text = "New File Name:";
            // 
            // SubmitNewFileBtn
            // 
            this.SubmitNewFileBtn.Location = new System.Drawing.Point(100, 110);
            this.SubmitNewFileBtn.Name = "SubmitNewFileBtn";
            this.SubmitNewFileBtn.Size = new System.Drawing.Size(100, 23);
            this.SubmitNewFileBtn.TabIndex = 2;
            this.SubmitNewFileBtn.Text = "Submit";
            this.SubmitNewFileBtn.UseVisualStyleBackColor = true;
            this.SubmitNewFileBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 167);
            this.Controls.Add(this.SubmitNewFileBtn);
            this.Controls.Add(this.NewFileNameLbl);
            this.Controls.Add(this.NewFileNameTxt);
            this.Name = "NewFileDialog";
            this.Text = "New File";
            this.Load += new System.EventHandler(this.NewFileDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewFileNameTxt;
        private System.Windows.Forms.Label NewFileNameLbl;
        private System.Windows.Forms.Button SubmitNewFileBtn;
    }
}