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
            this.FloorsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.detailspanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flatnolabel = new System.Windows.Forms.Label();
            this.feeslabel = new System.Windows.Forms.Label();
            this.dueslabel = new System.Windows.Forms.Label();
            this.NAMEtextBox1 = new System.Windows.Forms.TextBox();
            this.flatnoTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.duesTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.feesTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.CollectButton = new XanderUI.XUIButton();
            this.SettingButton = new XanderUI.XUIButton();
            this.switchButton = new XanderUI.XUIButton();
            this.switchlabel = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.detailspanel.SuspendLayout();
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
            this.mainPanel.Controls.Add(this.detailspanel, 1, 1);
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
            this.MonthLabel.Location = new System.Drawing.Point(3, 4);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(67, 19);
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
            this.monthComboBox.Location = new System.Drawing.Point(76, 3);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(173, 27);
            this.monthComboBox.TabIndex = 1;
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
            // detailspanel
            // 
            this.detailspanel.BackColor = System.Drawing.Color.Gainsboro;
            this.detailspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailspanel.Controls.Add(this.receiptLabel);
            this.detailspanel.Controls.Add(this.switchlabel);
            this.detailspanel.Controls.Add(this.switchButton);
            this.detailspanel.Controls.Add(this.SettingButton);
            this.detailspanel.Controls.Add(this.CollectButton);
            this.detailspanel.Controls.Add(this.feesTextBox3);
            this.detailspanel.Controls.Add(this.duesTextBox2);
            this.detailspanel.Controls.Add(this.flatnoTextBox1);
            this.detailspanel.Controls.Add(this.NAMEtextBox1);
            this.detailspanel.Controls.Add(this.dueslabel);
            this.detailspanel.Controls.Add(this.feeslabel);
            this.detailspanel.Controls.Add(this.flatnolabel);
            this.detailspanel.Controls.Add(this.label1);
            this.detailspanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.detailspanel.Location = new System.Drawing.Point(649, 56);
            this.detailspanel.Name = "detailspanel";
            this.detailspanel.Size = new System.Drawing.Size(323, 579);
            this.detailspanel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // flatnolabel
            // 
            this.flatnolabel.AutoSize = true;
            this.flatnolabel.BackColor = System.Drawing.Color.Transparent;
            this.flatnolabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatnolabel.ForeColor = System.Drawing.Color.DarkRed;
            this.flatnolabel.Location = new System.Drawing.Point(15, 102);
            this.flatnolabel.Name = "flatnolabel";
            this.flatnolabel.Size = new System.Drawing.Size(72, 19);
            this.flatnolabel.TabIndex = 10;
            this.flatnolabel.Text = "Flat No:";
            // 
            // feeslabel
            // 
            this.feeslabel.AutoSize = true;
            this.feeslabel.BackColor = System.Drawing.Color.Transparent;
            this.feeslabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeslabel.ForeColor = System.Drawing.Color.DarkRed;
            this.feeslabel.Location = new System.Drawing.Point(16, 139);
            this.feeslabel.Name = "feeslabel";
            this.feeslabel.Size = new System.Drawing.Size(231, 19);
            this.feeslabel.TabIndex = 11;
            this.feeslabel.Text = "Monthly Maintainance Fees:";
            // 
            // dueslabel
            // 
            this.dueslabel.AutoSize = true;
            this.dueslabel.BackColor = System.Drawing.Color.Transparent;
            this.dueslabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueslabel.ForeColor = System.Drawing.Color.DarkRed;
            this.dueslabel.Location = new System.Drawing.Point(16, 198);
            this.dueslabel.Name = "dueslabel";
            this.dueslabel.Size = new System.Drawing.Size(149, 19);
            this.dueslabel.TabIndex = 12;
            this.dueslabel.Text = "PREVIOUS DUES:";
            this.dueslabel.Click += new System.EventHandler(this.dueslabel_Click);
            // 
            // NAMEtextBox1
            // 
            this.NAMEtextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.NAMEtextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NAMEtextBox1.Location = new System.Drawing.Point(79, 63);
            this.NAMEtextBox1.Name = "NAMEtextBox1";
            this.NAMEtextBox1.ReadOnly = true;
            this.NAMEtextBox1.Size = new System.Drawing.Size(214, 20);
            this.NAMEtextBox1.TabIndex = 13;
            this.NAMEtextBox1.Text = "SARIM";
            // 
            // flatnoTextBox1
            // 
            this.flatnoTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.flatnoTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flatnoTextBox1.Location = new System.Drawing.Point(88, 101);
            this.flatnoTextBox1.Name = "flatnoTextBox1";
            this.flatnoTextBox1.ReadOnly = true;
            this.flatnoTextBox1.Size = new System.Drawing.Size(205, 20);
            this.flatnoTextBox1.TabIndex = 14;
            this.flatnoTextBox1.Text = "112";
            // 
            // duesTextBox2
            // 
            this.duesTextBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.duesTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.duesTextBox2.Location = new System.Drawing.Point(20, 220);
            this.duesTextBox2.Name = "duesTextBox2";
            this.duesTextBox2.ReadOnly = true;
            this.duesTextBox2.Size = new System.Drawing.Size(187, 20);
            this.duesTextBox2.TabIndex = 15;
            this.duesTextBox2.Text = "0000";
            this.duesTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.duesTextBox2_MaskInputRejected);
            // 
            // feesTextBox3
            // 
            this.feesTextBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.feesTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feesTextBox3.Location = new System.Drawing.Point(20, 161);
            this.feesTextBox3.Name = "feesTextBox3";
            this.feesTextBox3.ReadOnly = true;
            this.feesTextBox3.Size = new System.Drawing.Size(107, 20);
            this.feesTextBox3.TabIndex = 16;
            this.feesTextBox3.Text = "1000";
            this.feesTextBox3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.feesTextBox3_MaskInputRejected);
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
            this.CollectButton.Location = new System.Drawing.Point(17, 316);
            this.CollectButton.Name = "CollectButton";
            this.CollectButton.Size = new System.Drawing.Size(90, 30);
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
            this.SettingButton.Location = new System.Drawing.Point(142, 316);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(90, 30);
            this.SettingButton.TabIndex = 26;
            this.SettingButton.TextColor = System.Drawing.Color.White;
            this.SettingButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // switchButton
            // 
            this.switchButton.BackgroundColor = System.Drawing.Color.DarkRed;
            this.switchButton.ButtonImage = null;
            this.switchButton.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.switchButton.ButtonText = "MEMBER";
            this.switchButton.ClickBackColor = System.Drawing.Color.White;
            this.switchButton.ClickTextColor = System.Drawing.Color.DarkRed;
            this.switchButton.CornerRadius = 5;
            this.switchButton.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.switchButton.HoverBackgroundColor = System.Drawing.Color.Brown;
            this.switchButton.HoverTextColor = System.Drawing.Color.White;
            this.switchButton.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.switchButton.Location = new System.Drawing.Point(18, 276);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(57, 23);
            this.switchButton.TabIndex = 27;
            this.switchButton.TextColor = System.Drawing.Color.White;
            this.switchButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.switchButton.Visible = false;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            this.switchButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.switchButton_MouseClick);
            // 
            // switchlabel
            // 
            this.switchlabel.AutoSize = true;
            this.switchlabel.BackColor = System.Drawing.Color.Transparent;
            this.switchlabel.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.switchlabel.Location = new System.Drawing.Point(16, 260);
            this.switchlabel.Name = "switchlabel";
            this.switchlabel.Size = new System.Drawing.Size(120, 13);
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
            this.receiptLabel.Size = new System.Drawing.Size(112, 29);
            this.receiptLabel.TabIndex = 29;
            this.receiptLabel.Text = "DETAILS";
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
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
            this.detailspanel.ResumeLayout(false);
            this.detailspanel.PerformLayout();
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
        private System.Windows.Forms.Panel detailspanel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label switchlabel;
        private XanderUI.XUIButton switchButton;
        private XanderUI.XUIButton SettingButton;
        private XanderUI.XUIButton CollectButton;
        private System.Windows.Forms.MaskedTextBox feesTextBox3;
        private System.Windows.Forms.MaskedTextBox duesTextBox2;
        private System.Windows.Forms.MaskedTextBox flatnoTextBox1;
        private System.Windows.Forms.TextBox NAMEtextBox1;
        private System.Windows.Forms.Label dueslabel;
        private System.Windows.Forms.Label feeslabel;
        private System.Windows.Forms.Label flatnolabel;
        private System.Windows.Forms.Label label1;
    }
}
