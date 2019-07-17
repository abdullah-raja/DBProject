using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBproject.Controller;
using DBproject.Util;
using DBproject.Model;

namespace DBproject.Views.UserControls
{
    public partial class Expense : UserControl
    {
        Building apartment;
        List<ExpenseCard> expenses;
        ControllerModule controller;
        bool regularActive = true;
        int otherLoacation = 716;
        int regularLocation = 228;
        public Expense()
        {
            InitializeComponent();
            controller = new TransactionModule(CONNECTION_DETAILS.CONNECITION_STRING, "");
            controller.setYears(this);
            expenses = new List<ExpenseCard>();

        }

        public Expense(int i, Building apartment):this()  // will be used for regular expenses
        {
            expensesList.Visible = true;
            otherExpensesList.Visible = false;

            otherExpensesList.Location = expensesList.Location;
            this.apartment = apartment;

           /* for (int j = 0; j < i; j++)
            {
                ExpenseCard exp = new ExpenseCard();
                exp.setName("Electric Bill");
                exp.setAmount(2000);
                expensesList.Controls.Add(exp);
                


            }
            */
        }

       

        private void othersExpenses_Click(object sender, EventArgs e)
        {
            regularActive = false;
            expensesList.Visible = false;
            otherExpensesList.Visible = true;


            
            triangle.Location = new Point(otherLoacation, triangle.Location.Y);
        }

       
        private void addOtherExpenseButton_Click(object sender, EventArgs e)
        {
            ExpenseCard expense = new ExpenseCard();
            otherExpensesList.Controls.Add(expense);
        }

        private void addExpenseButton_Click(object sender, EventArgs e)
        {
            this.addExpense();
            controller = new ExpenseModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
            controller.addExpense(this, regularActive, expenses.Last().GetExpenseDetails());
        }

        private void regularExpensesButton_Click(object sender, EventArgs e)
        {
            regularActive = true;
            expensesList.Visible = true;
            otherExpensesList.Visible = false;
            triangle.Location = new Point(regularLocation, triangle.Location.Y);
        }

        public void setMonths(List<String> months)
        {
            monthComboBox.Items.AddRange(months.ToArray());

            string currentMonth = miscFunctions.ToMonthName(DateTime.Now).ToUpper();
            if (!monthComboBox.Items.Contains(currentMonth))
                monthComboBox.Items.Add(currentMonth);

            monthComboBox.SelectedItem = currentMonth;
        }

        public void setYears(List<String> years)
        {
            yearComboBox.Items.AddRange(years.ToArray());

            string currentYear = DateTime.Now.Year.ToString();
            if (!yearComboBox.Items.Contains(currentYear))
            {
                yearComboBox.Items.Add(currentYear);
                controller = new MainScreenController(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
                // controller.newMonthStarted(this);
            } // increment dues


            yearComboBox.SelectedItem = currentYear;
            controller.setMonths(this, Convert.ToInt32(yearComboBox.SelectedItem));
        }

        public void addExpense() // will be called by view
        {
            ExpenseCard expense;
            if (regularActive)
                expense = new ExpenseCard(ExpenseType.Regular, this.apartment, monthComboBox.SelectedItem.ToString(), Convert.ToInt32(yearComboBox.SelectedItem));

            else
                expense = new ExpenseCard(ExpenseType.Other, this.apartment, monthComboBox.SelectedItem.ToString(), Convert.ToInt32(yearComboBox.SelectedItem));

            expenses.Add(expense);
            expensesList.Controls.Add(expense);
            expense.Focus();
           // ExpenseDetails expDetails = new ExpenseDetails(expense,apartment,monthComboBox.SelectedItem.ToString(), Convert.ToInt32(yearComboBox.SelectedItem));

        }
    }
}
