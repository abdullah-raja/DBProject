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
    public partial class Income : UserControl
    {
        bool settingActivated;
        Building apartment;
        ControllerModule controller;
        string connectionString = @"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=Project_Database;Integrated Security=True";
        string flatTableName = "tbl_Flats";
        public Income()
        {

            InitializeComponent();
            DateTime day = DateTime.Now;

            monthComboBox.SelectedIndex = day.Month-1;
            this.settingActivated = false;

        }

        public Income(Building apartment):this()
        {

            this.apartment = apartment;
            FloorsPanel.Controls.Clear();
            for (int i = 0; i < apartment.getNoOfFloors(); i++)
            {
                FloorCard floor = new FloorCard(apartment,this);
                floor.setText("Floor # " + (i + 1).ToString());
                floor.Anchor = AnchorStyles.Left;
                floor.Anchor = AnchorStyles.Top;
                
               // floor.Anchor = AnchorStyles.Top;
                FloorsPanel.Controls.Add(floor);
            }
            


        }

        public void showDetails(string name, int flatNumber, int fees, int dues, bool manager, string email, string mobile)
        {
            detailsName.Text = name;
            detailsFlatNumber.Text = flatNumber.ToString();
            detailsMaintanance.Text = fees.ToString();
            detailsDues.Text = dues.ToString();
            detailsEmail.Text = email;
            detailsMobile.Text = mobile;

        }

      

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nametextBox1_TextChanged(object sender, EventArgs e)
        {
               }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            detailsName.ReadOnly = settingActivated;
            detailsFlatNumber.ReadOnly = settingActivated;
            detailsMaintanance.ReadOnly = settingActivated;
            detailsDues.ReadOnly = settingActivated;
            managerButton.Visible = !settingActivated;
            switchlabel.Visible = !settingActivated;

            if (!settingActivated)
            {
               
                SettingButton.ButtonText = "OK";
            }

            else
            {
                SettingButton.ButtonText = "Settings";
                controller = new MainScreenController(connectionString, flatTableName);
                Flat flat = new Flat(Convert.ToInt32(detailsFlatNumber.Text), detailsName.Text, detailsEmail.Text, detailsMobile.Text, Convert.ToInt32(detailsDues.Text), Convert.ToInt32(detailsMaintanance.Text), false, this.apartment);
                controller.updateDetailsPanel(flat);
            }
            settingActivated = !settingActivated;
            
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
            managerButton.Text= "MANAGER";
            //switchButton.TextColor = Color.DarkRed;
            //switchButton.BackgroundColor = Color.White;
        }

        private void switchButton_MouseClick(object sender, MouseEventArgs e)
        {
            managerButton.ButtonText = "MANAGER";
        }
    }
}
