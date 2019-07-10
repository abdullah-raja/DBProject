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

using DBproject.Controller;


namespace DBproject.Views
{
    public partial class SignUp : Form
    {
        string connectionString = @"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=Project_Database;Integrated Security=True";
        string usersTableName = "tbl_User";
        string buildingsTableName = "tbl_Buildings";
        Model.User user;
        ControllerModule controller;
        public SignUp()
        {
            InitializeComponent();
            
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
            //   errorProvider1.Clear();
            //  errorProvider1.SetError(this., "");
            //  return;
            {
                {
                    if (firstNameTextBox.Text == "")
                    {
                        // errorProvider1.Clear();

                        firstNameTextBox.Focus();

                        errorProvider1.SetError(this.firstNameTextBox, "Please provide first name");
                        return;
                    }
                    else
                        errorProvider1.Clear();
                }
                {
                    if (lastNameTextBox.Text == "")
                    {
                        errorProvider1.SetError(this.lastNameTextBox, "Please provide last name");
                        //  errorProvider1.Clear();  
                        // lastNameTextBox.Focus();
                        return;


                    }
                    else
                        errorProvider1.Clear();
                }
                 if (firstNameTextBox.Text != "" && lastNameTextBox.Text == "")
                  lastNameTextBox.Focus();
                {
                    if (emailTextBox.Text == "")
                    {
                        //  errorProvider1.Clear();
                        errorProvider1.SetError(this.emailTextBox, "Please provide email");
                        //  emailTextBox.Focus();
                        return;
                    }
                    else
                        errorProvider1.Clear();
                }
                if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text == "")
                    emailTextBox.Focus();
                {
                    if (mobileTextBox.Text == "")
                    {
                        //  errorProvider1.Clear();
                        errorProvider1.SetError(this.mobileTextBox, "Please provide mobie number");
                        // mobileTextBox.Focus(); 
                        return;
                    }
                    else
                        errorProvider1.Clear();
                }
                if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text!="" && mobileTextBox.Text == "")
                    mobileTextBox.Focus();
                {
                    if (passwordTextBox.Text == "")
                    {
                        //  errorProvider1.Clear();
                        errorProvider1.SetError(this.firstNameTextBox, "Please set password");
                        //  passwordTextBox.Focus();
                        return;
                    }
                    else
                        errorProvider1.Clear();
                }
                if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text != "" && mobileTextBox.Text != "" && passwordTextBox.Text == "")
                   passwordTextBox.Focus();
                {
                    if (confirmPasswordTextBox.Text == "")
                    {
                        //  errorProvider1.Clear();
                        errorProvider1.SetError(this.confirmPasswordTextBox, "Please confirm your password");
                        // confirmPasswordTextBox.Focus();
                        return;
                    }
                    else
                        errorProvider1.Clear();
                }
                if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text != "" && mobileTextBox.Text != "" && passwordTextBox.Text != "" && confirmPasswordTextBox.Text == "")
                    confirmPasswordTextBox.Focus();
                {
                    if (adminRadio.Checked != true && memebrRadio.Checked != true)
                    {
                        // errorProvider1.Clear();
                        errorProvider1.SetError(this.memebrRadio, "Please select one");
                        //adminRadio.Focus();
                        return;
                    }
                    else
                        errorProvider1.Clear();
                }
                if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text != "" && mobileTextBox.Text != "" && passwordTextBox.Text != "" && confirmPasswordTextBox.Text != "" && (adminRadio.Checked != true && memebrRadio.Checked != true) )
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
            
           if (mobileTextBox.Text.Length != 11)
            {
                mobileTextBox.Focus();
                errorProvider1.SetError(this.mobileTextBox, "Please provide valid mobile number");
                return;
               
                
            }
            else {
                errorProvider1.Clear();
            }
               {
                if (passwordTextBox.Text.Length <= 5)
                {
                    PassStrength.Visible = true;
                    PassStrength.Text = "Your Pasword is Weak";
                    PassStrength.ForeColor = Color.Red;
                   // passwordTextBox.Focus();
                }
                if (passwordTextBox.Text.Length >=6 && passwordTextBox.Text.Length <= 8)
                {
                    PassStrength.Visible = true;
                   PassStrength.Text = "Your Pasword is Average";
                    PassStrength.ForeColor = Color.Yellow;
                   // passwordTextBox.Focus();
                }
                if (passwordTextBox.Text.Length >= 9)
                {
                    PassStrength.Visible = true;
                    PassStrength.Text = "Your Pasword is Strong";
                   PassStrength.ForeColor = Color.Green;
                    //passwordTextBox.Focus();
                }
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

           /* if (memebrRadio.Checked)
            {
                AsaMemberPanel.Visible = true;
                signUpPanel.Visible = false;
            }*/


        

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            controller = new Controller.AuthorizationModule(this.connectionString
                , usersTableName);
           
            controller.signIn(user, this);
        }

        

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

        private void MakeAMemberButton_Click(object sender, EventArgs e)
        {
            AsaMemberpanel.Visible = false;
            loginPanel.Visible = true;
        }

        // clicking create building

        private void SignupAsAdminButton_Click(object sender, EventArgs e)
        {
            controller = new CreateAndJoinBuilding(connectionString, buildingsTableName);
            Building building = new Building(buildingNameTextbox.Text, Convert.ToInt32(noOfFloorsTextBox.Text), Convert.ToInt32(flatsPerFloorTextbox.Text), codeTextBox.Text, user, Convert.ToInt32(flatNoFormatTextBox.Text));

            controller.createBuilding(building, this,user);
        }


        // will be called by controller when successful

        public void buildingCreated()
        {
            this.Hide();
            MainScreen ms = new MainScreen(user.getID());
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

        public void signInSuccessful()
        {
            this.Hide();

            MainScreen ms = new MainScreen(user.getID());

            ms.ShowDialog();
            this.Dispose();

        }

        public void signUpFailed()
        {
            signUpFaileError.Visible = true;
            emailTextBox.Focus();
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
    }
}
