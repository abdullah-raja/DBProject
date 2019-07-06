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

namespace DBproject.Views
{
    public partial class SignUp : Form
    {
        string connectionString = @"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=Project_Database;Integrated Security=True";
        string usersTableName = "tbl_User";
        Controller.AuthorizationModule authorizationModule;
        public SignUp()
        {
            InitializeComponent();
            authorizationModule = new Controller.AuthorizationModule(this.connectionString
                , usersTableName);
        }

        private void jGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuiGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminRadio_Click(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == confirmPasswordTextBox.Text)
            {
                if (adminRadio.Checked)
                {

                    Model.User user = new User(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, passwordTextBox.Text, adminRadio.Checked, mobileTextBox.Text);

                    authorizationModule.insertRecord(user, this);

                    AdminPanel.Visible = true;
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

            else
            {
                confirmPasswordError.Visible = true;
                confirmPasswordTextBox.Text = "";
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
            this.Hide();
            MainScreen ms = new MainScreen();
            ms.ShowDialog();
            this.Dispose();

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AsanAdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MakeAMemberButton_Click(object sender, EventArgs e)
        {
            AsaMemberpanel.Visible = false;
            loginPanel.Visible = true;
        }

        private void SignupAsAdminButton_Click(object sender, EventArgs e)
        {
            AdminPanel.Visible = false;
            loginPanel.Visible = true;
        }

        public void setWelcomeTitle(string title)
        {
            welcomeTitle.Text = title;
        }
    }
}
