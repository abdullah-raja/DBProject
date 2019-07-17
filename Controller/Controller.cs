using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBproject.Model;
using DBproject.Views;
using DBproject.Views.UserControls;
using System.Data.SqlClient;
using DBproject.Util.StoredProcedures;

namespace DBproject.Controller
{
    abstract class ControllerModule
    {
        protected string TABLE_NAME;
        

        protected string connectionString;
        protected SqlConnection connection;

        public ControllerModule()
        {

        }

        public ControllerModule(string connectionString, string TableName)
        {
            this.TABLE_NAME = TableName;
            try
            {
                this.connectionString = connectionString;
                this.connection = new SqlConnection(this.connectionString);
            }

            catch (Exception es)
            {

            }

        }

        virtual public bool signUp(Model.User user, Views.SignUp view)
        {
            return false;
        }

        virtual public void signIn(Model.User user, Views.SignUp view, string enteredEmail, string enteredPassword, Model.Building apartment)
        {

        }


        virtual public void createBuilding(Model.Building building, Views.SignUp view, Model.User user, int adminFlat
            )
        {
            

        }

        virtual public void showDetailsPanel(Flat flat, Views.UserControls.Income view)
        {

        }

        virtual public void updateDetailsPanel(Flat flat)
        {

        }

        virtual public void confirmTransaction(IncomingTransaction transaction)
        {
            
        }

        virtual public void sendEmail(string email, Receipt receipt)
        {

        }

        virtual public void showPaidReceipt(Receipt recipt, string month, int flatNumber)
        {

        }

        virtual public void setMonths(Income view, int year)
        {

        }

        virtual public void setMonths(Expense view, int year)
        {

        }

        virtual public void setYears(Income view)
        {

        }

        virtual public void setYears(Expense view)
        {

        }

        virtual public void updateBalance(Building apartment, MainScreen view)
        {

        }

        virtual public void newMonthStarted(Income view)
        {

        }

        virtual public void addExpense(Expense view, bool regularActive, ExpenseDetails expDetails)
        {

        }

        virtual public void addExpense(ExpenseDetails expDetails)
        {

        }

        virtual public void getAllExpense(List<ExpenseCard> expenses, Building apartment, string month, int year)
        {

        }

        virtual public void confirmPayment(OutgoingTransaction transaction, ExpenseCard expense)
        {

        }
    }
}
