namespace DBproject.Views.UserControls
{
    partial class Anaytics
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.monthPanel = new System.Windows.Forms.Panel();
            this.monthInnerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AnalyticsTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.incomeChartPanel = new System.Windows.Forms.Panel();
            this.incomeTitle = new System.Windows.Forms.Label();
            this.receivedLegend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.receivedValue = new System.Windows.Forms.Label();
            this.notReceivedValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.remainingLegend = new System.Windows.Forms.Button();
            this.totalIncomeValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.expenseChartPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalExpensesValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.unpaidValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.unpaidLegend = new System.Windows.Forms.Button();
            this.paidValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.paidLegend = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.monthPanel.SuspendLayout();
            this.monthInnerPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.Silver;
            this.titlePanel.Controls.Add(this.flowLayoutPanel3);
            this.titlePanel.Controls.Add(this.monthPanel);
            this.titlePanel.Controls.Add(this.AnalyticsTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(975, 50);
            this.titlePanel.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.yearLabel);
            this.flowLayoutPanel3.Controls.Add(this.yearComboBox);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(517, 11);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(148, 31);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // yearLabel
            // 
            this.yearLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(3, 7);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(46, 19);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "Year:";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yearComboBox
            // 
            this.yearComboBox.BackColor = System.Drawing.Color.White;
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearComboBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(55, 3);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(78, 27);
            this.yearComboBox.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel4.TabIndex = 2;
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
            // AnalyticsTitle
            // 
            this.AnalyticsTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AnalyticsTitle.AutoSize = true;
            this.AnalyticsTitle.BackColor = System.Drawing.Color.Transparent;
            this.AnalyticsTitle.Font = new System.Drawing.Font("Lato Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalyticsTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.AnalyticsTitle.Location = new System.Drawing.Point(11, 6);
            this.AnalyticsTitle.Name = "AnalyticsTitle";
            this.AnalyticsTitle.Size = new System.Drawing.Size(208, 42);
            this.AnalyticsTitle.TabIndex = 3;
            this.AnalyticsTitle.Text = "ANALYTICS";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 379);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Lato Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(184, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transactions:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 78);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // 
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.totalIncomeValue);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.notReceivedValue);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.remainingLegend);
            this.splitContainer1.Panel1.Controls.Add(this.receivedValue);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.receivedLegend);
            this.splitContainer1.Panel1.Controls.Add(this.incomeTitle);
            this.splitContainer1.Panel1.Controls.Add(this.incomeChartPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.totalExpensesValue);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.unpaidValue);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.unpaidLegend);
            this.splitContainer1.Panel2.Controls.Add(this.paidValue);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.paidLegend);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.expenseChartPanel);
            this.splitContainer1.Size = new System.Drawing.Size(969, 298);
            this.splitContainer1.SplitterDistance = 472;
            this.splitContainer1.TabIndex = 2;
            // 
            // incomeChartPanel
            // 
            this.incomeChartPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.incomeChartPanel.Location = new System.Drawing.Point(194, 0);
            this.incomeChartPanel.Name = "incomeChartPanel";
            this.incomeChartPanel.Size = new System.Drawing.Size(278, 298);
            this.incomeChartPanel.TabIndex = 0;
            this.incomeChartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.incomeChartPanel_Paint);
            // 
            // incomeTitle
            // 
            this.incomeTitle.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeTitle.Location = new System.Drawing.Point(1, 0);
            this.incomeTitle.Name = "incomeTitle";
            this.incomeTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.incomeTitle.Size = new System.Drawing.Size(119, 34);
            this.incomeTitle.TabIndex = 2;
            this.incomeTitle.Text = "Incomes:";
            this.incomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // receivedLegend
            // 
            this.receivedLegend.BackColor = System.Drawing.Color.Brown;
            this.receivedLegend.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.receivedLegend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receivedLegend.Location = new System.Drawing.Point(17, 56);
            this.receivedLegend.Name = "receivedLegend";
            this.receivedLegend.Size = new System.Drawing.Size(19, 10);
            this.receivedLegend.TabIndex = 3;
            this.receivedLegend.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "RECEIVED";
            // 
            // receivedValue
            // 
            this.receivedValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.receivedValue.AutoSize = true;
            this.receivedValue.Font = new System.Drawing.Font("Lato Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedValue.ForeColor = System.Drawing.Color.Brown;
            this.receivedValue.Location = new System.Drawing.Point(126, 54);
            this.receivedValue.Name = "receivedValue";
            this.receivedValue.Size = new System.Drawing.Size(64, 15);
            this.receivedValue.TabIndex = 5;
            this.receivedValue.Text = "25 ( 16,00)";
            // 
            // notReceivedValue
            // 
            this.notReceivedValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notReceivedValue.AutoSize = true;
            this.notReceivedValue.Font = new System.Drawing.Font("Lato Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notReceivedValue.ForeColor = System.Drawing.Color.Gray;
            this.notReceivedValue.Location = new System.Drawing.Point(126, 88);
            this.notReceivedValue.Name = "notReceivedValue";
            this.notReceivedValue.Size = new System.Drawing.Size(64, 15);
            this.notReceivedValue.TabIndex = 8;
            this.notReceivedValue.Text = "25 ( 16,00)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "REMAINING";
            // 
            // remainingLegend
            // 
            this.remainingLegend.BackColor = System.Drawing.Color.Silver;
            this.remainingLegend.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.remainingLegend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remainingLegend.Location = new System.Drawing.Point(17, 90);
            this.remainingLegend.Name = "remainingLegend";
            this.remainingLegend.Size = new System.Drawing.Size(19, 10);
            this.remainingLegend.TabIndex = 6;
            this.remainingLegend.UseVisualStyleBackColor = false;
            // 
            // totalIncomeValue
            // 
            this.totalIncomeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalIncomeValue.AutoSize = true;
            this.totalIncomeValue.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIncomeValue.ForeColor = System.Drawing.Color.Black;
            this.totalIncomeValue.Location = new System.Drawing.Point(109, 268);
            this.totalIncomeValue.Name = "totalIncomeValue";
            this.totalIncomeValue.Size = new System.Drawing.Size(83, 19);
            this.totalIncomeValue.TabIndex = 10;
            this.totalIncomeValue.Text = "25 ( 16,00)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "TOTAL";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(13, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 2);
            this.panel2.TabIndex = 11;
            // 
            // expenseChartPanel
            // 
            this.expenseChartPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.expenseChartPanel.Location = new System.Drawing.Point(215, 0);
            this.expenseChartPanel.Name = "expenseChartPanel";
            this.expenseChartPanel.Size = new System.Drawing.Size(278, 298);
            this.expenseChartPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(18, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 2);
            this.panel3.TabIndex = 21;
            // 
            // totalExpensesValue
            // 
            this.totalExpensesValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalExpensesValue.AutoSize = true;
            this.totalExpensesValue.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExpensesValue.ForeColor = System.Drawing.Color.Black;
            this.totalExpensesValue.Location = new System.Drawing.Point(114, 268);
            this.totalExpensesValue.Name = "totalExpensesValue";
            this.totalExpensesValue.Size = new System.Drawing.Size(83, 19);
            this.totalExpensesValue.TabIndex = 20;
            this.totalExpensesValue.Text = "25 ( 16,00)";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "TOTAL";
            // 
            // unpaidValue
            // 
            this.unpaidValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unpaidValue.AutoSize = true;
            this.unpaidValue.Font = new System.Drawing.Font("Lato Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpaidValue.ForeColor = System.Drawing.Color.Gray;
            this.unpaidValue.Location = new System.Drawing.Point(131, 88);
            this.unpaidValue.Name = "unpaidValue";
            this.unpaidValue.Size = new System.Drawing.Size(64, 15);
            this.unpaidValue.TabIndex = 18;
            this.unpaidValue.Text = "25 ( 16,00)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "UNPAID";
            // 
            // unpaidLegend
            // 
            this.unpaidLegend.BackColor = System.Drawing.Color.Silver;
            this.unpaidLegend.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.unpaidLegend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unpaidLegend.Location = new System.Drawing.Point(22, 90);
            this.unpaidLegend.Name = "unpaidLegend";
            this.unpaidLegend.Size = new System.Drawing.Size(19, 10);
            this.unpaidLegend.TabIndex = 16;
            this.unpaidLegend.UseVisualStyleBackColor = false;
            // 
            // paidValue
            // 
            this.paidValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paidValue.AutoSize = true;
            this.paidValue.Font = new System.Drawing.Font("Lato Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidValue.ForeColor = System.Drawing.Color.Brown;
            this.paidValue.Location = new System.Drawing.Point(131, 54);
            this.paidValue.Name = "paidValue";
            this.paidValue.Size = new System.Drawing.Size(64, 15);
            this.paidValue.TabIndex = 15;
            this.paidValue.Text = "25 ( 16,00)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "PAID";
            // 
            // paidLegend
            // 
            this.paidLegend.BackColor = System.Drawing.Color.Brown;
            this.paidLegend.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.paidLegend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paidLegend.Location = new System.Drawing.Point(22, 56);
            this.paidLegend.Name = "paidLegend";
            this.paidLegend.Size = new System.Drawing.Size(19, 10);
            this.paidLegend.TabIndex = 13;
            this.paidLegend.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 11);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(119, 34);
            this.label11.TabIndex = 12;
            this.label11.Text = "Incomes:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Anaytics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.titlePanel);
            this.Name = "Anaytics";
            this.Size = new System.Drawing.Size(975, 638);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.monthPanel.ResumeLayout(false);
            this.monthInnerPanel.ResumeLayout(false);
            this.monthInnerPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel monthPanel;
        private System.Windows.Forms.FlowLayoutPanel monthInnerPanel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label AnalyticsTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label totalIncomeValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label notReceivedValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button remainingLegend;
        private System.Windows.Forms.Label receivedValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button receivedLegend;
        private System.Windows.Forms.Label incomeTitle;
        private System.Windows.Forms.Panel incomeChartPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalExpensesValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label unpaidValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button unpaidLegend;
        private System.Windows.Forms.Label paidValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button paidLegend;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel expenseChartPanel;
    }
}
