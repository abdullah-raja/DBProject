using DBproject.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBproject.Model;
using DBproject.Views;
using DBproject.Controller;


namespace DBproject.Views
{
    public partial class MainScreen : Form
    {
        ControllerModule controller;
        User user;
        Building apartment;
        BalanceDetails balanceDetails;
        int starting, income, expense, current = 0; 
        public MainScreen(User user, Building apartment)
        {

            InitializeComponent();
            this.user = user;
            this.apartment = apartment;
            updateMainScreen();
            controller = new MainScreenController(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
            controller.updateBalance(apartment, this);
            // calling controller function and creating user
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sign = new SignUp();
            sign.ShowDialog();
            this.Dispose();
        }

        private void IncomeTitle_Click(object sender, EventArgs e)
        {

        }

       

        private void incomeButton_Click(object sender, EventArgs e)
        {
            incomeButton.ForeColor = Color.Silver;
            expensesButton.ForeColor = Color.White;
            settingsButton.ForeColor = Color.White;
            analyticsButton.ForeColor = Color.White;

            Income inc = new Income(apartment, this);
            inc.Dock = DockStyle.Fill;
            main.Controls.Clear();
            main.Controls.Add(inc);
        }

        

        private void expensesButton_Click(object sender, EventArgs e)
        {
            incomeButton.ForeColor = Color.White;
            expensesButton.ForeColor = Color.Silver;
            settingsButton.ForeColor = Color.White;
            analyticsButton.ForeColor = Color.White;

            Expense exp = new Expense(3, this.apartment,this);
            exp.Dock = DockStyle.Fill;
            main.Controls.Clear();
            main.Controls.Add(exp);
                
        }

        private void currentBalance_MouseLeave(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            balanceDetails.Dispose();
        }

        private void analyticsButton_Click(object sender, EventArgs e)
        {
            Anaytics analytics = new Anaytics(this.apartment);
            analytics.Dock = DockStyle.Fill;
            main.Controls.Clear();
            main.Controls.Add(analytics);
        }

        public void updateBalance(int inc, int exp)
        {
            currentBalance.Text = "Rs " + apartment.getBalance().ToString();
            this.income = inc;
            this.expense = exp;
            this.starting = apartment.getBalance() + exp - inc;
        }

        public void updateMainScreen()
        {
            nameLabel.Text = user.getFirstName() + " "+ user.getLastname();
            flatNumberLabel.Text = user.getIsAdmin() ? "Admin" : "";
            currentBalance.Text = "Rs " + apartment.getBalance().ToString();

        }

        private void currentBalance_MouseEnter(object sender, EventArgs e)
        {
            
            
            balanceDetails = new BalanceDetails(starting, income, expense, apartment.getBalance());
            balanceDetails.Location = this.PointToClient(MousePosition);
            
            // balanceDetails.

            this.Controls.Add(balanceDetails);
            balanceDetails.BringToFront();
        }

        
    }
}
