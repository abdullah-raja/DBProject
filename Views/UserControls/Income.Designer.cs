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
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.mainPanel.Controls.Add(this.panel3, 1, 1);
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
            this.IncomeTitle.Font = new System.Drawing.Font("Lato Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.IncomeTitle.Location = new System.Drawing.Point(11, 6);
            this.IncomeTitle.Name = "IncomeTitle";
            this.IncomeTitle.Size = new System.Drawing.Size(159, 42);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 31);
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
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(649, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 582);
            this.panel3.TabIndex = 7;
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Income";
            this.Size = new System.Drawing.Size(975, 638);
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
    }
}
