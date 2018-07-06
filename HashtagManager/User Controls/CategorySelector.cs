using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HashtagManager
{
    public partial class CategorySelector : UserControl
    {
        public CategorySelector()
        {
            InitializeComponent();
        }

        public FileInfo SelectedValue
        {
            get
            {
                return this.CategoryCombo.SelectedValue as FileInfo;
            }
        }

        public event EventHandler<CategoryChangedEventArgs> CategoryChanged = delegate { };

        public void PopulateCategories(FileInfo[] files)
        {
            this.CategoryCombo.DataSource = files;
        }

        public void RaiseCategoryChanged(FileInfo newCategory)
        {
            CategoryChanged(this, new CategoryChangedEventArgs { NewCategory = newCategory });
        }

        private void CategoryCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            RaiseCategoryChanged(CategoryCombo.SelectedValue as FileInfo);
        }
    }

    public class CategoryChangedEventArgs : EventArgs
    {
        public FileInfo NewCategory { get; set; }
    }
}
