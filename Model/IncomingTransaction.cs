using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Model
{
    class IncomingTransaction
    {
        Guid trID
        {
            get
            {
                return this.trID;
            }
            set
            {
                this.trID = value;
            }
        }
        Building apartment
        {
            get
            {
                return this.apartment;
            }

            set
            {
                this.apartment = value;
            }

        }
        Flat paidBy
        {
            get
            {
                return this.paidBy;
            }

            set
            {
                this.paidBy = value;
            }
        }
        int amount
        {
            get
            {
                return this.amount;
            }

            set
            {
                this.amount = value;
            }
        }
        DateTime date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }
        Flat collectedBy
        {
            get
            {
                return this.collectedBy;
            }

            set
            {
                this.collectedBy = value;
            }
        }
        string forTheMonth
        {
            get
            {
                return this.forTheMonth;
            }

            set
            {
                this.forTheMonth = value;
            }
        }

        public IncomingTransaction()
        {

        }

        public IncomingTransaction(Guid trID, Building apartment, Flat paidBy, int amount, DateTime date, Flat collectedBy, string forTheMonth)
        {
            this.trID = trID;
            this.apartment = apartment;
            this.paidBy = paidBy;
            this.amount = amount;
            this.date = date;
            this.collectedBy = collectedBy;
            this.forTheMonth = forTheMonth;

        }
    }
}
