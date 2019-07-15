using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBproject.Model;
using DBproject.Views;
using DBproject.Controller;

namespace DBproject.Views.UserControls
{
    public partial class Receipt : UserControl
    {
        IncomingTransaction transaction;
        ControllerModule controller;
        public Receipt(Flat flat, Building apatment)
        {
            InitializeComponent();

            setValues(flat);
            transaction = new IncomingTransaction(receiptTrID.Text, apatment, flat, (int)receiptAmount.Value, reciptDateTime.Value, flat, receiptMonthBox.SelectedItem.ToString());


        }

        private void setValues(Flat flat)
        {
            receiptMonthBox.Items.AddRange(new object[] { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER" });
            receiptTrID.Text = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
            receiptName.Text = flat.getNameOfResident();
            receiptFlatNumber.Text = flat.getFlatNumber().ToString();
            receiptAmount.Value = Convert.ToDecimal(flat.getMonthlyFees());
            receiptMonthBox.SelectedIndex = DateTime.Now.Month;

        }

        

        private void confirmButton1_Click(object sender, EventArgs e)
        {
            receiptpanel1.Visible = false;
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            receiptpanel1.Visible = false;
        }

        
        private void CancelButton1_Click(object sender, EventArgs e)
        {
            receiptpanel1.Visible = false;

        }

        private void confirmButton1_Click_1(object sender, EventArgs e)
        {
            controller = new TransactionModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, Util.Tables.TABLE_INCOMING_TRANSACTIONS.TABLE_NAME);
            controller.confirmTransaction(this.transaction);

            controller = new MainScreenController(Util.CONNECTION_DETAILS.CONNECITION_STRING, Util.Tables.TABLE_FLATS.TBL_FLATS);
            controller.showDetailsPanel(this.transaction.getPaidBy(), (Income)this.Parent);
            this.Dispose();
           // receiptpanel1.Visible = false;
        }

        private void CancelButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}
