namespace DBproject.Views
{
    partial class ReportDialogBox
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
            this.flatNumberCheckBox = new System.Windows.Forms.CheckBox();
            this.amountCheckbox = new System.Windows.Forms.CheckBox();
            this.monthCheckbox = new System.Windows.Forms.CheckBox();
            this.dateCheckbox = new System.Windows.Forms.CheckBox();
            this.receivableCheckbox = new System.Windows.Forms.CheckBox();
            this.incomeCheckbox = new System.Windows.Forms.CheckBox();
            this.expenseCheckbox = new System.Windows.Forms.CheckBox();
            this.expenseDetails = new System.Windows.Forms.CheckBox();
            this.expenseAmount = new System.Windows.Forms.CheckBox();
            this.expenseDateCheckbox = new System.Windows.Forms.CheckBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // flatNumberCheckBox
            // 
            this.flatNumberCheckBox.AutoSize = true;
            this.flatNumberCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatNumberCheckBox.ForeColor = System.Drawing.Color.DimGray;
            this.flatNumberCheckBox.Location = new System.Drawing.Point(48, 113);
            this.flatNumberCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.flatNumberCheckBox.Name = "flatNumberCheckBox";
            this.flatNumberCheckBox.Size = new System.Drawing.Size(109, 22);
            this.flatNumberCheckBox.TabIndex = 0;
            this.flatNumberCheckBox.Text = "Flat Number";
            this.flatNumberCheckBox.UseVisualStyleBackColor = true;
            this.flatNumberCheckBox.Visible = false;
            // 
            // amountCheckbox
            // 
            this.amountCheckbox.AutoSize = true;
            this.amountCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amountCheckbox.ForeColor = System.Drawing.Color.DimGray;
            this.amountCheckbox.Location = new System.Drawing.Point(48, 150);
            this.amountCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.amountCheckbox.Name = "amountCheckbox";
            this.amountCheckbox.Size = new System.Drawing.Size(81, 22);
            this.amountCheckbox.TabIndex = 1;
            this.amountCheckbox.Text = "Amount";
            this.amountCheckbox.UseVisualStyleBackColor = true;
            this.amountCheckbox.Visible = false;
            // 
            // monthCheckbox
            // 
            this.monthCheckbox.AutoSize = true;
            this.monthCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthCheckbox.ForeColor = System.Drawing.Color.DimGray;
            this.monthCheckbox.Location = new System.Drawing.Point(48, 224);
            this.monthCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.monthCheckbox.Name = "monthCheckbox";
            this.monthCheckbox.Size = new System.Drawing.Size(123, 22);
            this.monthCheckbox.TabIndex = 3;
            this.monthCheckbox.Text = "For the Month";
            this.monthCheckbox.UseVisualStyleBackColor = true;
            this.monthCheckbox.Visible = false;
            // 
            // dateCheckbox
            // 
            this.dateCheckbox.AutoSize = true;
            this.dateCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateCheckbox.ForeColor = System.Drawing.Color.DimGray;
            this.dateCheckbox.Location = new System.Drawing.Point(48, 187);
            this.dateCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.dateCheckbox.Name = "dateCheckbox";
            this.dateCheckbox.Size = new System.Drawing.Size(57, 22);
            this.dateCheckbox.TabIndex = 2;
            this.dateCheckbox.Text = "Date";
            this.dateCheckbox.UseVisualStyleBackColor = true;
            this.dateCheckbox.Visible = false;
            // 
            // receivableCheckbox
            // 
            this.receivableCheckbox.AutoSize = true;
            this.receivableCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receivableCheckbox.ForeColor = System.Drawing.Color.DimGray;
            this.receivableCheckbox.Location = new System.Drawing.Point(48, 261);
            this.receivableCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.receivableCheckbox.Name = "receivableCheckbox";
            this.receivableCheckbox.Size = new System.Drawing.Size(136, 22);
            this.receivableCheckbox.TabIndex = 4;
            this.receivableCheckbox.Text = "Dues Receivable";
            this.receivableCheckbox.UseVisualStyleBackColor = true;
            this.receivableCheckbox.Visible = false;
            // 
            // incomeCheckbox
            // 
            this.incomeCheckbox.AutoSize = true;
            this.incomeCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeCheckbox.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeCheckbox.Location = new System.Drawing.Point(48, 61);
            this.incomeCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.incomeCheckbox.Name = "incomeCheckbox";
            this.incomeCheckbox.Size = new System.Drawing.Size(103, 27);
            this.incomeCheckbox.TabIndex = 5;
            this.incomeCheckbox.Text = "INCOME";
            this.incomeCheckbox.UseVisualStyleBackColor = true;
            this.incomeCheckbox.CheckedChanged += new System.EventHandler(this.incomeCheckbox_CheckedChanged);
            // 
            // expenseCheckbox
            // 
            this.expenseCheckbox.AutoSize = true;
            this.expenseCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenseCheckbox.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseCheckbox.Location = new System.Drawing.Point(270, 61);
            this.expenseCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.expenseCheckbox.Name = "expenseCheckbox";
            this.expenseCheckbox.Size = new System.Drawing.Size(118, 27);
            this.expenseCheckbox.TabIndex = 11;
            this.expenseCheckbox.Text = "EXPENSES";
            this.expenseCheckbox.UseVisualStyleBackColor = true;
            this.expenseCheckbox.CheckedChanged += new System.EventHandler(this.expenseCheckbox_CheckedChanged);
            // 
            // expenseDetails
            // 
            this.expenseDetails.AutoSize = true;
            this.expenseDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenseDetails.ForeColor = System.Drawing.Color.DimGray;
            this.expenseDetails.Location = new System.Drawing.Point(270, 187);
            this.expenseDetails.Margin = new System.Windows.Forms.Padding(4);
            this.expenseDetails.Name = "expenseDetails";
            this.expenseDetails.Size = new System.Drawing.Size(72, 22);
            this.expenseDetails.TabIndex = 8;
            this.expenseDetails.Text = "Details";
            this.expenseDetails.UseVisualStyleBackColor = true;
            this.expenseDetails.Visible = false;
            // 
            // expenseAmount
            // 
            this.expenseAmount.AutoSize = true;
            this.expenseAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenseAmount.ForeColor = System.Drawing.Color.DimGray;
            this.expenseAmount.Location = new System.Drawing.Point(270, 150);
            this.expenseAmount.Margin = new System.Windows.Forms.Padding(4);
            this.expenseAmount.Name = "expenseAmount";
            this.expenseAmount.Size = new System.Drawing.Size(81, 22);
            this.expenseAmount.TabIndex = 7;
            this.expenseAmount.Text = "Amount";
            this.expenseAmount.UseVisualStyleBackColor = true;
            this.expenseAmount.Visible = false;
            // 
            // expenseDateCheckbox
            // 
            this.expenseDateCheckbox.AutoSize = true;
            this.expenseDateCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenseDateCheckbox.ForeColor = System.Drawing.Color.DimGray;
            this.expenseDateCheckbox.Location = new System.Drawing.Point(270, 113);
            this.expenseDateCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.expenseDateCheckbox.Name = "expenseDateCheckbox";
            this.expenseDateCheckbox.Size = new System.Drawing.Size(57, 22);
            this.expenseDateCheckbox.TabIndex = 6;
            this.expenseDateCheckbox.Text = "Date";
            this.expenseDateCheckbox.UseVisualStyleBackColor = true;
            this.expenseDateCheckbox.Visible = false;
            // 
            // monthBox
            // 
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Location = new System.Drawing.Point(486, 88);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(180, 26);
            this.monthBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Month:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Year";
            // 
            // yearBox
            // 
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Items.AddRange(new object[] {
            "2017"});
            this.yearBox.Location = new System.Drawing.Point(486, 163);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(79, 26);
            this.yearBox.TabIndex = 14;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.DarkRed;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(486, 232);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(180, 50);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "GENERATE REPORT";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ReportDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 318);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.expenseCheckbox);
            this.Controls.Add(this.expenseDetails);
            this.Controls.Add(this.expenseAmount);
            this.Controls.Add(this.expenseDateCheckbox);
            this.Controls.Add(this.incomeCheckbox);
            this.Controls.Add(this.receivableCheckbox);
            this.Controls.Add(this.monthCheckbox);
            this.Controls.Add(this.dateCheckbox);
            this.Controls.Add(this.amountCheckbox);
            this.Controls.Add(this.flatNumberCheckBox);
            this.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportDialogBox";
            this.Text = "ReportDialogBox";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox flatNumberCheckBox;
        private System.Windows.Forms.CheckBox amountCheckbox;
        private System.Windows.Forms.CheckBox monthCheckbox;
        private System.Windows.Forms.CheckBox dateCheckbox;
        private System.Windows.Forms.CheckBox receivableCheckbox;
        private System.Windows.Forms.CheckBox incomeCheckbox;
        private System.Windows.Forms.CheckBox expenseCheckbox;
        private System.Windows.Forms.CheckBox expenseDetails;
        private System.Windows.Forms.CheckBox expenseAmount;
        private System.Windows.Forms.CheckBox expenseDateCheckbox;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}