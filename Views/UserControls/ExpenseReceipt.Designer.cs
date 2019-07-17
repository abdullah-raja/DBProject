namespace DBproject.Views.UserControls
{
    partial class ExpenseReceipt
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
            this.expenseNameLabel = new System.Windows.Forms.Label();
            this.expenseReceiptName = new System.Windows.Forms.TextBox();
            this.textBoxPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.expenseReceiptAmountTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rs = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.receiptDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.expenseReceiptTrID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.expenseReceiptMonthBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.expenseReceiptYear = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.expenseReceiptFlatNumber = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.expenseReceiptTitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // expenseNameLabel
            // 
            this.expenseNameLabel.AutoSize = true;
            this.expenseNameLabel.BackColor = System.Drawing.Color.White;
            this.expenseNameLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseNameLabel.Location = new System.Drawing.Point(32, 143);
            this.expenseNameLabel.Name = "expenseNameLabel";
            this.expenseNameLabel.Size = new System.Drawing.Size(56, 19);
            this.expenseNameLabel.TabIndex = 10;
            this.expenseNameLabel.Text = "NAME";
            // 
            // expenseReceiptName
            // 
            this.expenseReceiptName.BackColor = System.Drawing.Color.LightGray;
            this.expenseReceiptName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expenseReceiptName.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseReceiptName.Location = new System.Drawing.Point(8, 5);
            this.expenseReceiptName.Name = "expenseReceiptName";
            this.expenseReceiptName.ReadOnly = true;
            this.expenseReceiptName.Size = new System.Drawing.Size(493, 29);
            this.expenseReceiptName.TabIndex = 0;
            // 
            // textBoxPanel
            // 
            this.textBoxPanel.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPanel.Controls.Add(this.expenseReceiptName);
            this.textBoxPanel.Location = new System.Drawing.Point(35, 164);
            this.textBoxPanel.Name = "textBoxPanel";
            this.textBoxPanel.Padding = new System.Windows.Forms.Padding(10);
            this.textBoxPanel.Size = new System.Drawing.Size(510, 39);
            this.textBoxPanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "AMOUNT";
            // 
            // expenseReceiptAmountTextBox
            // 
            this.expenseReceiptAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expenseReceiptAmountTextBox.BackColor = System.Drawing.Color.LightGray;
            this.expenseReceiptAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expenseReceiptAmountTextBox.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseReceiptAmountTextBox.Location = new System.Drawing.Point(8, 5);
            this.expenseReceiptAmountTextBox.Name = "expenseReceiptAmountTextBox";
            this.expenseReceiptAmountTextBox.ReadOnly = true;
            this.expenseReceiptAmountTextBox.Size = new System.Drawing.Size(148, 29);
            this.expenseReceiptAmountTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.expenseReceiptAmountTextBox);
            this.panel1.Location = new System.Drawing.Point(564, 164);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(169, 39);
            this.panel1.TabIndex = 13;
            // 
            // Rs
            // 
            this.Rs.AutoSize = true;
            this.Rs.BackColor = System.Drawing.Color.White;
            this.Rs.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rs.Location = new System.Drawing.Point(740, 185);
            this.Rs.Name = "Rs";
            this.Rs.Size = new System.Drawing.Size(29, 19);
            this.Rs.TabIndex = 14;
            this.Rs.Text = "Rs.";
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.BackColor = System.Drawing.Color.DarkRed;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.confirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(262, 329);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(123, 51);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "CONFIRM";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "DATE";
            // 
            // receiptDate
            // 
            this.receiptDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptDate.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.receiptDate.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.receiptDate.Location = new System.Drawing.Point(36, 81);
            this.receiptDate.Name = "receiptDate";
            this.receiptDate.Size = new System.Drawing.Size(130, 33);
            this.receiptDate.TabIndex = 0;
            this.receiptDate.ValueChanged += new System.EventHandler(this.receiptDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(561, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "TRANSACTION ID";
            // 
            // expenseReceiptTrID
            // 
            this.expenseReceiptTrID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expenseReceiptTrID.BackColor = System.Drawing.Color.LightGray;
            this.expenseReceiptTrID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expenseReceiptTrID.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseReceiptTrID.Location = new System.Drawing.Point(8, 5);
            this.expenseReceiptTrID.Name = "expenseReceiptTrID";
            this.expenseReceiptTrID.ReadOnly = true;
            this.expenseReceiptTrID.Size = new System.Drawing.Size(183, 29);
            this.expenseReceiptTrID.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.expenseReceiptTrID);
            this.panel2.Location = new System.Drawing.Point(564, 82);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(204, 39);
            this.panel2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "MONTH";
            // 
            // expenseReceiptMonthBox
            // 
            this.expenseReceiptMonthBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expenseReceiptMonthBox.BackColor = System.Drawing.Color.LightGray;
            this.expenseReceiptMonthBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expenseReceiptMonthBox.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseReceiptMonthBox.Location = new System.Drawing.Point(8, 5);
            this.expenseReceiptMonthBox.Name = "expenseReceiptMonthBox";
            this.expenseReceiptMonthBox.ReadOnly = true;
            this.expenseReceiptMonthBox.Size = new System.Drawing.Size(148, 29);
            this.expenseReceiptMonthBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.expenseReceiptMonthBox);
            this.panel3.Location = new System.Drawing.Point(35, 247);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(169, 39);
            this.panel3.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "YEAR";
            // 
            // expenseReceiptYear
            // 
            this.expenseReceiptYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expenseReceiptYear.BackColor = System.Drawing.Color.LightGray;
            this.expenseReceiptYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expenseReceiptYear.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseReceiptYear.Location = new System.Drawing.Point(8, 5);
            this.expenseReceiptYear.Name = "expenseReceiptYear";
            this.expenseReceiptYear.ReadOnly = true;
            this.expenseReceiptYear.Size = new System.Drawing.Size(90, 29);
            this.expenseReceiptYear.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.expenseReceiptYear);
            this.panel4.Location = new System.Drawing.Point(229, 247);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(111, 39);
            this.panel4.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "PAID BY";
            // 
            // expenseReceiptFlatNumber
            // 
            this.expenseReceiptFlatNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expenseReceiptFlatNumber.BackColor = System.Drawing.Color.LightGray;
            this.expenseReceiptFlatNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expenseReceiptFlatNumber.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseReceiptFlatNumber.Location = new System.Drawing.Point(8, 5);
            this.expenseReceiptFlatNumber.Name = "expenseReceiptFlatNumber";
            this.expenseReceiptFlatNumber.ReadOnly = true;
            this.expenseReceiptFlatNumber.Size = new System.Drawing.Size(90, 29);
            this.expenseReceiptFlatNumber.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.expenseReceiptFlatNumber);
            this.panel5.Location = new System.Drawing.Point(564, 247);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(111, 39);
            this.panel5.TabIndex = 21;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.DarkRed;
            this.cancelButton.Location = new System.Drawing.Point(406, 329);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(123, 51);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // expenseReceiptTitle
            // 
            this.expenseReceiptTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expenseReceiptTitle.AutoSize = true;
            this.expenseReceiptTitle.BackColor = System.Drawing.Color.White;
            this.expenseReceiptTitle.Font = new System.Drawing.Font("Lato Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseReceiptTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.expenseReceiptTitle.Location = new System.Drawing.Point(286, 23);
            this.expenseReceiptTitle.Name = "expenseReceiptTitle";
            this.expenseReceiptTitle.Size = new System.Drawing.Size(245, 29);
            this.expenseReceiptTitle.TabIndex = 23;
            this.expenseReceiptTitle.Text = "CONFIRM PAYMENT";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(805, 409);
            this.panel6.TabIndex = 24;
            // 
            // ExpenseReceipt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.expenseReceiptTitle);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.receiptDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.Rs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPanel);
            this.Controls.Add(this.expenseNameLabel);
            this.Controls.Add(this.panel6);
            this.Name = "ExpenseReceipt";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(807, 411);
            this.textBoxPanel.ResumeLayout(false);
            this.textBoxPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label expenseNameLabel;
        private System.Windows.Forms.TextBox expenseReceiptName;
        private System.Windows.Forms.Panel textBoxPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox expenseReceiptAmountTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Rs;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker receiptDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox expenseReceiptTrID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox expenseReceiptMonthBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox expenseReceiptYear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox expenseReceiptFlatNumber;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label expenseReceiptTitle;
        private System.Windows.Forms.Panel panel6;
    }
}
