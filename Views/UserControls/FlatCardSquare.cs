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
            if (flat.getDues() <= 0)
                changeToPaid();

            else
                changeToUnpaid();

            this.view = view;
        }

        public void setText(string str)
        {
            
            button1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // controller = new Controller.MainScreenController(connectionString, Util.Tables.TABLE_FLATS.TBL_FLATS);
            // controller.showDetailsPanel(flat, view);
            view.showDetails(flat.getFlatNumber());
        }

        public void changeToPaid()
        {
            button1.BackColor = Color.DarkRed;
            button1.BackgroundImage = Properties.Resources.f2;
        }

        public void changeToUnpaid()
        {
            button1.BackColor = Color.DimGray;
            button1.BackgroundImage = Properties.Resources.dgra;
        }

        public void updatePaidStatus()
        {
            if (this.flat.getDues() > 0)
                changeToUnpaid();
            else
                changeToPaid();
        }
        public Flat getFlat()
        {
            return this.flat;
        }
    }
}
