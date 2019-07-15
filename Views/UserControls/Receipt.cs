﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBproject.Model;
using DBproject.Views;
using DBproject.Controller;

namespace DBproject.Views.UserControls
{
    public partial class Receipt : UserControl
    {
        IncomingTransaction transaction;
        ControllerModule controller;
        public Receipt(Flat flat, Building apatment)
        {
            InitializeComponent();

            if(flat.getDues() > 0)
            {

                setValues(flat);
                transaction = new IncomingTransaction(receiptTrID.Text, apatment, flat, (int)receiptAmount.Value, reciptDateTime.Value, flat, receiptMonthBox.SelectedItem.ToString());

            }

            else
            {

                controller = new TransactionModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, Util.Tables.TABLE_INCOMING_TRANSACTIONS.TABLE_NAME);
                controller.showPaidReceipt(this, receiptMonthBox.SelectedItem.ToString(), Convert.ToInt32(receiptFlatNumber.Text));
            }


        }



        private void setValues(Flat flat)
        {
            receiptMonthBox.Items.AddRange(new object[] { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER" });
            receiptTrID.Text = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
            receiptName.Text = flat.getNameOfResident();
            receiptFlatNumber.Text = flat.getFlatNumber().ToString();
            receiptAmount.Value = Convert.ToDecimal(flat.getMonthlyFees());
            receiptMonthBox.SelectedIndex = DateTime.Now.Month;

        }

       

        private void confirmButton1_Click_1(object sender, EventArgs e)
        {
            controller = new TransactionModule(Util.CONNECTION_DETAILS.CONNECITION_STRING, Util.Tables.TABLE_INCOMING_TRANSACTIONS.TABLE_NAME);
            controller.confirmTransaction(this.transaction);

            controller = new MainScreenController(Util.CONNECTION_DETAILS.CONNECITION_STRING, Util.Tables.TABLE_FLATS.TBL_FLATS);
            controller.showDetailsPanel(this.transaction.getPaidBy(), (Income)this.Parent);
            this.Dispose();
           // receiptpanel1.Visible = false;
        }

        private void CancelButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setValues(DateTime date, string name, string trID, int flatNumber, int amount, string month)
        {
            receiptAmount.ReadOnly = true;
            receiptAmount.BackColor = Color.LightGray;
            receiptAmount.Value = amount;


            receiptName.ReadOnly = true;
            receiptName.BackColor = Color.LightGray;
            receiptName.Text = name;

            
            receiptFlatNumber.ReadOnly = true;
            receiptFlatNumber.BackColor = Color.LightGray;
            receiptFlatNumber.Text = flatNumber.ToString();

            receiptMonthBox.Enabled = false;
            receiptMonthBox.BackColor = Color.LightGray;
            receiptMonthBox.SelectedValue = month;

            reciptDateTime.Enabled = false;
            reciptDateTime.CalendarMonthBackground = Color.LightGray;
            reciptDateTime.Value = date;

        }
    }
}
