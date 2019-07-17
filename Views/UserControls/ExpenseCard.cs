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
        public ExpenseCard()
        {
            InitializeComponent();
            expenseNameTextBox.Focus();
        }

        public ExpenseCard(ExpenseType type, Building apartment, String month, int year) : this()
        {
            
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
            this.Dispose();
        }

        private void changeToPaid()
        {
            payButton.Text = "DETAILS";
            paidLabel.Visible = true;
            expenseNameTextBox.ReadOnly = true;
            expenseAmount.Enabled = false;

        }

        private void changeToUnpaid()
        {
            payButton.Text = "PAY";
            paidLabel.Visible = false;
            expenseNameTextBox.ReadOnly = false;
            expenseAmount.Enabled = true;
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
            this.addExpense();
        }

        private void expenseAmount_Leave(object sender, EventArgs e)
        {
            this.addExpense();
        }
    }
}
