namespace DBproject.Views
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.PicNamePanel = new System.Windows.Forms.Panel();
            this.flatNumberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.profiePicture = new System.Windows.Forms.PictureBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.quitButton = new XanderUI.XUIButton();
            this.settingsButton = new System.Windows.Forms.Button();
            this.analyticsButton = new System.Windows.Forms.Button();
            this.expensesButton = new System.Windows.Forms.Button();
            this.incomeButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.generateMonthlyReport = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.currentBalLabel = new System.Windows.Forms.Label();
            this.currentBalance = new System.Windows.Forms.Label();
            this.main = new System.Windows.Forms.Panel();
            this.PicNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profiePicture)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicNamePanel
            // 
            this.PicNamePanel.Controls.Add(this.flatNumberLabel);
            this.PicNamePanel.Controls.Add(this.nameLabel);
            this.PicNamePanel.Controls.Add(this.profiePicture);
            this.PicNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicNamePanel.Location = new System.Drawing.Point(0, 0);
            this.PicNamePanel.Name = "PicNamePanel";
            this.PicNamePanel.Size = new System.Drawing.Size(225, 227);
            this.PicNamePanel.TabIndex = 0;
            // 
            // flatNumberLabel
            // 
            this.flatNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.flatNumberLabel.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatNumberLabel.ForeColor = System.Drawing.Color.White;
            this.flatNumberLabel.Location = new System.Drawing.Point(50, 169);
            this.flatNumberLabel.Name = "flatNumberLabel";
            this.flatNumberLabel.Size = new System.Drawing.Size(125, 19);
            this.flatNumberLabel.TabIndex = 2;
            this.flatNumberLabel.Text = "302";
            this.flatNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(15, 139);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(194, 30);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Abdullah Raja";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profiePicture
            // 
            this.profiePicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profiePicture.Image = ((System.Drawing.Image)(resources.GetObject("profiePicture.Image")));
            this.profiePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("profiePicture.InitialImage")));
            this.profiePicture.Location = new System.Drawing.Point(41, 12);
            this.profiePicture.Margin = new System.Windows.Forms.Padding(10);
            this.profiePicture.Name = "profiePicture";
            this.profiePicture.Size = new System.Drawing.Size(142, 121);
            this.profiePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profiePicture.TabIndex = 0;
            this.profiePicture.TabStop = false;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DarkRed;
            this.sidePanel.Controls.Add(this.quitButton);
            this.sidePanel.Controls.Add(this.settingsButton);
            this.sidePanel.Controls.Add(this.analyticsButton);
            this.sidePanel.Controls.Add(this.expensesButton);
            this.sidePanel.Controls.Add(this.incomeButton);
            this.sidePanel.Controls.Add(this.PicNamePanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(225, 720);
            this.sidePanel.TabIndex = 0;
            // 
            // quitButton
            // 
            this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quitButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.quitButton.ButtonImage = null;
            this.quitButton.ButtonStyle = XanderUI.XUIButton.Style.Dark;
            this.quitButton.ButtonText = "LOGOUT";
            this.quitButton.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.quitButton.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.quitButton.CornerRadius = 5;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.quitButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.quitButton.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.quitButton.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.quitButton.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.quitButton.Location = new System.Drawing.Point(47, 644);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(128, 50);
            this.quitButton.TabIndex = 5;
            this.quitButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.quitButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(0, 398);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(10);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(225, 57);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // analyticsButton
            // 
            this.analyticsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.analyticsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.analyticsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.analyticsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.analyticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyticsButton.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyticsButton.ForeColor = System.Drawing.Color.White;
            this.analyticsButton.Location = new System.Drawing.Point(0, 341);
            this.analyticsButton.Margin = new System.Windows.Forms.Padding(10);
            this.analyticsButton.Name = "analyticsButton";
            this.analyticsButton.Size = new System.Drawing.Size(225, 57);
            this.analyticsButton.TabIndex = 3;
            this.analyticsButton.Text = "ANALYTICS";
            this.analyticsButton.UseVisualStyleBackColor = true;
            // 
            // expensesButton
            // 
            this.expensesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.expensesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.expensesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.expensesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.expensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expensesButton.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesButton.ForeColor = System.Drawing.Color.White;
            this.expensesButton.Location = new System.Drawing.Point(0, 284);
            this.expensesButton.Margin = new System.Windows.Forms.Padding(10);
            this.expensesButton.Name = "expensesButton";
            this.expensesButton.Size = new System.Drawing.Size(225, 57);
            this.expensesButton.TabIndex = 2;
            this.expensesButton.Text = "EXPENSES";
            this.expensesButton.UseVisualStyleBackColor = true;
            this.expensesButton.Click += new System.EventHandler(this.expensesButton_Click);
            // 
            // incomeButton
            // 
            this.incomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.incomeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.incomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.incomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.incomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeButton.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeButton.ForeColor = System.Drawing.Color.White;
            this.incomeButton.Location = new System.Drawing.Point(0, 227);
            this.incomeButton.Name = "incomeButton";
            this.incomeButton.Size = new System.Drawing.Size(225, 57);
            this.incomeButton.TabIndex = 1;
            this.incomeButton.Text = "INCOME";
            this.incomeButton.UseVisualStyleBackColor = true;
            this.incomeButton.Click += new System.EventHandler(this.incomeButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.generateMonthlyReport);
            this.topPanel.Controls.Add(this.logoutButton);
            this.topPanel.Controls.Add(this.currentBalLabel);
            this.topPanel.Controls.Add(this.currentBalance);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(225, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(975, 82);
            this.topPanel.TabIndex = 1;
            // 
            // generateMonthlyReport
            // 
            this.generateMonthlyReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.generateMonthlyReport.BackColor = System.Drawing.Color.Transparent;
            this.generateMonthlyReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("generateMonthlyReport.BackgroundImage")));
            this.generateMonthlyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.generateMonthlyReport.FlatAppearance.BorderSize = 0;
            this.generateMonthlyReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.generateMonthlyReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.generateMonthlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateMonthlyReport.ForeColor = System.Drawing.Color.Transparent;
            this.generateMonthlyReport.Image = ((System.Drawing.Image)(resources.GetObject("generateMonthlyReport.Image")));
            this.generateMonthlyReport.Location = new System.Drawing.Point(755, 31);
            this.generateMonthlyReport.Name = "generateMonthlyReport";
            this.generateMonthlyReport.Size = new System.Drawing.Size(40, 33);
            this.generateMonthlyReport.TabIndex = 3;
            this.generateMonthlyReport.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(832, 23);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(122, 40);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // currentBalLabel
            // 
            this.currentBalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentBalLabel.AutoSize = true;
            this.currentBalLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentBalLabel.ForeColor = System.Drawing.Color.White;
            this.currentBalLabel.Location = new System.Drawing.Point(558, 40);
            this.currentBalLabel.Name = "currentBalLabel";
            this.currentBalLabel.Size = new System.Drawing.Size(75, 19);
            this.currentBalLabel.TabIndex = 1;
            this.currentBalLabel.Text = "Balance:";
            // 
            // currentBalance
            // 
            this.currentBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentBalance.AutoSize = true;
            this.currentBalance.BackColor = System.Drawing.Color.Transparent;
            this.currentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalance.ForeColor = System.Drawing.Color.ForestGreen;
            this.currentBalance.Location = new System.Drawing.Point(633, 33);
            this.currentBalance.Name = "currentBalance";
            this.currentBalance.Size = new System.Drawing.Size(119, 29);
            this.currentBalance.TabIndex = 0;
            this.currentBalance.Text = "Rs 20,000";
            // 
            // main
            // 
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(225, 82);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(975, 638);
            this.main.TabIndex = 2;
            // 
            // MainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.main);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.PicNamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profiePicture)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PicNamePanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox profiePicture;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label flatNumberLabel;
        private XanderUI.XUIButton quitButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button analyticsButton;
        private System.Windows.Forms.Button expensesButton;
        private System.Windows.Forms.Button incomeButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label currentBalLabel;
        private System.Windows.Forms.Label currentBalance;
        private System.Windows.Forms.Button generateMonthlyReport;
        private System.Windows.Forms.Panel main;
    }
}