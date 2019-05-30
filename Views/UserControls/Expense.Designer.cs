namespace DBproject.Views.UserControls
{
    partial class Expense
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense));
            this.topPanel = new System.Windows.Forms.Panel();
            this.othersExpenses = new System.Windows.Forms.Button();
            this.regularExpensesButton = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.monthPanel = new System.Windows.Forms.Panel();
            this.monthInnerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExpenseTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.triangle = new System.Windows.Forms.PictureBox();
            this.expensesList = new System.Windows.Forms.FlowLayoutPanel();
            this.addExpenseButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.otherExpensesList = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBar1 = new DBproject.Views.UserControls.SearchBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.topPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.monthPanel.SuspendLayout();
            this.monthInnerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Controls.Add(this.othersExpenses);
            this.topPanel.Controls.Add(this.regularExpensesButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 50);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(975, 60);
            this.topPanel.TabIndex = 1;
            // 
            // othersExpenses
            // 
            this.othersExpenses.BackColor = System.Drawing.Color.DarkRed;
            this.othersExpenses.FlatAppearance.BorderSize = 0;
            this.othersExpenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.othersExpenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.othersExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.othersExpenses.Font = new System.Drawing.Font("Lato Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersExpenses.ForeColor = System.Drawing.Color.White;
            this.othersExpenses.Location = new System.Drawing.Point(488, 0);
            this.othersExpenses.Name = "othersExpenses";
            this.othersExpenses.Size = new System.Drawing.Size(487, 60);
            this.othersExpenses.TabIndex = 1;
            this.othersExpenses.Text = "Other Expenses";
            this.othersExpenses.UseVisualStyleBackColor = false;
            this.othersExpenses.Click += new System.EventHandler(this.othersExpenses_Click);
            // 
            // regularExpensesButton
            // 
            this.regularExpensesButton.BackColor = System.Drawing.Color.DarkRed;
            this.regularExpensesButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.regularExpensesButton.FlatAppearance.BorderSize = 0;
            this.regularExpensesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.regularExpensesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.regularExpensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regularExpensesButton.Font = new System.Drawing.Font("Lato Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularExpensesButton.ForeColor = System.Drawing.Color.White;
            this.regularExpensesButton.Location = new System.Drawing.Point(0, 0);
            this.regularExpensesButton.Name = "regularExpensesButton";
            this.regularExpensesButton.Size = new System.Drawing.Size(487, 60);
            this.regularExpensesButton.TabIndex = 0;
            this.regularExpensesButton.Text = "Regular Expenses";
            this.regularExpensesButton.UseVisualStyleBackColor = false;
            this.regularExpensesButton.Click += new System.EventHandler(this.regularExpensesButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.Silver;
            this.titlePanel.Controls.Add(this.monthPanel);
            this.titlePanel.Controls.Add(this.ExpenseTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(975, 50);
            this.titlePanel.TabIndex = 0;
            // 
            // monthPanel
            // 
            this.monthPanel.Controls.Add(this.monthInnerPanel);
            this.monthPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.monthPanel.Location = new System.Drawing.Point(671, 0);
            this.monthPanel.Name = "monthPanel";
            this.monthPanel.Size = new System.Drawing.Size(304, 50);
            this.monthPanel.TabIndex = 4;
            // 
            // monthInnerPanel
            // 
            this.monthInnerPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.monthInnerPanel.BackColor = System.Drawing.Color.Transparent;
            this.monthInnerPanel.Controls.Add(this.MonthLabel);
            this.monthInnerPanel.Controls.Add(this.monthComboBox);
            this.monthInnerPanel.Controls.Add(this.flowLayoutPanel2);
            this.monthInnerPanel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthInnerPanel.Location = new System.Drawing.Point(11, 10);
            this.monthInnerPanel.Name = "monthInnerPanel";
            this.monthInnerPanel.Size = new System.Drawing.Size(250, 31);
            this.monthInnerPanel.TabIndex = 5;
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
            // ExpenseTitle
            // 
            this.ExpenseTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExpenseTitle.AutoSize = true;
            this.ExpenseTitle.BackColor = System.Drawing.Color.Transparent;
            this.ExpenseTitle.Font = new System.Drawing.Font("Lato Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.ExpenseTitle.Location = new System.Drawing.Point(11, 6);
            this.ExpenseTitle.Name = "ExpenseTitle";
            this.ExpenseTitle.Size = new System.Drawing.Size(189, 42);
            this.ExpenseTitle.TabIndex = 3;
            this.ExpenseTitle.Text = "EXPENSES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.searchBar1);
            this.panel1.Controls.Add(this.addExpenseButton);
            this.panel1.Controls.Add(this.expensesList);
            this.panel1.Controls.Add(this.topPanel);
            this.panel1.Controls.Add(this.titlePanel);
            this.panel1.Controls.Add(this.triangle);
            this.panel1.Controls.Add(this.otherExpensesList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(975, 638);
            this.panel1.MinimumSize = new System.Drawing.Size(975, 638);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 638);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // triangle
            // 
            this.triangle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.triangle.BackColor = System.Drawing.Color.Transparent;
            this.triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.triangle.Image = ((System.Drawing.Image)(resources.GetObject("triangle.Image")));
            this.triangle.Location = new System.Drawing.Point(228, 100);
            this.triangle.Margin = new System.Windows.Forms.Padding(0);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(30, 22);
            this.triangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.triangle.TabIndex = 2;
            this.triangle.TabStop = false;
            // 
            // expensesList
            // 
            this.expensesList.AutoScroll = true;
            this.expensesList.BackColor = System.Drawing.Color.Gainsboro;
            this.expensesList.Location = new System.Drawing.Point(0, 180);
            this.expensesList.Name = "expensesList";
            this.expensesList.Size = new System.Drawing.Size(975, 441);
            this.expensesList.TabIndex = 3;
            this.expensesList.Visible = false;
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.BackColor = System.Drawing.Color.DarkRed;
            this.addExpenseButton.FlatAppearance.BorderSize = 0;
            this.addExpenseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.addExpenseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.addExpenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpenseButton.Font = new System.Drawing.Font("Lato Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseButton.ForeColor = System.Drawing.Color.White;
            this.addExpenseButton.Location = new System.Drawing.Point(3, 128);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(144, 39);
            this.addExpenseButton.TabIndex = 0;
            this.addExpenseButton.Text = "Add Expense";
            this.addExpenseButton.UseVisualStyleBackColor = false;
            this.addExpenseButton.Click += new System.EventHandler(this.addExpenseButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // otherExpensesList
            // 
            this.otherExpensesList.AutoScroll = true;
            this.otherExpensesList.BackColor = System.Drawing.Color.Gainsboro;
            this.otherExpensesList.Location = new System.Drawing.Point(981, 122);
            this.otherExpensesList.Name = "otherExpensesList";
            this.otherExpensesList.Size = new System.Drawing.Size(975, 513);
            this.otherExpensesList.TabIndex = 4;
            // 
            // searchBar1
            // 
            this.searchBar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchBar1.Location = new System.Drawing.Point(469, 120);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(341, 47);
            this.searchBar1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "All"});
            this.comboBox1.DisplayMember = "dd";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Paid",
            "Unpaid"});
            this.comboBox1.Location = new System.Drawing.Point(804, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // Expense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(975, 638);
            this.MinimumSize = new System.Drawing.Size(975, 638);
            this.Name = "Expense";
            this.Size = new System.Drawing.Size(975, 638);
            this.Load += new System.EventHandler(this.Expense_Load);
            this.topPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.monthPanel.ResumeLayout(false);
            this.monthInnerPanel.ResumeLayout(false);
            this.monthInnerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button othersExpenses;
        private System.Windows.Forms.Button regularExpensesButton;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel monthPanel;
        private System.Windows.Forms.Label ExpenseTitle;
        private System.Windows.Forms.FlowLayoutPanel monthInnerPanel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox triangle;
        private System.Windows.Forms.FlowLayoutPanel expensesList;
        private System.Windows.Forms.Button addExpenseButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel otherExpensesList;
        private SearchBar searchBar1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
