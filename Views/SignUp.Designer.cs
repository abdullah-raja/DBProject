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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.signUpTitle);
            this.panel1.Controls.Add(this.gotoLoginButton);
            this.panel1.Controls.Add(this.AlreadyLabel);
            this.panel1.Controls.Add(this.signUpButton);
            this.panel1.Controls.Add(this.AsLabel);
            this.panel1.Controls.Add(this.memebrRadio);
            this.panel1.Controls.Add(this.adminRadio);
            this.panel1.Controls.Add(this.confirmPasswordTextBox);
            this.panel1.Controls.Add(this.confirmPasswordLabel);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.mobileTextBox);
            this.panel1.Controls.Add(this.mobileLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Location = new System.Drawing.Point(390, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 528);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.gotoLoginButton.Location = new System.Drawing.Point(215, 447);
            this.gotoLoginButton.Name = "gotoLoginButton";
            this.gotoLoginButton.Size = new System.Drawing.Size(53, 20);
            this.gotoLoginButton.TabIndex = 20;
            this.gotoLoginButton.Text = "Login";
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
            // SignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Panel panel1;
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
    }
}