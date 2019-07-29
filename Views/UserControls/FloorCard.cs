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
using DBproject.Controller;

namespace DBproject.Views.UserControls
{
    public partial class FloorCard : UserControl
    {
        Income view;
        Building apartment;
        List<FlatCardSquare> flats;
        public FloorCard(Building apartment, Income view)
        {
            InitializeComponent();
            this.apartment = apartment;
            this.view = view;
            flats = new List<FlatCardSquare>();
        }
    
        public void setText(string str)
        {
            button1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel FloorsPanel = (FlowLayoutPanel)this.Parent;

                FloorsPanel.Controls.Clear();
                for (int j = 0; j < apartment.getFlatsPerFloor(); j++)
                {
               
                    FlatCardSquare flat = new FlatCardSquare(apartment.getFlatAt(this.TabIndex,j),view);
                    flat.Margin = new Padding(10, 10, 10, 10);
                    flat.setText((((this.TabIndex + 1) * 100) + j+1).ToString());
                    FloorsPanel.Controls.Add(flat);
                    flats.Add(flat);
                }

                FloorsPanel.Controls.Add(new BackButton(apartment,view));
            
        }

        public void changeToPaid()
        {
            button1.BackColor = Color.DarkRed;
        }

        public void newMonth()
        {
            button1.BackColor = Color.DimGray;
            foreach (FlatCardSquare flat in flats)
                flat.BackColor = Color.DimGray;
        }

        public void changeToUnpaid()
        {
            button1.BackColor = Color.DimGray;
        }

        public FlatCardSquare getFlatAt(int f)
        {
            return flats.ElementAt(f);
        }

        public void updatePaidStatus()
        {
            bool paid = true;
            foreach(FlatCardSquare flat in flats)
            {
                if (flat.getFlat().getDues() > 0)
                {
                    paid = false;
                    break;
                }
                    
            }

            if (paid)
                this.changeToPaid();
            else
                this.changeToUnpaid();
                    

        }
    }
}
