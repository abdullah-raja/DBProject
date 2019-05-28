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

namespace DBproject.Views
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
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
            Income inc = new Income(6,6);
            inc.Dock = DockStyle.Fill;
            main.Controls.Add(inc);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
