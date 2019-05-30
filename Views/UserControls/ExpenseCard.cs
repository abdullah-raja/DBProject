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
    public partial class ExpenseCard : UserControl
    {
        public ExpenseCard()
        {
            InitializeComponent();
        }

        public void setName(string name)
        {
            expenseNameTextBox.Text = name;
        }

        public void setAmount(int amount)
        {
            expenseAmount.Value = amount;
         }

        private void deeteButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
