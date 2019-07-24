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
    public partial class ExpenseCard : UserControl
    {
        ExpenseDetails expenseDetails;
        ControllerModule controller;
        MainScreen mainView;
        User user;
        public ExpenseCard()
        {
            InitializeComponent();
            expenseNameTextBox.Focus();
            
        }

        public ExpenseCard(User user, ExpenseType type, Building apartment, String month, int year, MainScreen mainView) : this()
        {
            this.mainView = mainView;
            this.expenseDetails = new ExpenseDetails(apartment, this.getName(), this.getAmount(), type, ExpenseStatus.Unpaid, month, year);
        }

        public ExpenseCard(ExpenseDetails expDetails):this()
        {
            this.expenseDetails = expDetails;
            this.setName(expDetails.getExpenseName());
            this.setAmount(expDetails.getAmount());
           

            if (this.expenseDetails.GetExpenseStatus() == ExpenseStatus.Paid)
                this.changeToPaid();

            else
                this.changeToUnpaid();
               
            
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

            this.deleteExpense();
        }

        public void changeToPaid()
        {
            payButton.Text = "DETAILS";
            paidLabel.Visible = true;
            expenseNameTextBox.ReadOnly = true;
            expenseAmount.Enabled = false;
            this.BackColor = Color.LightGray;
            this.expenseDetails.setExpenseStatus(ExpenseStatus.Paid);
            this.SendToBack();
            deleteButton.Visible = false;

        }

        public void changeToUnpaid()
        {
            payButton.Text = "PAY";
            paidLabel.Visible = false;
            expenseNameTextBox.ReadOnly = false;
            expenseAmount.Enabled = true;
            this.expenseDetails.setExpenseStatus(ExpenseStatus.Unpaid);
            this.BringToFront();
            deleteButton.Visible = true;
        }

        public string getName()
        {
            return expenseNameTextBox.Text;
        }

        public int getAmount()
        {
            return (int)expenseAmount.Value;
        }

        public ExpenseDetails GetExpenseDetails()
        {
            return this.expenseDetails;
        }

        private void addExpense()
        {
            bool validInput = true;

           

                if (expenseAmount.Value < 0)
                {
                    validInput = false;
                    // error here
                }

                if (expenseNameTextBox.Text == "")
                {
                    validInput = false;
                    // error here
                }

            if (expenseNameTextBox.Text != this.expenseNameTextBox.Text || expenseAmount.Value != this.expenseDetails.getAmount())
            { // update or insertS

                if (validInput)
                {
                    controller = new ExpenseModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
                    this.expenseDetails.setExpenseName(expenseNameTextBox.Text);
                    this.expenseDetails.setAmount((int)expenseAmount.Value);
                    controller.addExpense(this.expenseDetails);
                    //controller.addExpense()
    
                }

            }
        }

        private void expenseNameTextBox_Leave(object sender, EventArgs e)
        {
            if(user.getFlat().getIsManager() >= 2)
            this.addExpense();
        }

        private void expenseAmount_Leave(object sender, EventArgs e)
        {
            if (user.getFlat().getIsManager() >= 2)
                this.addExpense();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
                OutgoingTransaction tr = new OutgoingTransaction(Guid.NewGuid().ToString().Substring(0, 8).ToUpper(), this.expenseDetails, DateTime.Now, user.getFlat());
                ExpenseReceipt receipt = new ExpenseReceipt(user, tr, this, mainView);
                this.Parent.Parent.Controls.Add(receipt);
                receipt.BringToFront();
                receipt.Left = 50;
                receipt.Top = 50;
            

        }

        public void setView(MainScreen view)
        {
            this.mainView = view;
        }

        public MainScreen getMainView()
        {
            return this.mainView;
        }

        private void deleteExpense()
        {
            if (user.getFlat().getIsManager() >= 2)
            {
                controller = new ExpenseModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
                controller.deleteExpense(this.GetExpenseDetails());
                this.Dispose();
            }
        }
    }
}
