using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBproject.Model;

using System.Text.RegularExpressions;
using XanderUI;
using DBproject.Controller;


namespace DBproject.Views
{
    public partial class SignUp : Form
    {
        string sarim = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Project_Database;Integrated Security=True";
        string raja = @"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=Project_Database;Integrated Security=True";
        string connectionString = @"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=Project_Database;Integrated Security=True";

        string usersTableName = "tbl_User";
        string buildingsTableName = "tbl_Buildings";
        Model.User user;
        Model.Building apartment;
        ControllerModule controller;
        public SignUp()
        {
            InitializeComponent();
            user = new User();
            apartment = new Building();
            
        }

       

        private void exitButton_Click(object sender, EventArgs e)
        {
            // closing program
            this.Dispose();
        }

        private void gotoSignUpButton_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            signUpPanel.Visible = true;
            
          //  AsanAdminPanel.Visible = false;
            //AsaMemberpanel.Visible = false;
        }

        private void gotoLoginButton_Click(object sender, EventArgs e)
        {
            
            loginPanel.Visible = true;
            signUpPanel.Visible = false;
           
         //   AsaMemberpanel.Visible = false;
           // AsanAdminPanel.Visible = false;
        }
        
       


        private void signUpButton_Click(object sender, EventArgs e)
        {
            // add validations here, emailFormat, Minimum Password Length, all text boxes checked 
            
                string format = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || emailTextBox.Text == "" || mobileTextBox.Text == "" || passwordTextBox.Text == "" || confirmPasswordTextBox.Text == "" || (memebrRadio.Checked != true && adminRadio.Checked != true))

            {
                if (firstNameTextBox.Text == "")
                {
                    errorProvider1.SetError(this.firstNameTextBox, "Please provide first name");
                    firstNameTextBox.Focus();

                }
                else
                    errorProvider1.Clear();
            }
            {
                if (lastNameTextBox.Text == "")
                {
                    errorProvider2.SetError(this.lastNameTextBox, "Please provide last name");

                }
                else
                    errorProvider2.Clear();

                if (firstNameTextBox.Text != "" && lastNameTextBox.Text == "")
                    lastNameTextBox.Focus();
            }
            {
                if (emailTextBox.Text == "")
                {
                    errorProvider3.SetError(this.emailTextBox, "Please provide email");
                }
                else
                    errorProvider3.Clear();

                if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text == "")
                    emailTextBox.Focus();
            }
            {
                if (mobileTextBox.Text == "" || mobileTextBox.Text.Length!=11)
                {
                    errorProvider4.SetError(this.mobileTextBox, "Please provide mobie number");
                   }
                else
                    errorProvider4.Clear();

                if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text != "" && mobileTextBox.Text == "")
                    mobileTextBox.Focus();
            }
            {
                if (passwordTextBox.Text == "")
                {
                    errorProvider6.SetError(this.passwordTextBox, "Please set password");

                }
                else
                    errorProvider6.Clear();

                if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text != "" && mobileTextBox.Text != "" && passwordTextBox.Text == "")
                    passwordTextBox.Focus();
            }
            {
                if (confirmPasswordTextBox.Text == "")
                {
                    errorProvider7.SetError(this.confirmPasswordTextBox, "Please confirm your password");
                }
                else
                    errorProvider7.Clear();

                if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text != "" && mobileTextBox.Text != "" && passwordTextBox.Text != "" && confirmPasswordTextBox.Text == "")
                    confirmPasswordTextBox.Focus();
            }
            {
                if (adminRadio.Checked != true && memebrRadio.Checked != true)
                {
                    errorProvider5.SetError(this.memebrRadio, "Please select one");
                }
                else
                    errorProvider5.Clear();

                if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text != "" && mobileTextBox.Text != "" && passwordTextBox.Text != "" && confirmPasswordTextBox.Text != "" && (adminRadio.Checked != true && memebrRadio.Checked != true))
                    memebrRadio.Focus();
            }
            
            if (Regex.IsMatch(emailTextBox.Text, format))
                {
                    errorProvider1.Clear();
                    emailTextBox.Focus();
                }
                else
                {
                    errorProvider1.SetError(this.emailTextBox, "Please provide valid email");
                    return;
                }

            if (mobileTextBox.Text.Length <= 10 || mobileTextBox.Text.Length >= 12)
            {
                //errorProvider1.Clear();
                errorProvider4.SetError(this.mobileTextBox, "Please provide valid mobile number");
               // mobileTextBox.Focus();
            }
            else
            {
                errorProvider4.Clear();
            }
                
           
               
          
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                confirmPasswordError.Visible = true;
                confirmPasswordTextBox.Text = "";
                confirmPasswordTextBox.Focus();
            }

            else
            {
                controller = new Controller.AuthorizationModule(this.connectionString
                , usersTableName);
                user = new User(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, passwordTextBox.Text, adminRadio.Checked, mobileTextBox.Text);
                controller.signUp(user, this);

            }
        }

           
        
        private void xuiButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            controller = new Controller.AuthorizationModule(this.connectionString
                , usersTableName);
           
            controller.signIn(this.user , this, loginEmailTextbox.Text, loginPasswordTextbox.Text, apartment);
        }

        

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

        private void MakeAMemberButton_Click(object sender, EventArgs e)
        {
            controller = new AuthorizationModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, "");
            controller.joinApartment(apartmentIDTextbox.Text, membersixdigitcodetextBox.Text, this);
        }

        public void joinApartmentSuccessful(List<string> flatNumbers)
        {
            MakeAMemberButton.Visible = false;
            joinApartmentButton.Visible = true;
            apartmentIDTextbox.Visible = false;
            membersixdigitcodetextBox.Visible = false;
            membersixdigitcodelabel.Visible = false;
            ApartmentIDLabel.Text = "Select Flat Number";
            chooseFlatNumber.Visible = true;
            chooseFlatNumber.Items.AddRange(flatNumbers.ToArray());
            chooseFlatNumber.SelectedIndex = 0;

        }

        // clicking create building

        private void SignupAsAdminButton_Click(object sender, EventArgs e)
        {
            controller = new CreateAndJoinBuilding(connectionString, buildingsTableName);
            this.apartment = new Building(buildingNameTextbox.Text, Convert.ToInt32(noOfFloorsInput.Value), Convert.ToInt32(flatsPerFloorInput.Value), codeTextBox.Text, user, Convert.ToInt32(flatNoFormatInput.Value), (int)balanceInput.Value);
            
            controller.createBuilding(apartment, this,user,Convert.ToInt32(adminFlatInput.Value));
        }


        // will be called by controller when successful

        public void buildingCreated()
        {
            this.Hide();
            MainScreen ms = new MainScreen(user,apartment);
            ms.ShowDialog();
            this.Dispose();
        }

        public void buildingFailed()
        {
            MessageBox.Show("Error! Apartment Creation Failed");

        }

        public void setWelcomeTitle(string title)
        {
            welcomeTitle.Text = title;
        }

        public void logInInFailed(bool passwordIncorrect)
        {
            loginFailedError.Visible = true;
            if (passwordIncorrect)
            {
                loginFailedError.Text = "Login Failed due to INCORRECT PASSWORD";
                loginPasswordTextbox.Text = "";
                loginPasswordTextbox.Focus();
             
            }

            else
            {
                loginFailedError.Text = "Login Failed! Account does not exists";
                loginPasswordTextbox.Text = "";
                loginEmailTextbox.Text = "";
                loginEmailTextbox.Focus();
            }
        }

        public void logInSuccessful()
        {
            this.Hide();
            MainScreen ms = new MainScreen(user,apartment);
            ms.ShowDialog();
            this.Dispose();

        }

        public void signUpFailed()
        {
            signUpFaileError.Visible = true;
            emailTextBox.Focus();
        }

        public void signUpSuccessful(bool isAdmin)
        {
            if (isAdmin)
            {

                AdminPanel.Visible = true;
                codeTextBox.Text = generateRandomCode(6);
                loginPanel.Visible = false;
                signUpPanel.Visible = false;
                AsaMemberpanel.Visible = false;


            }
            else
            {
                AdminPanel.Visible = false;
                loginPanel.Visible = false;
                signUpPanel.Visible = false;
                AsaMemberpanel.Visible = true;
            }
        }

        public void signUpSuccessful() // controller will call this
        {
            if (adminRadio.Checked)
            {
                
                AdminPanel.Visible = true;
                codeTextBox.Text = generateRandomCode(6);
                loginPanel.Visible = false;
                signUpPanel.Visible = false;
                AsaMemberpanel.Visible = false;


            }
            if (memebrRadio.Checked)
            {
                AdminPanel.Visible = false;
                loginPanel.Visible = false;
                signUpPanel.Visible = false;
                AsaMemberpanel.Visible = true;
            }
        }

        private string generateRandomCode(int length)
        {
            String str = "";
            Random r = new Random();

            for (int i = 0; i < length; i++)
            {
                str += (char)r.Next(65, 91);
            }

            return str;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshCodeButton_Click(object sender, EventArgs e)
        {
            codeTextBox.Text = generateRandomCode(6);
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            codeTextBox.Text = codeTextBox.Text.ToUpper();
            codeTextBox.SelectionStart = codeTextBox.Text.Length;
            codeTextBox.SelectionLength = 0;
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            
                if (passwordTextBox.Text.Length <= 5)
                {
                    passwordStrength.Visible = true;
                   passwordStrength.Text = "Your Pasword is Weak";
                 passwordStrength.ForeColor = Color.Red;
                    // passwordTextBox.Focus();
                }
                if (passwordTextBox.Text.Length >= 6 && passwordTextBox.Text.Length <= 8)
                {
                    passwordStrength.Visible = true;
                   passwordStrength.Text = "Your Pasword is Average";
                    passwordStrength.ForeColor = Color.Yellow;
                    // passwordTextBox.Focus();
                }
                if (passwordTextBox.Text.Length >= 9)
                {
                    passwordStrength.Visible = true;
                    passwordStrength.Text = "Your Pasword is Strong";
                   passwordStrength.ForeColor = Color.Green;
                    //passwordTextBox.Focus();
                
            }

        }

        private void confirmPasswordError_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void signUpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
