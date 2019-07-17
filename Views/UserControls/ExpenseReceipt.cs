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
using DBproject.Controller;

namespace DBproject.Views.UserControls
{
    public partial class ExpenseReceipt : UserControl
    {
        OutgoingTransaction expenseTransaction;
        ExpenseCard expense;
        ControllerModule controller;
        MainScreen mainView;
        public ExpenseReceipt(MainScreen mainView)
        {
            InitializeComponent();
            this.mainView = mainView;
        }

        public ExpenseReceipt(OutgoingTransaction tr, ExpenseCard ex, MainScreen mainView) : this(mainView)
        {
            this.expenseTransaction = tr;
            this.expense = ex;

            if (tr.getExpense().GetExpenseStatus() == ExpenseStatus.Unpaid)
                this.setConfrimFields();

            else
                this.setDetailsField();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setConfrimFields() // used to show confirmation menu
        {
            expenseReceiptTitle.Text = "CONFRIM PAYMENT";
            expenseReceiptTrID.Text = this.expenseTransaction.getTrID();
            expenseReceiptName.Text = this.expenseTransaction.getExpense().getExpenseName();
            expenseReceiptAmountTextBox.Text = this.expenseTransaction.getExpense().getAmount().ToString();
            expenseReceiptMonthBox.Text = this.expenseTransaction.getExpense().getMonth();
            expenseReceiptYear.Text = this.expenseTransaction.getExpense().getYear().ToString();
           // expenseReceiptFlatNumber.Text = this.expenseTransaction.getPaidBy().ToString();
            

        }

        public void setDetailsField() // used to show details
        {
            expenseReceiptTitle.Text = "DETAILS";
            expenseReceiptTrID.Text = this.expenseTransaction.getTrID();
            expenseReceiptName.Text = this.expenseTransaction.getExpense().getExpenseName();
            expenseReceiptAmountTextBox.Text = this.expenseTransaction.getExpense().getAmount().ToString();
            expenseReceiptMonthBox.Text = this.expenseTransaction.getExpense().getMonth();
            expenseReceiptYear.Text = this.expenseTransaction.getExpense().getYear().ToString();
            receiptDate.Value = this.expenseTransaction.getDate();
            receiptDate.Enabled = false;
            confirmButton.Visible = false;
            cancelButton.Left = (cancelButton.Parent.Width - cancelButton.Width) / 2;
        }

        private void receiptDate_ValueChanged(object sender, EventArgs e)
        {
            this.expenseTransaction.setDate(receiptDate.Value);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            controller = new ExpenseModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
            controller.confirmPayment(this.expenseTransaction, this.expense);

            controller = new MainScreenController(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
            controller.updateBalance(this.expense.GetExpenseDetails().getApartment(), this.mainView);
            this.Dispose();
        }
    }
}
