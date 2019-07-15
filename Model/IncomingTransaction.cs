﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Model
{
    class IncomingTransaction
    {
        String trID;

        Building apartment;

        Flat paidBy;

        int amount;

        DateTime date;

        Flat collectedBy;

        string forTheMonth;
        
        public IncomingTransaction()
        {
           
        }

        public IncomingTransaction(String trID, Building apartment, Flat paidBy, int amount, DateTime date, Flat collectedBy, string forTheMonth)
        {
            this.trID = trID;
            this.apartment = apartment;
            this.paidBy = paidBy;
            this.amount = amount;
            this.date = date;
            this.collectedBy = collectedBy;
            this.forTheMonth = forTheMonth;

        }

        public String getTrID()
        {
            return this.trID;
        }

        

        public Building getApartment()
        {
            return this.apartment;
        }

        public Flat getPaidBy()
        {
            return this.paidBy;
        }

        public int getAmount()
        {
            return this.amount;
        }

        public DateTime getDate()
        {
            return this.date;
        }

        public Flat getCollectedBy()
        {
            return this.collectedBy;
        }

        public string getMonth()
        {
            return this.forTheMonth;
        }

    }
}
