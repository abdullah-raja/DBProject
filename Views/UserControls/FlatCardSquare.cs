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
using DBproject.Views.UserControls;

namespace DBproject.Views.UserControls
{
    public partial class FlatCardSquare : UserControl
    {
        Controller.ControllerModule controller;
        string connectionString = @"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=Project_Database;Integrated Security=True";
        DBproject.Model.Flat flat;
        DBproject.Views.UserControls.Income view;

        public FlatCardSquare(Flat flat, Income view)
        {
            InitializeComponent();
            this.flat = flat;
            this.view = view;
        }

        public void setText(string str)
        {
            
            button1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller = new Controller.MainScreenController(connectionString, "tbl_Flats");
            controller.showDetailsPanel(flat, view);
        }
    }
}
