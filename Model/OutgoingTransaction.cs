﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Model
{
    public class OutgoingTransaction
    {
        string trID;
        ExpenseDetails expense;
        DateTime datePaid;
        Flat paidBy;

        public OutgoingTransaction(string trID, ExpenseDetails expense, DateTime date, Flat paidBy)
        {
            this.trID = trID;
            this.expense = expense;
            this.datePaid = date;
            this.paidBy = paidBy;
        }

        public OutgoingTransaction(string trID, ExpenseDetails expense, DateTime date)
        {
            this.trID = trID;
            this.expense = expense;
            this.datePaid = date;
            
        }

        public string getTrID()
        {
            return this.trID;
        }

        public ExpenseDetails getExpense()
        {
            return this.expense;
        }

        public DateTime getDate()
        {
            return this.datePaid;
        }

        public Flat getPaidBy()
        {
            return this.paidBy;
        }

        public void setDate(DateTime date)
        {
            this.datePaid = date;
        }
    }
}
