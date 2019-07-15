namespace DBproject.Views.UserControls
{
    partial class Income
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IncomeTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.FloorsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.xuiBackgroundSleeper1 = new XanderUI.XUIBackgroundSleeper();
            this.label1 = new System.Windows.Forms.Label();
            this.flatnolabel = new System.Windows.Forms.Label();
            this.feeslabel = new System.Windows.Forms.Label();
            this.dueslabel = new System.Windows.Forms.Label();
            this.detailsName = new System.Windows.Forms.TextBox();
            this.detailsFlatNumber = new System.Windows.Forms.MaskedTextBox();
            this.detailsDues = new System.Windows.Forms.MaskedTextBox();
            this.detailsMaintanance = new System.Windows.Forms.MaskedTextBox();
            this.CollectButton = new XanderUI.XUIButton();
            this.SettingButton = new XanderUI.XUIButton();
            this.managerButton = new XanderUI.XUIButton();
            this.switchlabel = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.detailsEmailLabel = new System.Windows.Forms.Label();
            this.detailsEmail = new System.Windows.Forms.MaskedTextBox();
            this.detailsMobileLabel = new System.Windows.Forms.Label();
            this.detailsMobile = new System.Windows.Forms.MaskedTextBox();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.35897F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.64103F));
            this.mainPanel.Controls.Add(this.panel1, 0, 0);
            this.mainPanel.Controls.Add(this.panel2, 1, 0);
            this.mainPanel.Controls.Add(this.FloorsPanel, 0, 1);
            this.mainPanel.Controls.Add(this.detailsPanel, 1, 1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 2;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.369099F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.6309F));
            this.mainPanel.Size = new System.Drawing.Size(975, 638);
            this.mainPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.IncomeTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 50);
            this.panel1.TabIndex = 4;
            // 
            // IncomeTitle
            // 
            this.IncomeTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IncomeTitle.AutoSize = true;
            this.IncomeTitle.BackColor = System.Drawing.Color.Transparent;
            this.IncomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.IncomeTitle.Location = new System.Drawing.Point(11, 6);
            this.IncomeTitle.Name = "IncomeTitle";
            this.IncomeTitle.Size = new System.Drawing.Size(161, 39);
            this.IncomeTitle.TabIndex = 3;
            this.IncomeTitle.Text = "INCOME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(646, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 50);
            this.panel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.MonthLabel);
            this.flowLayoutPanel1.Controls.Add(this.monthComboBox);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(275, 31);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // MonthLabel
            // 
            this.MonthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.BackColor = System.Drawing.Color.Transparent;
            this.MonthLabel.Location = new System.Drawing.Point(3, 7);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(61, 19);
            this.MonthLabel.TabIndex = 0;
            this.MonthLabel.Text = "Month:";
            this.MonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // monthComboBox
            // 
            this.monthComboBox.BackColor = System.Drawing.Color.White;
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthComboBox.Location = new System.Drawing.Point(70, 3);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(173, 27);
            this.monthComboBox.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // FloorsPanel
            // 
            this.FloorsPanel.AutoScroll = true;
            this.FloorsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FloorsPanel.Location = new System.Drawing.Point(3, 56);
            this.FloorsPanel.Name = "FloorsPanel";
            this.FloorsPanel.Size = new System.Drawing.Size(640, 579);
            this.FloorsPanel.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // flatnolabel
            // 
            this.flatnolabel.AutoSize = true;
            this.flatnolabel.BackColor = System.Drawing.Color.Transparent;
            this.flatnolabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatnolabel.ForeColor = System.Drawing.Color.DarkRed;
            this.flatnolabel.Location = new System.Drawing.Point(14, 102);
            this.flatnolabel.Name = "flatnolabel";
            this.flatnolabel.Size = new System.Drawing.Size(64, 19);
            this.flatnolabel.TabIndex = 10;
            this.flatnolabel.Text = "Flat No:";
            // 
            // feeslabel
            // 
            this.feeslabel.AutoSize = true;
            this.feeslabel.BackColor = System.Drawing.Color.Transparent;
            this.feeslabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeslabel.ForeColor = System.Drawing.Color.DarkRed;
            this.feeslabel.Location = new System.Drawing.Point(14, 139);
            this.feeslabel.Name = "feeslabel";
            this.feeslabel.Size = new System.Drawing.Size(210, 19);
            this.feeslabel.TabIndex = 11;
            this.feeslabel.Text = "Monthly Maintainance Fees:";
            // 
            // dueslabel
            // 
            this.dueslabel.AutoSize = true;
            this.dueslabel.BackColor = System.Drawing.Color.Transparent;
            this.dueslabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueslabel.ForeColor = System.Drawing.Color.DarkRed;
            this.dueslabel.Location = new System.Drawing.Point(14, 198);
            this.dueslabel.Name = "dueslabel";
            this.dueslabel.Size = new System.Drawing.Size(137, 19);
            this.dueslabel.TabIndex = 12;
            this.dueslabel.Text = "PREVIOUS DUES:";
            this.dueslabel.Click += new System.EventHandler(this.dueslabel_Click);
            // 
            // detailsName
            // 
            this.detailsName.BackColor = System.Drawing.Color.Gainsboro;
            this.detailsName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsName.Location = new System.Drawing.Point(79, 63);
            this.detailsName.Name = "detailsName";
            this.detailsName.ReadOnly = true;
            this.detailsName.Size = new System.Drawing.Size(214, 20);
            this.detailsName.TabIndex = 13;
            this.detailsName.Text = "SARIM";
            // 
            // detailsFlatNumber
            // 
            this.detailsFlatNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.detailsFlatNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsFlatNumber.Location = new System.Drawing.Point(88, 101);
            this.detailsFlatNumber.Name = "detailsFlatNumber";
            this.detailsFlatNumber.ReadOnly = true;
            this.detailsFlatNumber.Size = new System.Drawing.Size(205, 20);
            this.detailsFlatNumber.TabIndex = 14;
            this.detailsFlatNumber.Text = "112";
            // 
            // detailsDues
            // 
            this.detailsDues.BackColor = System.Drawing.Color.Gainsboro;
            this.detailsDues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsDues.Location = new System.Drawing.Point(18, 220);
            this.detailsDues.Name = "detailsDues";
            this.detailsDues.ReadOnly = true;
            this.detailsDues.Size = new System.Drawing.Size(187, 20);
            this.detailsDues.TabIndex = 15;
            this.detailsDues.Text = "0000";
            this.detailsDues.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.duesTextBox2_MaskInputRejected);
            // 
            // detailsMaintanance
            // 
            this.detailsMaintanance.BackColor = System.Drawing.Color.Gainsboro;
            this.detailsMaintanance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsMaintanance.Location = new System.Drawing.Point(18, 161);
            this.detailsMaintanance.Name = "detailsMaintanance";
            this.detailsMaintanance.ReadOnly = true;
            this.detailsMaintanance.Size = new System.Drawing.Size(107, 20);
            this.detailsMaintanance.TabIndex = 16;
            this.detailsMaintanance.Text = "1000";
            this.detailsMaintanance.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.feesTextBox3_MaskInputRejected);
            // 
            // CollectButton
            // 
            this.CollectButton.BackgroundColor = System.Drawing.Color.DarkRed;
            this.CollectButton.ButtonImage = null;
            this.CollectButton.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.CollectButton.ButtonText = "COLLECT";
            this.CollectButton.ClickBackColor = System.Drawing.Color.White;
            this.CollectButton.ClickTextColor = System.Drawing.Color.DarkRed;
            this.CollectButton.CornerRadius = 5;
            this.CollectButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.CollectButton.HoverBackgroundColor = System.Drawing.Color.Brown;
            this.CollectButton.HoverTextColor = System.Drawing.Color.White;
            this.CollectButton.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.CollectButton.Location = new System.Drawing.Point(17, 462);
            this.CollectButton.Name = "CollectButton";
            this.CollectButton.Size = new System.Drawing.Size(108, 44);
            this.CollectButton.TabIndex = 25;
            this.CollectButton.TextColor = System.Drawing.Color.White;
            this.CollectButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.CollectButton.Click += new System.EventHandler(this.CollectButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.BackgroundColor = System.Drawing.Color.DarkRed;
            this.SettingButton.ButtonImage = null;
            this.SettingButton.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.SettingButton.ButtonText = "SETTING";
            this.SettingButton.ClickBackColor = System.Drawing.Color.White;
            this.SettingButton.ClickTextColor = System.Drawing.Color.DarkRed;
            this.SettingButton.CornerRadius = 5;
            this.SettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SettingButton.HoverBackgroundColor = System.Drawing.Color.Brown;
            this.SettingButton.HoverTextColor = System.Drawing.Color.White;
            this.SettingButton.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SettingButton.Location = new System.Drawing.Point(142, 462);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(116, 44);
            this.SettingButton.TabIndex = 26;
            this.SettingButton.TextColor = System.Drawing.Color.White;
            this.SettingButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // managerButton
            // 
            this.managerButton.BackgroundColor = System.Drawing.Color.DarkRed;
            this.managerButton.ButtonImage = null;
            this.managerButton.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.managerButton.ButtonText = "MEMBER";
            this.managerButton.ClickBackColor = System.Drawing.Color.White;
            this.managerButton.ClickTextColor = System.Drawing.Color.DarkRed;
            this.managerButton.CornerRadius = 5;
            this.managerButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.managerButton.HoverBackgroundColor = System.Drawing.Color.Brown;
            this.managerButton.HoverTextColor = System.Drawing.Color.White;
            this.managerButton.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.managerButton.Location = new System.Drawing.Point(18, 422);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(57, 23);
            this.managerButton.TabIndex = 27;
            this.managerButton.TextColor = System.Drawing.Color.White;
            this.managerButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.managerButton.Visible = false;
            this.managerButton.Click += new System.EventHandler(this.switchButton_Click);
            this.managerButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.switchButton_MouseClick);
            // 
            // switchlabel
            // 
            this.switchlabel.AutoSize = true;
            this.switchlabel.BackColor = System.Drawing.Color.Transparent;
            this.switchlabel.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.switchlabel.Location = new System.Drawing.Point(16, 406);
            this.switchlabel.Name = "switchlabel";
            this.switchlabel.Size = new System.Drawing.Size(106, 13);
            this.switchlabel.TabIndex = 28;
            this.switchlabel.Text = "Switch To Manager?";
            this.switchlabel.Visible = false;
            // 
            // receiptLabel
            // 
            this.receiptLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.BackColor = System.Drawing.Color.DarkRed;
            this.receiptLabel.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.ForeColor = System.Drawing.Color.White;
            this.receiptLabel.Location = new System.Drawing.Point(111, 12);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(107, 29);
            this.receiptLabel.TabIndex = 29;
            this.receiptLabel.Text = "DETAILS";
            // 
            // detailsEmailLabel
            // 
            this.detailsEmailLabel.AutoSize = true;
            this.detailsEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.detailsEmailLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsEmailLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.detailsEmailLabel.Location = new System.Drawing.Point(14, 259);
            this.detailsEmailLabel.Name = "detailsEmailLabel";
            this.detailsEmailLabel.Size = new System.Drawing.Size(51, 19);
            this.detailsEmailLabel.TabIndex = 30;
            this.detailsEmailLabel.Text = "Email:";
            // 
            // detailsEmail
            // 
            this.detailsEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.detailsEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsEmail.Location = new System.Drawing.Point(71, 259);
            this.detailsEmail.Name = "detailsEmail";
            this.detailsEmail.ReadOnly = true;
            this.detailsEmail.Size = new System.Drawing.Size(187, 20);
            this.detailsEmail.TabIndex = 31;
            this.detailsEmail.Text = "Abd@gmail.com";
            // 
            // detailsMobileLabel
            // 
            this.detailsMobileLabel.AutoSize = true;
            this.detailsMobileLabel.BackColor = System.Drawing.Color.Transparent;
            this.detailsMobileLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsMobileLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.detailsMobileLabel.Location = new System.Drawing.Point(15, 304);
            this.detailsMobileLabel.Name = "detailsMobileLabel";
            this.detailsMobileLabel.Size = new System.Drawing.Size(63, 19);
            this.detailsMobileLabel.TabIndex = 32;
            this.detailsMobileLabel.Text = "Mobile:";
            // 
            // detailsMobile
            // 
            this.detailsMobile.BackColor = System.Drawing.Color.Gainsboro;
            this.detailsMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsMobile.Location = new System.Drawing.Point(89, 304);
            this.detailsMobile.Name = "detailsMobile";
            this.detailsMobile.ReadOnly = true;
            this.detailsMobile.Size = new System.Drawing.Size(187, 20);
            this.detailsMobile.TabIndex = 33;
            this.detailsMobile.Text = "0324-2140044";
            // 
            // detailsPanel
            // 
            this.detailsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.detailsMobile);
            this.detailsPanel.Controls.Add(this.detailsMobileLabel);
            this.detailsPanel.Controls.Add(this.detailsEmail);
            this.detailsPanel.Controls.Add(this.detailsEmailLabel);
            this.detailsPanel.Controls.Add(this.receiptLabel);
            this.detailsPanel.Controls.Add(this.switchlabel);
            this.detailsPanel.Controls.Add(this.managerButton);
            this.detailsPanel.Controls.Add(this.SettingButton);
            this.detailsPanel.Controls.Add(this.CollectButton);
            this.detailsPanel.Controls.Add(this.detailsMaintanance);
            this.detailsPanel.Controls.Add(this.detailsDues);
            this.detailsPanel.Controls.Add(this.detailsFlatNumber);
            this.detailsPanel.Controls.Add(this.detailsName);
            this.detailsPanel.Controls.Add(this.dueslabel);
            this.detailsPanel.Controls.Add(this.feeslabel);
            this.detailsPanel.Controls.Add(this.flatnolabel);
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.detailsPanel.Location = new System.Drawing.Point(649, 56);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(323, 579);
            this.detailsPanel.TabIndex = 16;
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Income";
            this.Size = new System.Drawing.Size(975, 638);
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label IncomeTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.FlowLayoutPanel FloorsPanel;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private XanderUI.XUIBackgroundSleeper xuiBackgroundSleeper1;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.MaskedTextBox detailsMobile;
        private System.Windows.Forms.Label detailsMobileLabel;
        private System.Windows.Forms.MaskedTextBox detailsEmail;
        private System.Windows.Forms.Label detailsEmailLabel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label switchlabel;
        private XanderUI.XUIButton managerButton;
        private XanderUI.XUIButton SettingButton;
        private XanderUI.XUIButton CollectButton;
        private System.Windows.Forms.MaskedTextBox detailsMaintanance;
        private System.Windows.Forms.MaskedTextBox detailsDues;
        private System.Windows.Forms.MaskedTextBox detailsFlatNumber;
        private System.Windows.Forms.TextBox detailsName;
        private System.Windows.Forms.Label dueslabel;
        private System.Windows.Forms.Label feeslabel;
        private System.Windows.Forms.Label flatnolabel;
        private System.Windows.Forms.Label label1;
    }
}
