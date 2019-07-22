using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using DBproject.Controller;
using DBproject.Model;

namespace DBproject.Views
{
    public partial class ReportDialogBox : Form
    {
        ControllerModule controller;
        Building apartment;
        public ReportDialogBox()
        {
            InitializeComponent();
        }

        public ReportDialogBox(Building apartment): this()
        {
            this.apartment = apartment;
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

        public void exportPdf(DataTable income, DataTable expense)
        {
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            controller = new ReportModule(Util.CONNECTION_DETAILS.CONNECITION_STRING);
            controller.generateReprt(this, this.apartment, 7,2019);
        }
    }
}
