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

        private void nametextBox1_TextChanged(object sender, EventArgs e)
        {
               }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            NAMEtextBox1.ReadOnly = false;
            flatnoTextBox1.ReadOnly = false;
            feesTextBox3.ReadOnly = false;
            duesTextBox2.ReadOnly = false;
            switchButton.Visible = true;
            switchlabel.Visible = true;
        }

        private void duesTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void feesTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dueslabel_Click(object sender, EventArgs e)
        {

        }

        private void CollectButton_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            this.Controls.Add(receipt);
            receipt.BringToFront();

        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            switchButton.Text= "MANAGER";
            //switchButton.TextColor = Color.DarkRed;
            //switchButton.BackgroundColor = Color.White;
        }

        private void switchButton_MouseClick(object sender, MouseEventArgs e)
        {
            switchButton.ButtonText = "MANAGER";
        }
    }
}
