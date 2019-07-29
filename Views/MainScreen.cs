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
        List<String> months;
        List<String> years;
        public MainScreen(User user, Building apartment)
        {

            InitializeComponent();
            this.main.AutoScroll = false;
            this.main.AutoScroll = true;
            this.user = user;
            this.apartment = apartment;
            months = new List<string>();
            years = new List<String>();
            updateMainScreen();
            controller = new MainScreenController(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
            controller.updateBalance(apartment, this);
            // calling controller function and creating user

            controller = new TransactionModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
            controller.setYears(this, this.apartment);
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

            Income inc = new Income(this.user ,apartment, this);
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

            Expense exp = new Expense(this.user, this.apartment,this);
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
            showAnalytics();
        }

        public void showAnalytics()
        {
            Anaytics analytics = new Anaytics(this.apartment);
            analytics.Dock = DockStyle.Fill;
            main.Controls.Clear();
            main.Controls.Add(analytics);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            
          //  barGraph.drawG();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.tbl_Flats' table. You can move, or remove it, as needed.
            this.tbl_FlatsTableAdapter.Fill(this.project_DatabaseDataSet.tbl_Flats);
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.tbl_Flats' table. You can move, or remove it, as needed.
            this.tbl_FlatsTableAdapter.Fill(this.project_DatabaseDataSet.tbl_Flats);

        }

        private void generateMonthlyReport_Click(object sender, EventArgs e)
        {
            ReportDialogBox reportDialog = new ReportDialogBox(this.apartment);
            this.Enabled = false;
            reportDialog.Show();
            if (reportDialog.DialogResult == DialogResult.Cancel)
                this.Enabled = true;
            reportDialog.FormClosed += (s, es) =>
            {
                this.Enabled = true;
            };

            // this.Enabled = false;
        }

        private void currentBalance_MouseHover(object sender, EventArgs e)
        {
            balanceDetails = new BalanceDetails(this, starting, income, expense, apartment.getBalance());
            balanceDetails.Location = this.PointToClient(MousePosition);

            // balanceDetails.

            this.Controls.Add(balanceDetails);
            balanceDetails.BringToFront();
        }

        private void main_Paint(object sender, PaintEventArgs e)
        {

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
            flatNumberLabel.Text = user.getFlat().getFlatNumber().ToString();
            currentBalance.Text = "Rs " + apartment.getBalance().ToString();

        }

        private void currentBalance_MouseEnter(object sender, EventArgs e)
        {
            
            
           
        }

        public void setYears(List<string> years)
        {
            this.years.AddRange(years);
            string currentYear = DateTime.Now.Year.ToString();
            if (!this.years.Contains(currentYear))
            {
                this.years.Add(currentYear);
                controller = new MainScreenController(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
                controller.newMonthStarted(this.apartment);
            } // increment dues

            controller.setMonths(this, 2019, this.apartment);
        }

        public void setMonths(List<string> months)
        {
            this.months.AddRange(months.ToArray());

            string currentMonth = miscFunctions.ToMonthName(DateTime.Now).ToUpper();
            if (!this.months.Contains(currentMonth))
            {
                this.months.Add(currentMonth);
                controller = new MainScreenController(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
                controller.newMonthStarted(this.apartment);
            }
        }

        public List<string> getMonths()
        {
            return this.months;
        }

        public List<string> getYears()
        {
            return this.years;
        }
    }
}
