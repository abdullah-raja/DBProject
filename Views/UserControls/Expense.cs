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
    public partial class Expense : UserControl
    {
        bool regularActive = true;
        int otherLoacation = 716;
        int regularLocation = 228;
        public Expense()
        {
            InitializeComponent();
           


        }

        public Expense(int i):this()  // will be used for regular expenses
        {
            expensesList.Visible = true;
            otherExpensesList.Visible = false;

            otherExpensesList.Location = expensesList.Location;

            for (int j = 0; j < i; j++)
            {
                ExpenseCard exp = new ExpenseCard();
                exp.setName("Electric Bill");
                exp.setAmount(2000);
                expensesList.Controls.Add(exp);
                


            }
        }

        private void Expense_Load(object sender, EventArgs e)
        {

        }

        private void othersExpenses_Click(object sender, EventArgs e)
        {
            regularActive = false;
            expensesList.Visible = false;
            otherExpensesList.Visible = true;


            
            triangle.Location = new Point(otherLoacation, triangle.Location.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void addOtherExpenseButton_Click(object sender, EventArgs e)
        {
            ExpenseCard expense = new ExpenseCard();
            otherExpensesList.Controls.Add(expense);
        }

        private void addExpenseButton_Click(object sender, EventArgs e)
        {
            if (regularActive)
            {
                ExpenseCard expense = new ExpenseCard();
                expensesList.Controls.Add(expense);
            }

            else
            {
                ExpenseCard expense = new ExpenseCard();
                otherExpensesList.Controls.Add(expense);
            }
        }

        private void regularExpensesButton_Click(object sender, EventArgs e)
        {
            regularActive = true;
            expensesList.Visible = true;
            otherExpensesList.Visible = false;
            triangle.Location = new Point(regularLocation, triangle.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           /* if(regularActive)
            {
                triangle.Location = new Point(triangle.Location.X + 10, triangle.Location.Y);
                if(triangle.Location.X > )
            }  */
        }
    }
}
