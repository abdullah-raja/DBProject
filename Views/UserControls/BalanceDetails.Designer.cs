namespace DBproject.Views.UserControls
{
    partial class BalanceDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startingValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.expenseValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.incomeValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closingValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.showMore = new System.Windows.Forms.Button();
            this.month = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.month);
            this.panel1.Controls.Add(this.showMore);
            this.panel1.Controls.Add(this.closingValue);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.startingValue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.expenseValue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.incomeValue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 297);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(21, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 2);
            this.panel2.TabIndex = 6;
            // 
            // startingValue
            // 
            this.startingValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startingValue.AutoSize = true;
            this.startingValue.BackColor = System.Drawing.Color.Transparent;
            this.startingValue.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingValue.ForeColor = System.Drawing.Color.DimGray;
            this.startingValue.Location = new System.Drawing.Point(227, 51);
            this.startingValue.Name = "startingValue";
            this.startingValue.Size = new System.Drawing.Size(54, 19);
            this.startingValue.TabIndex = 5;
            this.startingValue.Text = "10000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(21, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Starting Balance:";
            // 
            // expenseValue
            // 
            this.expenseValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expenseValue.AutoSize = true;
            this.expenseValue.BackColor = System.Drawing.Color.Transparent;
            this.expenseValue.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseValue.ForeColor = System.Drawing.Color.Firebrick;
            this.expenseValue.Location = new System.Drawing.Point(227, 133);
            this.expenseValue.Name = "expenseValue";
            this.expenseValue.Size = new System.Drawing.Size(54, 19);
            this.expenseValue.TabIndex = 3;
            this.expenseValue.Text = "10000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(21, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expenses:";
            // 
            // incomeValue
            // 
            this.incomeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.incomeValue.AutoSize = true;
            this.incomeValue.BackColor = System.Drawing.Color.Transparent;
            this.incomeValue.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeValue.ForeColor = System.Drawing.Color.Green;
            this.incomeValue.Location = new System.Drawing.Point(227, 92);
            this.incomeValue.Name = "incomeValue";
            this.incomeValue.Size = new System.Drawing.Size(54, 19);
            this.incomeValue.TabIndex = 1;
            this.incomeValue.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(21, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income:";
            // 
            // closingValue
            // 
            this.closingValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closingValue.AutoSize = true;
            this.closingValue.BackColor = System.Drawing.Color.Transparent;
            this.closingValue.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closingValue.ForeColor = System.Drawing.Color.Black;
            this.closingValue.Location = new System.Drawing.Point(227, 190);
            this.closingValue.Name = "closingValue";
            this.closingValue.Size = new System.Drawing.Size(54, 19);
            this.closingValue.TabIndex = 8;
            this.closingValue.Text = "10000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Current Balance:";
            // 
            // showMore
            // 
            this.showMore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showMore.BackColor = System.Drawing.Color.Transparent;
            this.showMore.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.showMore.FlatAppearance.BorderSize = 2;
            this.showMore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.showMore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.showMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMore.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMore.ForeColor = System.Drawing.Color.DarkRed;
            this.showMore.Location = new System.Drawing.Point(35, 253);
            this.showMore.Name = "showMore";
            this.showMore.Size = new System.Drawing.Size(247, 29);
            this.showMore.TabIndex = 9;
            this.showMore.Text = "View Complete Analysis";
            this.showMore.UseVisualStyleBackColor = false;
            this.showMore.Click += new System.EventHandler(this.showMore_Click);
            // 
            // month
            // 
            this.month.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.month.AutoSize = true;
            this.month.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.Location = new System.Drawing.Point(100, 17);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(117, 19);
            this.month.TabIndex = 10;
            this.month.Text = "AUGUST, 2019";
            // 
            // BalanceDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.panel1);
            this.Name = "BalanceDetails";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(319, 299);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label expenseValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label incomeValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label startingValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closingValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button showMore;
        private System.Windows.Forms.Label month;
    }
}
