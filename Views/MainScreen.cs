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


namespace DBproject.Views
{
    public partial class MainScreen : Form
    {
        User user;
        Building apartment;
        public MainScreen(User user, Building apartment)
        {

            InitializeComponent();
            this.user = user;
            this.apartment = apartment;
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

            Income inc = new Income(6,6);
            inc.Dock = DockStyle.Fill;
            main.Controls.Clear();
            main.Controls.Add(inc);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void expensesButton_Click(object sender, EventArgs e)
        {
            incomeButton.ForeColor = Color.White;
            expensesButton.ForeColor = Color.Silver;
            settingsButton.ForeColor = Color.White;
            analyticsButton.ForeColor = Color.White;

            Expense exp = new Expense(3);
            exp.Dock = DockStyle.Fill;
            main.Controls.Clear();
            main.Controls.Add(exp);
                
        }

        private void expense1_Load(object sender, EventArgs e)
        {

        }
    }
}
