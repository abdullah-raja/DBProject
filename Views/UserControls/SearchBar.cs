using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject.Views.UserControls
{
    public partial class SearchBar : UserControl
    {
        Expense view;
        public SearchBar()
        {
            InitializeComponent();
        }

        public SearchBar(Expense view)
        {
            InitializeComponent();
            this.view = view;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            view.searchWithName(textBox.Text);
        }
    }
}
