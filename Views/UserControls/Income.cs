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
        User user;
        Building apartment;
        ControllerModule controller;
       // string connectionString = @"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=Project_Database;Integrated Security=True";
        string flatTableName = "tbl_Flats";
        MainScreen mainScreen;
        List<FloorCard> floors;
        int prevFee = 0, prevDues = 0;
        public Income()
        {

            InitializeComponent();
            
            this.settingActivated = false;
            floors = new List<FloorCard>();
        }

        public Income(User user, Building apartment, MainScreen mainScreen):this()
        {
            this.user = user;
            this.mainScreen = mainScreen;
            this.apartment = apartment;
            this.setYears(mainScreen.getYears());
            this.setMonths(mainScreen.getMonths());
            FloorsPanel.Controls.Clear();
            for (int i = 0; i < apartment.getNoOfFloors(); i++)
            {
                FloorCard floor = new FloorCard(apartment,this);
                floor.setText("Floor # " + (i + 1).ToString());
                floor.Anchor = AnchorStyles.Left;
                floor.Anchor = AnchorStyles.Top;

                // floor.Anchor = AnchorStyles.Top;
                floors.Add(floor);
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

        public void showDetails(int flatNumber)
        {
            Flat flat = apartment.getFlatAt(flatNumber);

            detailsPanel.Visible = true;
            detailsName.Text = flat.getNameOfResident();
            detailsFlatNumber.Text = miscFunctions.toNullString(flatNumber);
            detailsMaintanance.Text = flat.getMonthlyFees().ToString();
            detailsDues.Text = flat.getDues().ToString();
            detailsEmail.Text = miscFunctions.toNullString(flat.getEmail());
            detailsMobile.Text = miscFunctions.toNullString(flat.getContactNumber());
            if (flat.getDues() <= 0 && flat.getMonthlyFees() > 0)
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
            
            
            if (user.getFlat().getIsManager() == 3) // only admin can click settings button
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
                    prevFee = Convert.ToInt32(detailsMaintanance.Text);
                    prevDues = Convert.ToInt32(detailsDues.Text);    

                }

                else  // update flat
                {
                    SettingButton.ButtonText = "Settings";
                    detailsName.BackColor = defaultColor;
                    detailsMaintanance.BackColor = defaultColor;
                    detailsEmail.BackColor = defaultColor;
                    detailsMobile.BackColor = defaultColor;
                    controller = new MainScreenController(Util.CONNECTION_DETAILS.CONNECITION_STRING, flatTableName);
                    
                    int newFee, newDues;
                    if(prevFee != Convert.ToInt32(detailsMaintanance.Text))
                    {
                        newFee = Convert.ToInt32(detailsMaintanance.Text);
                        newDues = newFee + prevDues;

                    }

                    else
                    {
                        newFee = prevFee;
                        newDues = prevDues;
                    }
                    Flat flat = new Flat(Convert.ToInt32(detailsFlatNumber.Text), detailsName.Text, detailsEmail.Text, detailsMobile.Text, newDues, newFee, 1, this.apartment);
                    detailsDues.Text = flat.getDues().ToString();
                    controller.updateDetailsPanel(flat);
                    apartment.updateFlatAt(flat);
                    floors.ElementAt((flat.getFlatNumber() / 100) - 1).getFlatAt((flat.getFlatNumber() % 100) - 1).updatePaidStatus();

                }
                settingActivated = !settingActivated;
            }
        }

        

        private void CollectButton_Click(object sender, EventArgs e)
        {
            
                Receipt receipt;
                Flat flat = new Flat(Convert.ToInt32(detailsFlatNumber.Text), detailsName.Text, detailsEmail.Text, detailsMobile.Text, Convert.ToInt32(detailsDues.Text), Convert.ToInt32(detailsMaintanance.Text), 1, this.apartment);
                if (flat.getDues() > 0 && user.getFlat().getIsManager() >= 2)
                    receipt = new Receipt(user,flat, this.apartment, monthComboBox.SelectedItem.ToString(), Convert.ToInt32(yearComboBox.SelectedItem), mainScreen, this);

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
            
            monthComboBox.SelectedItem = currentMonth;
        }

        public void setYears(List<String> years)
        {
            yearComboBox.Items.AddRange(years.ToArray());

            string currentYear = DateTime.Now.Year.ToString();
                

            yearComboBox.SelectedItem = currentYear;
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // controller.setMonths(this, Convert.ToInt32(yearComboBox.SelectedItem));
        }

        public void updateFlat(int flatNumber)
        {
            floors.ElementAt((flatNumber / 100 - 1)).getFlatAt((flatNumber % 100) - 1).changeToPaid();

        }

        public List<FloorCard> getFloorCard()
        {
            foreach(FloorCard floor in floors)
            {
                floor.updatePaidStatus();
            }
            return this.floors;
        }
    }
}
