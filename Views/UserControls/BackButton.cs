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
    public partial class BackButton : UserControl
    {
        Model.Building apartment;
        Income view;
        public BackButton(Model.Building apartment, Income view)
        {
            InitializeComponent();
            this.apartment = apartment;
            this.view = view;
        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel FloorsPanel = (FlowLayoutPanel)this.Parent;
            
            FloorsPanel.Controls.Clear();
            for (int i = 0; i < apartment.getNoOfFloors(); i++)
            {
                FloorCard floor = new FloorCard(apartment, this.view);
                floor.setText("Floor # " + (i + 1).ToString());
                floor.Anchor = AnchorStyles.Left;
                floor.Anchor = AnchorStyles.Top;

                // floor.Anchor = AnchorStyles.Top;
                FloorsPanel.Controls.Add(floor);
            }
        }
    }
}
