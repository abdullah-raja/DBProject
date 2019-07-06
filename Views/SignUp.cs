﻿using System;
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
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                confirmPasswordError.Visible = true;
                confirmPasswordTextBox.Text = "";
                confirmPasswordTextBox.Focus();
            }

            else
            {
                Model.User user = new User(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, passwordTextBox.Text, adminRadio.Checked, mobileTextBox.Text);
                authorizationModule.insertRecord(user, this);

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

        

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
    }
}
