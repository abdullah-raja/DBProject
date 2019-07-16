using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Model
{
    enum ExpenseStatus
    {
        Paid,
        Unpaid
    }

    enum ExpenseType
    {
        Regular,
        Other
    }

    class Expense
    {
        Building apartment;
        Guid expenseID;
        string expenseName;
        int expenseAmount;
        ExpenseType type;
        ExpenseStatus status;
        string month;
        int year;

        public Expense(Building apartment, string expenseName, ExpenseType type, ExpenseStatus status, string month, int year)
        {
            expenseID = Guid.NewGuid();
            this.apartment = apartment;
            this.expenseName = expenseName;
            this.type = type;
            this.status = status;
            this.month = month;
            this.year = year;
            
        }

        public string getStringID()
        {
            return this.expenseID.ToString();
        }

        public Guid getExpenseID()
        {
            return this.expenseID;
        }

        public Building getApartment()
        {
            return this.apartment;
        }

        public string getExpenseName()
        {
            return this.expenseName;
        }

        public void setExpenseName(string name)
        {
            this.expenseName = name;

        }

        public ExpenseType GetExpenseType()
        {
            return this.type;
        }

        public void setExpenseType(ExpenseType type)
        {
            this.type = type;
        }

        public ExpenseStatus GetExpenseStatus()
        {
            return this.status;
        }

        public void setExpenseStatus(ExpenseStatus status)
        {
            this.status = status;
        }

        public string getMonth()
        {
            return this.month;
        }

        public void setMonth(string month)
        {
            this.month = month;
        }

        public int getYear()
        {
            return this.year;
        }

        public void setYear(int year)
        {
            this.year = year;
        }


        

    }
}
