namespace DBproject.Views
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.signUpPanel = new System.Windows.Forms.Panel();
            this.signUpTitle = new System.Windows.Forms.Label();
            this.gotoLoginButton = new System.Windows.Forms.Label();
            this.AlreadyLabel = new System.Windows.Forms.Label();
            this.signUpButton = new XanderUI.XUIButton();
            this.AsLabel = new System.Windows.Forms.Label();
            this.memebrRadio = new XanderUI.XUIRadio();
            this.adminRadio = new XanderUI.XUIRadio();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.exitButton = new XanderUI.XUIButton();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.userNameTextLogin = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passwordLabelLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keepSignedIn = new System.Windows.Forms.CheckBox();
            this.loginButton = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gotoSignUpButton = new System.Windows.Forms.Label();
            this.signUpPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Maroon;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Maroon;
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.Maroon;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(347, 720);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Horizontal;
            this.xuiGradientPanel1.TabIndex = 0;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.Brown;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Brown;
            this.xuiGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.xuiGradientPanel1_Paint);
            // 
            // signUpPanel
            // 
            this.signUpPanel.BackColor = System.Drawing.Color.Transparent;
            this.signUpPanel.Controls.Add(this.signUpTitle);
            this.signUpPanel.Controls.Add(this.gotoLoginButton);
            this.signUpPanel.Controls.Add(this.AlreadyLabel);
            this.signUpPanel.Controls.Add(this.signUpButton);
            this.signUpPanel.Controls.Add(this.AsLabel);
            this.signUpPanel.Controls.Add(this.memebrRadio);
            this.signUpPanel.Controls.Add(this.adminRadio);
            this.signUpPanel.Controls.Add(this.confirmPasswordTextBox);
            this.signUpPanel.Controls.Add(this.confirmPasswordLabel);
            this.signUpPanel.Controls.Add(this.passwordTextBox);
            this.signUpPanel.Controls.Add(this.passwordLabel);
            this.signUpPanel.Controls.Add(this.mobileTextBox);
            this.signUpPanel.Controls.Add(this.mobileLabel);
            this.signUpPanel.Controls.Add(this.emailTextBox);
            this.signUpPanel.Controls.Add(this.emailLabel);
            this.signUpPanel.Controls.Add(this.nameTextBox);
            this.signUpPanel.Controls.Add(this.NameLabel);
            this.signUpPanel.Location = new System.Drawing.Point(390, 67);
            this.signUpPanel.Name = "signUpPanel";
            this.signUpPanel.Size = new System.Drawing.Size(675, 528);
            this.signUpPanel.TabIndex = 1;
            this.signUpPanel.Visible = false;
            this.signUpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // signUpTitle
            // 
            this.signUpTitle.AutoSize = true;
            this.signUpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.signUpTitle.Location = new System.Drawing.Point(18, 27);
            this.signUpTitle.Name = "signUpTitle";
            this.signUpTitle.Size = new System.Drawing.Size(259, 31);
            this.signUpTitle.TabIndex = 21;
            this.signUpTitle.Text = "Create An Account";
            // 
            // gotoLoginButton
            // 
            this.gotoLoginButton.AutoSize = true;
            this.gotoLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoLoginButton.ForeColor = System.Drawing.Color.DarkRed;
            this.gotoLoginButton.Location = new System.Drawing.Point(237, 447);
            this.gotoLoginButton.Name = "gotoLoginButton";
            this.gotoLoginButton.Size = new System.Drawing.Size(53, 20);
            this.gotoLoginButton.TabIndex = 20;
            this.gotoLoginButton.Text = "Login";
            this.gotoLoginButton.Click += new System.EventHandler(this.gotoLoginButton_Click);
            // 
            // AlreadyLabel
            // 
            this.AlreadyLabel.AutoSize = true;
            this.AlreadyLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.AlreadyLabel.Location = new System.Drawing.Point(24, 447);
            this.AlreadyLabel.Name = "AlreadyLabel";
            this.AlreadyLabel.Size = new System.Drawing.Size(207, 19);
            this.AlreadyLabel.TabIndex = 19;
            this.AlreadyLabel.Text = "Already have an account?";
            // 
            // signUpButton
            // 
            this.signUpButton.BackgroundColor = System.Drawing.Color.DarkRed;
            this.signUpButton.ButtonImage = null;
            this.signUpButton.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.signUpButton.ButtonText = "Check";
            this.signUpButton.ClickBackColor = System.Drawing.Color.White;
            this.signUpButton.ClickTextColor = System.Drawing.Color.DarkRed;
            this.signUpButton.CornerRadius = 5;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.signUpButton.HoverBackgroundColor = System.Drawing.Color.Brown;
            this.signUpButton.HoverTextColor = System.Drawing.Color.White;
            this.signUpButton.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.signUpButton.Location = new System.Drawing.Point(24, 380);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(145, 50);
            this.signUpButton.TabIndex = 18;
            this.signUpButton.TextColor = System.Drawing.Color.White;
            this.signUpButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // AsLabel
            // 
            this.AsLabel.AutoSize = true;
            this.AsLabel.BackColor = System.Drawing.Color.Transparent;
            this.AsLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.AsLabel.Location = new System.Drawing.Point(357, 191);
            this.AsLabel.Name = "AsLabel";
            this.AsLabel.Size = new System.Drawing.Size(67, 19);
            this.AsLabel.TabIndex = 17;
            this.AsLabel.Text = "As a/an";
            // 
            // memebrRadio
            // 
            this.memebrRadio.Checked = false;
            this.memebrRadio.ForeColor = System.Drawing.Color.Black;
            this.memebrRadio.Location = new System.Drawing.Point(477, 228);
            this.memebrRadio.Name = "memebrRadio";
            this.memebrRadio.RadioColor = System.Drawing.Color.DarkRed;
            this.memebrRadio.RadioHoverColor = System.Drawing.Color.Black;
            this.memebrRadio.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.memebrRadio.Size = new System.Drawing.Size(94, 16);
            this.memebrRadio.TabIndex = 16;
            this.memebrRadio.Text = "Member";
            // 
            // adminRadio
            // 
            this.adminRadio.Checked = false;
            this.adminRadio.ForeColor = System.Drawing.Color.Black;
            this.adminRadio.Location = new System.Drawing.Point(365, 228);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.RadioColor = System.Drawing.Color.DarkRed;
            this.adminRadio.RadioHoverColor = System.Drawing.Color.Black;
            this.adminRadio.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.adminRadio.Size = new System.Drawing.Size(78, 16);
            this.adminRadio.TabIndex = 15;
            this.adminRadio.Text = "Admin";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(361, 316);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(300, 29);
            this.confirmPasswordTextBox.TabIndex = 14;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(361, 284);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(157, 19);
            this.confirmPasswordLabel.TabIndex = 13;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(24, 316);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(300, 29);
            this.passwordTextBox.TabIndex = 12;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.passwordLabel.Location = new System.Drawing.Point(24, 284);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(90, 19);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password:";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextBox.ForeColor = System.Drawing.Color.Black;
            this.mobileTextBox.Location = new System.Drawing.Point(24, 223);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(300, 29);
            this.mobileTextBox.TabIndex = 10;
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.BackColor = System.Drawing.Color.Transparent;
            this.mobileLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.mobileLabel.Location = new System.Drawing.Point(24, 191);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(136, 19);
            this.mobileLabel.TabIndex = 9;
            this.mobileLabel.Text = "Mobile Number:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.Location = new System.Drawing.Point(361, 130);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(300, 29);
            this.emailTextBox.TabIndex = 8;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.emailLabel.Location = new System.Drawing.Point(361, 97);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 19);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(24, 130);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(300, 29);
            this.nameTextBox.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.NameLabel.Location = new System.Drawing.Point(24, 97);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 19);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "User Name:";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.exitButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("exitButton.ButtonImage")));
            this.exitButton.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.exitButton.ButtonText = "";
            this.exitButton.ClickBackColor = System.Drawing.Color.Transparent;
            this.exitButton.ClickTextColor = System.Drawing.Color.Transparent;
            this.exitButton.CornerRadius = 5;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.exitButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.exitButton.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.exitButton.HoverTextColor = System.Drawing.Color.White;
            this.exitButton.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.exitButton.Location = new System.Drawing.Point(1131, 658);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(57, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.TextColor = System.Drawing.Color.Black;
            this.exitButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.gotoSignUpButton);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.keepSignedIn);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.textBox1);
            this.loginPanel.Controls.Add(this.passwordLabelLogin);
            this.loginPanel.Controls.Add(this.userNameTextLogin);
            this.loginPanel.Controls.Add(this.userNameLabel);
            this.loginPanel.Location = new System.Drawing.Point(393, 59);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(687, 452);
            this.loginPanel.TabIndex = 3;
            // 
            // userNameTextLogin
            // 
            this.userNameTextLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTextLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextLogin.ForeColor = System.Drawing.Color.Black;
            this.userNameTextLogin.Location = new System.Drawing.Point(31, 124);
            this.userNameTextLogin.Name = "userNameTextLogin";
            this.userNameTextLogin.Size = new System.Drawing.Size(300, 29);
            this.userNameTextLogin.TabIndex = 8;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.userNameLabel.Location = new System.Drawing.Point(31, 91);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(100, 19);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "User Name:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(350, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(300, 29);
            this.textBox1.TabIndex = 10;
            // 
            // passwordLabelLogin
            // 
            this.passwordLabelLogin.AutoSize = true;
            this.passwordLabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabelLogin.ForeColor = System.Drawing.Color.DarkRed;
            this.passwordLabelLogin.Location = new System.Drawing.Point(350, 91);
            this.passwordLabelLogin.Name = "passwordLabelLogin";
            this.passwordLabelLogin.Size = new System.Drawing.Size(90, 19);
            this.passwordLabelLogin.TabIndex = 9;
            this.passwordLabelLogin.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Login";
            // 
            // keepSignedIn
            // 
            this.keepSignedIn.AutoSize = true;
            this.keepSignedIn.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keepSignedIn.ForeColor = System.Drawing.Color.Gray;
            this.keepSignedIn.Location = new System.Drawing.Point(31, 169);
            this.keepSignedIn.Name = "keepSignedIn";
            this.keepSignedIn.Size = new System.Drawing.Size(156, 23);
            this.keepSignedIn.TabIndex = 23;
            this.keepSignedIn.Text = "Keep Me Signed In";
            this.keepSignedIn.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.BackgroundColor = System.Drawing.Color.DarkRed;
            this.loginButton.ButtonImage = null;
            this.loginButton.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.loginButton.ButtonText = "Login";
            this.loginButton.ClickBackColor = System.Drawing.Color.White;
            this.loginButton.ClickTextColor = System.Drawing.Color.DarkRed;
            this.loginButton.CornerRadius = 5;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.loginButton.HoverBackgroundColor = System.Drawing.Color.Brown;
            this.loginButton.HoverTextColor = System.Drawing.Color.White;
            this.loginButton.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.loginButton.Location = new System.Drawing.Point(31, 213);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(145, 50);
            this.loginButton.TabIndex = 24;
            this.loginButton.TextColor = System.Drawing.Color.White;
            this.loginButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(31, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Don\'t have an account?";
            // 
            // gotoSignUpButton
            // 
            this.gotoSignUpButton.AutoSize = true;
            this.gotoSignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoSignUpButton.ForeColor = System.Drawing.Color.DarkRed;
            this.gotoSignUpButton.Location = new System.Drawing.Point(227, 287);
            this.gotoSignUpButton.Name = "gotoSignUpButton";
            this.gotoSignUpButton.Size = new System.Drawing.Size(73, 20);
            this.gotoSignUpButton.TabIndex = 26;
            this.gotoSignUpButton.Text = "Sign Up";
            this.gotoSignUpButton.Click += new System.EventHandler(this.gotoSignUpButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signUpPanel);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.signUpPanel.ResumeLayout(false);
            this.signUpPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Panel signUpPanel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AsLabel;
        private XanderUI.XUIRadio memebrRadio;
        private XanderUI.XUIRadio adminRadio;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.Label signUpTitle;
        private System.Windows.Forms.Label gotoLoginButton;
        private System.Windows.Forms.Label AlreadyLabel;
        private XanderUI.XUIButton signUpButton;
        private XanderUI.XUIButton exitButton;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label gotoSignUpButton;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton loginButton;
        private System.Windows.Forms.CheckBox keepSignedIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label passwordLabelLogin;
        private System.Windows.Forms.TextBox userNameTextLogin;
        private System.Windows.Forms.Label userNameLabel;
    }
}