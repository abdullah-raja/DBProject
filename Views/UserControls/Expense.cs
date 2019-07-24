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
        User user;
        Building apartment;
        List<ExpenseCard> expenses;
        ControllerModule controller;
        MainScreen mainView;
        bool regularActive = true;
        int otherLoacation = 716;
        int regularLocation = 228;
        public Expense()
        {
            InitializeComponent();
            statusFilter.SelectedIndex = 0;
            controller = new TransactionModule(CONNECTION_DETAILS.CONNECITION_STRING, "");
            controller.setYears(this);
            expenses = new List<ExpenseCard>();

            
            

        }

        public Expense(User user, Building apartment, MainScreen mainView):this()  // will be used for regular expenses
        {
            this.user = user;
            this.mainView = mainView;
            expensesList.Visible = true;
            otherExpensesList.Visible = false;

            otherExpensesList.Location = expensesList.Location;
            this.apartment = apartment;

            controller = new ExpenseModule(CONNECTION_DETAILS.CONNECITION_STRING, "");
            controller.getAllExpense(this.expenses, this.apartment, monthComboBox.SelectedItem.ToString(), Convert.ToInt32(yearComboBox.SelectedItem));
            foreach (ExpenseCard exp in expenses)
            {
                exp.setView(this.mainView);
                if (exp.GetExpenseDetails().GetExpenseType() == ExpenseType.Regular)
                {
                    expensesList.Controls.Add(exp);
                    if (exp.GetExpenseDetails().GetExpenseStatus() == ExpenseStatus.Paid)
                        exp.SendToBack();
                    else
                        exp.BringToFront();
                }

                else
                {
                    otherExpensesList.Controls.Add(exp);
                    if (exp.GetExpenseDetails().GetExpenseStatus() == ExpenseStatus.Paid)
                        exp.SendToBack();
                    else
                        exp.BringToFront();
                }
                    
            }
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
            if (user.getFlat().getIsManager() >= 3)
            {
                ExpenseCard expense = new ExpenseCard();
                otherExpensesList.Controls.Add(expense);
            }
        }

        private void addExpenseButton_Click(object sender, EventArgs e)
        {
            if(user.getFlat().getIsManager() >= 3)
            {
                this.addExpense();
                controller = new ExpenseModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
                controller.addExpense(this, regularActive, expenses.Last().GetExpenseDetails());
            }
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
            {
                expense = new ExpenseCard(this.user, ExpenseType.Regular, this.apartment, monthComboBox.SelectedItem.ToString(), Convert.ToInt32(yearComboBox.SelectedItem),this.mainView);
                expensesList.Controls.Add(expense);
                
            }


            else
            {   
                expense = new ExpenseCard(this.user, ExpenseType.Other, this.apartment, monthComboBox.SelectedItem.ToString(), Convert.ToInt32(yearComboBox.SelectedItem), this.mainView);
                otherExpensesList.Controls.Add(expense);
            }

            expense.BringToFront();
            expenses.Add(expense);
            
            expense.Focus();
           // ExpenseDetails expDetails = new ExpenseDetails(expense,apartment,monthComboBox.SelectedItem.ToString(), Convert.ToInt32(yearComboBox.SelectedItem));

        }

        private void statusFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (statusFilter.SelectedIndex == 1)
                showPaidExpenses();

            else if (statusFilter.SelectedIndex == 2)
                showUnpaidExpenses();

            else
                showAll();

        }

        private void showPaidExpenses()
        {
            foreach(ExpenseCard exp in expenses)
            {
                if (exp.GetExpenseDetails().GetExpenseStatus() == ExpenseStatus.Unpaid)
                    exp.Hide();

                else
                    exp.Show();

            }
        }

        private void showUnpaidExpenses()
        {
            foreach (ExpenseCard exp in expenses)
            {
                if (exp.GetExpenseDetails().GetExpenseStatus() == ExpenseStatus.Paid)
                    exp.Hide();

                else
                    exp.Show();
            }
        }

        private void showAll()
        {
            try
            {
                foreach (ExpenseCard exp in expenses)
                {
                    exp.Show();
                }
            }

            catch
            {

            }
        }

        public void searchWithName(string str)
        {
            foreach(ExpenseCard exp in expenses)
            {
                if (exp.GetExpenseDetails().getExpenseName().Contains(str))
                    exp.Show();

                else
                    exp.Hide();
            }
        }
    }
}
