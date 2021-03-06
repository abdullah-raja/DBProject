﻿namespace DBproject.Views.UserControls
{
    partial class Receipt
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
            this.receiptLabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.reciptDateTime = new System.Windows.Forms.DateTimePicker();
            this.recievelabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.receiptTrID = new System.Windows.Forms.TextBox();
            this.receiptFlatNumber = new System.Windows.Forms.MaskedTextBox();
            this.amountlabel1 = new System.Windows.Forms.Label();
            this.monthlabel2 = new System.Windows.Forms.Label();
            this.receiptAmount = new System.Windows.Forms.NumericUpDown();
            this.confirmButton1 = new XanderUI.XUIButton();
            this.agreedcheckBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receiptName = new System.Windows.Forms.MaskedTextBox();
            this.CancelButton1 = new XanderUI.XUIButton();
            this.receiptpanel1 = new System.Windows.Forms.Panel();
            this.receiptMonthBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.receiptAmount)).BeginInit();
            this.receiptpanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // receiptLabel
            // 
            this.receiptLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.BackColor = System.Drawing.Color.DarkRed;
            this.receiptLabel.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.ForeColor = System.Drawing.Color.White;
            this.receiptLabel.Location = new System.Drawing.Point(321, 20);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(110, 29);
            this.receiptLabel.TabIndex = 8;
            this.receiptLabel.Text = "RECEIPT";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.BackColor = System.Drawing.Color.Transparent;
            this.datelabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.ForeColor = System.Drawing.Color.DarkRed;
            this.datelabel.Location = new System.Drawing.Point(41, 66);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(50, 19);
            this.datelabel.TabIndex = 9;
            this.datelabel.Text = "DATE";
            // 
            // reciptDateTime
            // 
            this.reciptDateTime.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reciptDateTime.Location = new System.Drawing.Point(44, 88);
            this.reciptDateTime.Name = "reciptDateTime";
            this.reciptDateTime.Size = new System.Drawing.Size(125, 27);
            this.reciptDateTime.TabIndex = 10;
            // 
            // recievelabel
            // 
            this.recievelabel.AutoSize = true;
            this.recievelabel.BackColor = System.Drawing.Color.Transparent;
            this.recievelabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recievelabel.ForeColor = System.Drawing.Color.DarkRed;
            this.recievelabel.Location = new System.Drawing.Point(482, 142);
            this.recievelabel.Name = "recievelabel";
            this.recievelabel.Size = new System.Drawing.Size(58, 19);
            this.recievelabel.TabIndex = 11;
            this.recievelabel.Text = "FLAT #";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.Color.Transparent;
            this.IDlabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.IDlabel.Location = new System.Drawing.Point(479, 66);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(147, 19);
            this.IDlabel.TabIndex = 12;
            this.IDlabel.Text = "TRANSACTION ID:";
            // 
            // receiptTrID
            // 
            this.receiptTrID.BackColor = System.Drawing.Color.LightGray;
            this.receiptTrID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiptTrID.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptTrID.Location = new System.Drawing.Point(486, 85);
            this.receiptTrID.Name = "receiptTrID";
            this.receiptTrID.ReadOnly = true;
            this.receiptTrID.Size = new System.Drawing.Size(157, 26);
            this.receiptTrID.TabIndex = 13;
            this.receiptTrID.Text = "0001";
            // 
            // receiptFlatNumber
            // 
            this.receiptFlatNumber.BackColor = System.Drawing.Color.LightGray;
            this.receiptFlatNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiptFlatNumber.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptFlatNumber.Location = new System.Drawing.Point(486, 164);
            this.receiptFlatNumber.Name = "receiptFlatNumber";
            this.receiptFlatNumber.ReadOnly = true;
            this.receiptFlatNumber.Size = new System.Drawing.Size(157, 26);
            this.receiptFlatNumber.TabIndex = 14;
            this.receiptFlatNumber.Text = "112";
            // 
            // amountlabel1
            // 
            this.amountlabel1.AutoSize = true;
            this.amountlabel1.BackColor = System.Drawing.Color.Transparent;
            this.amountlabel1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.amountlabel1.Location = new System.Drawing.Point(41, 208);
            this.amountlabel1.Name = "amountlabel1";
            this.amountlabel1.Size = new System.Drawing.Size(165, 19);
            this.amountlabel1.TabIndex = 15;
            this.amountlabel1.Text = "AMOUNT RECIEVED:";
            // 
            // monthlabel2
            // 
            this.monthlabel2.AutoSize = true;
            this.monthlabel2.BackColor = System.Drawing.Color.Transparent;
            this.monthlabel2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.monthlabel2.Location = new System.Drawing.Point(482, 208);
            this.monthlabel2.Name = "monthlabel2";
            this.monthlabel2.Size = new System.Drawing.Size(75, 19);
            this.monthlabel2.TabIndex = 16;
            this.monthlabel2.Text = "MONTH:";
            // 
            // receiptAmount
            // 
            this.receiptAmount.BackColor = System.Drawing.Color.LightGray;
            this.receiptAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiptAmount.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptAmount.Location = new System.Drawing.Point(44, 230);
            this.receiptAmount.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.receiptAmount.Name = "receiptAmount";
            this.receiptAmount.ReadOnly = true;
            this.receiptAmount.Size = new System.Drawing.Size(136, 23);
            this.receiptAmount.TabIndex = 18;
            // 
            // confirmButton1
            // 
            this.confirmButton1.BackgroundColor = System.Drawing.Color.DarkRed;
            this.confirmButton1.ButtonImage = null;
            this.confirmButton1.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.confirmButton1.ButtonText = "CONFIRM";
            this.confirmButton1.ClickBackColor = System.Drawing.Color.White;
            this.confirmButton1.ClickTextColor = System.Drawing.Color.DarkRed;
            this.confirmButton1.CornerRadius = 5;
            this.confirmButton1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.confirmButton1.HoverBackgroundColor = System.Drawing.Color.Brown;
            this.confirmButton1.HoverTextColor = System.Drawing.Color.White;
            this.confirmButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.confirmButton1.Location = new System.Drawing.Point(222, 290);
            this.confirmButton1.Name = "confirmButton1";
            this.confirmButton1.Size = new System.Drawing.Size(134, 43);
            this.confirmButton1.TabIndex = 27;
            this.confirmButton1.TextColor = System.Drawing.Color.White;
            this.confirmButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.confirmButton1.Click += new System.EventHandler(this.confirmButton1_Click_1);
            // 
            // agreedcheckBox1
            // 
            this.agreedcheckBox1.AutoSize = true;
            this.agreedcheckBox1.BackColor = System.Drawing.Color.DarkRed;
            this.agreedcheckBox1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreedcheckBox1.ForeColor = System.Drawing.Color.White;
            this.agreedcheckBox1.Location = new System.Drawing.Point(45, 270);
            this.agreedcheckBox1.Name = "agreedcheckBox1";
            this.agreedcheckBox1.Size = new System.Drawing.Size(68, 17);
            this.agreedcheckBox1.TabIndex = 28;
            this.agreedcheckBox1.Text = "Agreed?";
            this.agreedcheckBox1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(41, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "NAME:";
            // 
            // receiptName
            // 
            this.receiptName.BackColor = System.Drawing.Color.LightGray;
            this.receiptName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiptName.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptName.Location = new System.Drawing.Point(45, 164);
            this.receiptName.Name = "receiptName";
            this.receiptName.ReadOnly = true;
            this.receiptName.Size = new System.Drawing.Size(157, 26);
            this.receiptName.TabIndex = 30;
            this.receiptName.Text = "SARIM";
            // 
            // CancelButton1
            // 
            this.CancelButton1.BackgroundColor = System.Drawing.Color.DarkRed;
            this.CancelButton1.ButtonImage = null;
            this.CancelButton1.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.CancelButton1.ButtonText = "CANCEL";
            this.CancelButton1.ClickBackColor = System.Drawing.Color.White;
            this.CancelButton1.ClickTextColor = System.Drawing.Color.DarkRed;
            this.CancelButton1.CornerRadius = 5;
            this.CancelButton1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.CancelButton1.HoverBackgroundColor = System.Drawing.Color.Brown;
            this.CancelButton1.HoverTextColor = System.Drawing.Color.White;
            this.CancelButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.CancelButton1.Location = new System.Drawing.Point(375, 290);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(134, 43);
            this.CancelButton1.TabIndex = 31;
            this.CancelButton1.TextColor = System.Drawing.Color.White;
            this.CancelButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton1_Click_1);
            // 
            // receiptpanel1
            // 
            this.receiptpanel1.BackColor = System.Drawing.Color.LightGray;
            this.receiptpanel1.Controls.Add(this.receiptMonthBox);
            this.receiptpanel1.Controls.Add(this.CancelButton1);
            this.receiptpanel1.Controls.Add(this.receiptName);
            this.receiptpanel1.Controls.Add(this.label1);
            this.receiptpanel1.Controls.Add(this.agreedcheckBox1);
            this.receiptpanel1.Controls.Add(this.confirmButton1);
            this.receiptpanel1.Controls.Add(this.receiptAmount);
            this.receiptpanel1.Controls.Add(this.monthlabel2);
            this.receiptpanel1.Controls.Add(this.amountlabel1);
            this.receiptpanel1.Controls.Add(this.receiptFlatNumber);
            this.receiptpanel1.Controls.Add(this.receiptTrID);
            this.receiptpanel1.Controls.Add(this.IDlabel);
            this.receiptpanel1.Controls.Add(this.recievelabel);
            this.receiptpanel1.Controls.Add(this.reciptDateTime);
            this.receiptpanel1.Controls.Add(this.datelabel);
            this.receiptpanel1.Controls.Add(this.receiptLabel);
            this.receiptpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptpanel1.Location = new System.Drawing.Point(0, 0);
            this.receiptpanel1.Name = "receiptpanel1";
            this.receiptpanel1.Size = new System.Drawing.Size(756, 352);
            this.receiptpanel1.TabIndex = 12;
            // 
            // receiptMonthBox
            // 
            this.receiptMonthBox.BackColor = System.Drawing.Color.LightGray;
            this.receiptMonthBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiptMonthBox.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptMonthBox.Location = new System.Drawing.Point(486, 230);
            this.receiptMonthBox.Name = "receiptMonthBox";
            this.receiptMonthBox.ReadOnly = true;
            this.receiptMonthBox.Size = new System.Drawing.Size(157, 26);
            this.receiptMonthBox.TabIndex = 32;
            this.receiptMonthBox.Text = "112";
            // 
            // Receipt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.receiptpanel1);
            this.Name = "Receipt";
            this.Size = new System.Drawing.Size(756, 352);
            ((System.ComponentModel.ISupportInitialize)(this.receiptAmount)).EndInit();
            this.receiptpanel1.ResumeLayout(false);
            this.receiptpanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.DateTimePicker reciptDateTime;
        private System.Windows.Forms.Label recievelabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox receiptTrID;
        private System.Windows.Forms.MaskedTextBox receiptFlatNumber;
        private System.Windows.Forms.Label amountlabel1;
        private System.Windows.Forms.Label monthlabel2;
        private System.Windows.Forms.NumericUpDown receiptAmount;
        private XanderUI.XUIButton confirmButton1;
        private System.Windows.Forms.CheckBox agreedcheckBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox receiptName;
        private XanderUI.XUIButton CancelButton1;
        private System.Windows.Forms.Panel receiptpanel1;
        private System.Windows.Forms.MaskedTextBox receiptMonthBox;
    }
}
