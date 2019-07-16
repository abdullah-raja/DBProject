using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Model
{
    class OutgoingTransaction
    {
        string trID;
        Expense expense;
        DateTime datePaid;
        Flat paidBy;

        public OutgoingTransaction(string trID, Expense expense, DateTime date, Flat paidBy)
        {
            this.trID = trID;
            this.expense = expense;
            this.datePaid = date;
            this.paidBy = paidBy;
        }

        public string getTrID()
        {
            return this.trID;
        }

        public Expense getExpense()
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
    }
}
