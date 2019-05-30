namespace DBproject.Views.UserControls
{
    partial class ExpenseCard
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
            this.expenseNameTextBox = new System.Windows.Forms.TextBox();
            this.expenseNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.expenseAmount = new System.Windows.Forms.NumericUpDown();
            this.Rs = new System.Windows.Forms.Label();
            this.deeteButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.textBoxPanel = new System.Windows.Forms.Panel();
            this.panelForAmount = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.expenseAmount)).BeginInit();
            this.textBoxPanel.SuspendLayout();
            this.panelForAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // expenseNameTextBox
            // 
            this.expenseNameTextBox.BackColor = System.Drawing.Color.LightGray;
            this.expenseNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expenseNameTextBox.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseNameTextBox.Location = new System.Drawing.Point(8, 5);
            this.expenseNameTextBox.Name = "expenseNameTextBox";
            this.expenseNameTextBox.Size = new System.Drawing.Size(493, 29);
            this.expenseNameTextBox.TabIndex = 0;
            this.expenseNameTextBox.Text = "Electric bill";
            // 
            // expenseNameLabel
            // 
            this.expenseNameLabel.AutoSize = true;
            this.expenseNameLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseNameLabel.Location = new System.Drawing.Point(18, 10);
            this.expenseNameLabel.Name = "expenseNameLabel";
            this.expenseNameLabel.Size = new System.Drawing.Size(56, 19);
            this.expenseNameLabel.TabIndex = 3;
            this.expenseNameLabel.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "AMOUNT";
            // 
            // expenseAmount
            // 
            this.expenseAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.expenseAmount.BackColor = System.Drawing.Color.LightGray;
            this.expenseAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expenseAmount.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseAmount.Location = new System.Drawing.Point(7, 3);
            this.expenseAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.expenseAmount.Name = "expenseAmount";
            this.expenseAmount.Size = new System.Drawing.Size(107, 32);
            this.expenseAmount.TabIndex = 5;
            // 
            // Rs
            // 
            this.Rs.AutoSize = true;
            this.Rs.BackColor = System.Drawing.Color.Transparent;
            this.Rs.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rs.Location = new System.Drawing.Point(673, 47);
            this.Rs.Name = "Rs";
            this.Rs.Size = new System.Drawing.Size(29, 19);
            this.Rs.TabIndex = 6;
            this.Rs.Text = "Rs.";
            // 
            // deeteButton
            // 
            this.deeteButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deeteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deeteButton.FlatAppearance.BorderSize = 0;
            this.deeteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.deeteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.deeteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deeteButton.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deeteButton.ForeColor = System.Drawing.Color.White;
            this.deeteButton.Location = new System.Drawing.Point(844, 25);
            this.deeteButton.Name = "deeteButton";
            this.deeteButton.Size = new System.Drawing.Size(115, 46);
            this.deeteButton.TabIndex = 7;
            this.deeteButton.Text = "DELETE";
            this.deeteButton.UseVisualStyleBackColor = false;
            this.deeteButton.Click += new System.EventHandler(this.deeteButton_Click);
            // 
            // payButton
            // 
            this.payButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.payButton.BackColor = System.Drawing.Color.DarkRed;
            this.payButton.FlatAppearance.BorderSize = 0;
            this.payButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.payButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.ForeColor = System.Drawing.Color.White;
            this.payButton.Location = new System.Drawing.Point(723, 25);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(115, 46);
            this.payButton.TabIndex = 8;
            this.payButton.Text = "PAY";
            this.payButton.UseVisualStyleBackColor = false;
            // 
            // textBoxPanel
            // 
            this.textBoxPanel.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPanel.Controls.Add(this.expenseNameTextBox);
            this.textBoxPanel.Location = new System.Drawing.Point(22, 32);
            this.textBoxPanel.Name = "textBoxPanel";
            this.textBoxPanel.Padding = new System.Windows.Forms.Padding(10);
            this.textBoxPanel.Size = new System.Drawing.Size(510, 39);
            this.textBoxPanel.TabIndex = 9;
            // 
            // panelForAmount
            // 
            this.panelForAmount.BackColor = System.Drawing.Color.LightGray;
            this.panelForAmount.Controls.Add(this.expenseAmount);
            this.panelForAmount.Location = new System.Drawing.Point(550, 32);
            this.panelForAmount.Name = "panelForAmount";
            this.panelForAmount.Padding = new System.Windows.Forms.Padding(10);
            this.panelForAmount.Size = new System.Drawing.Size(120, 39);
            this.panelForAmount.TabIndex = 10;
            // 
            // ExpenseCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelForAmount);
            this.Controls.Add(this.textBoxPanel);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.deeteButton);
            this.Controls.Add(this.Rs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expenseNameLabel);
            this.MaximumSize = new System.Drawing.Size(975, 88);
            this.MinimumSize = new System.Drawing.Size(975, 88);
            this.Name = "ExpenseCard";
            this.Size = new System.Drawing.Size(975, 88);
            ((System.ComponentModel.ISupportInitialize)(this.expenseAmount)).EndInit();
            this.textBoxPanel.ResumeLayout(false);
            this.textBoxPanel.PerformLayout();
            this.panelForAmount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox expenseNameTextBox;
        private System.Windows.Forms.Label expenseNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown expenseAmount;
        private System.Windows.Forms.Label Rs;
        private System.Windows.Forms.Button deeteButton;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Panel textBoxPanel;
        private System.Windows.Forms.Panel panelForAmount;
    }
}
