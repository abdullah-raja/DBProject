using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject.Views
{
    public partial class ReportDialogBox : Form
    {
        public ReportDialogBox()
        {
            InitializeComponent();
        }

        private void incomeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            flatNumberCheckBox.Visible = incomeCheckbox.Checked;
            amountCheckbox.Visible = incomeCheckbox.Checked;
            dateCheckbox.Visible = incomeCheckbox.Checked;
            monthCheckbox.Visible = incomeCheckbox.Checked;
            receivableCheckbox.Visible = incomeCheckbox.Checked;

        }

        private void expenseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            expenseDateCheckbox.Visible = expenseCheckbox.Checked;
            expenseAmount.Visible = expenseCheckbox.Checked;
            expenseDetails.Visible = expenseCheckbox.Checked;
        }

        
    }
}
