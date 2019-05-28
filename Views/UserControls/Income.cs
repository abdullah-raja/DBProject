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
    public partial class Income : UserControl
    {
        public Income()
        {
            InitializeComponent();

        }

        public Income(int floors, int flats)
        {
            InitializeComponent();

            FloorsPanel.Controls.Clear();
            for (int i = 0; i < floors; i++)
            {
                FloorCard floor = new FloorCard(flats);
                floor.setText("Floor # " + (i + 1).ToString());
                floor.Anchor = AnchorStyles.Left;
                floor.Anchor = AnchorStyles.Top;
                
               // floor.Anchor = AnchorStyles.Top;
                FloorsPanel.Controls.Add(floor);
            }


        }

      

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
