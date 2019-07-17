using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBproject.Views.UserControls;

namespace DBproject.Model
{
    public enum ExpenseStatus
    {
        Paid,
        Unpaid
    }

    public enum ExpenseType
    {
        Regular,
        Other
    }

    public class ExpenseDetails
    {
        Building apartment;
        Guid expenseID;
        string expenseName;
        int expenseAmount;
        ExpenseType type;
        ExpenseStatus status;
        string month;
        int year;

        public ExpenseDetails(Building apartment, string expenseName, int amount, ExpenseType type, ExpenseStatus status, string month, int year)
        {
            expenseID = Guid.NewGuid();
            this.apartment = apartment;
            this.expenseName = expenseName;
            this.expenseAmount = amount;
            this.type = type;
            this.status = status;
            this.month = month;
            this.year = year;
            
            
        }


        public ExpenseDetails(string id, Building apartment, string expenseName, int amount, ExpenseType type, ExpenseStatus status, string month, int year)
        {
            expenseID = Guid.Parse(id);
            this.apartment = apartment;
            this.expenseName = expenseName;
            this.expenseAmount = amount;
            this.type = type;
            this.status = status;
            this.month = month;
            this.year = year;


        }

        public ExpenseDetails(ExpenseCard expense, Building apartment, string month, int year)
        {
            expenseID = Guid.NewGuid();
            this.apartment = apartment;
            this.expenseName = expense.getName();
         //   this.type = expense.getExpenseType();
           // this.status = expense.getStatus();
            this.month = month;
            this.year = year;
            this.expenseAmount = expense.getAmount();

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

        public int getAmount()
        {
            return this.expenseAmount;
        }

        public void setAmount(int amount)
        {
            this.expenseAmount = amount; 
        }

        

    }
}
