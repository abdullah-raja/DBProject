using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject.Views.UserControls
{
    public partial class BalanceDetails : UserControl
    {
        int starting, income, expenses, current;
        public BalanceDetails()
        {
            InitializeComponent();
        }

        public BalanceDetails(int startingValue, int income, int expense, int current) : this()
        {
            this.starting = startingValue;
            this.income = income;
            this.expenses = expense;
            this.current = current;
            update();
        }

        public void update()
        {
            startingValue.Text = string.Format("{0:n}", starting);
            incomeValue.Text = string.Format("{0:n}", income);
            expenseValue.Text = string.Format("{0:n}", expenses);
            closingValue.Text = string.Format("{0:n}", current);
            month.Text = miscFunctions.ToMonthName(DateTime.Now) + ", " + DateTime.Now.Year;


        }

        private void showMore_Click(object sender, EventArgs e)
        {

        }
    }
}
