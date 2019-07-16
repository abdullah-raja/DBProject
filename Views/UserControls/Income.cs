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
        MainScreen mainScreen;
        public Income()
        {

            InitializeComponent();
            controller = new TransactionModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, Util.Tables.TABLE_INCOMING_TRANSACTIONS.TABLE_NAME); // jo months ki transactions avail hn wohi combobox me daalna
            controller.setYears(this);
            this.settingActivated = false;

        }

        public Income(Building apartment, MainScreen mainScreen):this()
        {
            this.mainScreen = mainScreen;
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
            detailsPanel.Visible = true;
            detailsName.Text = name;
            detailsFlatNumber.Text = flatNumber.ToString();
            detailsMaintanance.Text = fees.ToString();
            detailsDues.Text = dues.ToString();
            detailsEmail.Text = email;
            detailsMobile.Text = mobile;
            if (dues <= 0)
                CollectButton.ButtonText = "COLLECTED";
            else
                CollectButton.ButtonText = "COLLECT";

        }

      

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nametextBox1_TextChanged(object sender, EventArgs e)
        {
               }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            Color defaultColor = Color.Gainsboro;
            detailsName.ReadOnly = settingActivated;
            detailsMaintanance.ReadOnly = settingActivated;
            detailsEmail.ReadOnly = settingActivated;
            detailsMobile.ReadOnly = settingActivated;
            managerButton.Visible = !settingActivated;
            switchlabel.Visible = !settingActivated;

            if (!settingActivated)
            {
                
                SettingButton.ButtonText = "OK";
                detailsName.BackColor = Color.White;
                detailsMaintanance.BackColor = Color.White;
                detailsEmail.BackColor = Color.White;
                detailsMobile.BackColor = Color.White;

               
            }

            else
            {
                SettingButton.ButtonText = "Settings";
                detailsName.BackColor = defaultColor;
                detailsMaintanance.BackColor = defaultColor;
                detailsEmail.BackColor = defaultColor;
                detailsMobile.BackColor = defaultColor;
                controller = new MainScreenController(connectionString, flatTableName);
                Flat flat = new Flat(Convert.ToInt32(detailsFlatNumber.Text), detailsName.Text, detailsEmail.Text, detailsMobile.Text, Convert.ToInt32(detailsMaintanance.Text), Convert.ToInt32(detailsMaintanance.Text), 1, this.apartment);
                detailsDues.Text = flat.getDues().ToString();
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
            Receipt receipt;
            Flat flat = new Flat(Convert.ToInt32(detailsFlatNumber.Text), detailsName.Text, detailsEmail.Text, detailsMobile.Text, Convert.ToInt32(detailsDues.Text), Convert.ToInt32(detailsMaintanance.Text), 1, this.apartment);
            if (flat.getDues() > 0)
                receipt = new Receipt(flat, this.apartment, monthComboBox.SelectedItem.ToString(),Convert.ToInt32(yearComboBox.SelectedItem), mainScreen);

            else
                receipt = new Receipt(flat, monthComboBox.SelectedItem.ToString());
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

        public void setMonths(List<String> months)
        {
            monthComboBox.Items.AddRange(months.ToArray());

            string currentMonth = miscFunctions.ToMonthName(DateTime.Now).ToUpper();
            if (!monthComboBox.Items.Contains(currentMonth))
                monthComboBox.Items.Add(currentMonth);

            monthComboBox.SelectedItem = currentMonth;
        }

        public void setYears(List<String> years)
        {
            yearComboBox.Items.AddRange(years.ToArray());

            string currentYear = DateTime.Now.Year.ToString();
            if (!yearComboBox.Items.Contains(currentYear))
            {
                yearComboBox.Items.Add(currentYear);
                controller = new MainScreenController(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
                controller.newMonthStarted(this);
            } // increment dues
                

            yearComboBox.SelectedItem = currentYear;
            controller.setMonths(this, Convert.ToInt32(yearComboBox.SelectedItem));
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.setMonths(this, Convert.ToInt32(yearComboBox.SelectedItem));
        }
    }
}
