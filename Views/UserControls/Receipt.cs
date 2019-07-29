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
        MainScreen mainScreen;
        Building apartment;
        Income incomeView;
        public Receipt(User user, Flat flat, Building apartment, string month, int year, MainScreen mainScreen, Income incomeView) // used for collection
        {
            InitializeComponent();
            
            setValues(flat,month,year);
            controller = new TransactionModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, Util.Tables.TABLE_INCOMING_TRANSACTIONS.TABLE_NAME);
            
            transaction = new IncomingTransaction(receiptTrID.Text, apartment, flat, (int)receiptAmount.Value, reciptDateTime.Value, user.getFlat(), month, year);
            this.mainScreen = mainScreen;
            this.apartment = apartment;
            this.incomeView = incomeView;

        }

        public Receipt(Flat flat, string month) // used for showing
        {
            InitializeComponent();

            
            // receiptMonthBox.Items.AddRange(new object[] { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER" });
            controller = new TransactionModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, Util.Tables.TABLE_INCOMING_TRANSACTIONS.TABLE_NAME);
            
            controller.showPaidReceipt(this, month, flat.getFlatNumber());
            
        }



        private void setValues(Flat flat, string month, int year)
        {
            
            receiptTrID.Text = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
            receiptName.Text = flat.getNameOfResident();
            receiptFlatNumber.Text = flat.getFlatNumber().ToString();
            receiptAmount.Value = Convert.ToDecimal(flat.getMonthlyFees());
            receiptMonthBox.Text = month + ", " + year.ToString();
            

        }

       

        private void confirmButton1_Click_1(object sender, EventArgs e)
        {
            controller = new TransactionModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, Util.Tables.TABLE_INCOMING_TRANSACTIONS.TABLE_NAME);
            controller.confirmTransaction(this.transaction, this.apartment, this.incomeView);

            controller = new MainScreenController(Util.CONNECTION_DETAILS.CONNECITION_STRING, Util.Tables.TABLE_FLATS.TBL_FLATS);
            controller.showDetailsPanel(this.transaction.getPaidBy(), (Income)this.Parent);

            controller.updateBalance(this.apartment, this.mainScreen);

            this.Dispose();
           // receiptpanel1.Visible = false;
        }

        private void CancelButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setValues(DateTime date, string name, string trID, int flatNumber, int amount, string month, int year)
        {
            
            
            receiptAmount.Value = amount;
            receiptTrID.Text = trID;
            receiptName.Text = name;
            receiptFlatNumber.Text = flatNumber.ToString();
            receiptMonthBox.Text = month + ", " + year.ToString();
            

            reciptDateTime.Enabled = false;
            reciptDateTime.CalendarMonthBackground = Color.LightGray;
            reciptDateTime.Value = date;

            confirmButton1.Visible = false;
            CancelButton1.Left = (CancelButton1.Parent.Width - CancelButton1.Width) / 2;

        }

       
    }
}
