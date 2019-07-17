using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBproject.Views.UserControls;
using DBproject.Model;
using System.Data.SqlClient;
using DBproject.Util.StoredProcedures;

namespace DBproject.Controller
{
    class ExpenseModule : ControllerModule
    {
        public ExpenseModule(string connectionString, string TableName) : base(connectionString, TableName)
        {
            
        }

        public override void addExpense(Expense view, bool regularActive, ExpenseDetails expDetails)
        {
            
        }

        public override void addExpense(ExpenseDetails expDetails)
        {
            SqlCommand insertCommand = new SqlCommand(INSERT_EXPENSE_SP.SP_NAME, connection);
            insertCommand.CommandType = System.Data.CommandType.StoredProcedure;
            insertCommand.Parameters.Add(new SqlParameter(INSERT_EXPENSE_SP.ID_PARAM, expDetails.getExpenseID()));
            insertCommand.Parameters.Add(new SqlParameter(INSERT_EXPENSE_SP.AMOUNT_PARAM, expDetails.getAmount()));
            insertCommand.Parameters.Add(new SqlParameter(INSERT_EXPENSE_SP.APARTMENT_ID_PARAM, Guid.Parse(expDetails.getApartment().getID())));
            
            insertCommand.Parameters.Add(new SqlParameter(INSERT_EXPENSE_SP.MONTH_PARAM, expDetails.getMonth()));
            insertCommand.Parameters.Add(new SqlParameter(INSERT_EXPENSE_SP.NAME_PARAM, expDetails.getExpenseName()));
            insertCommand.Parameters.Add(new SqlParameter(INSERT_EXPENSE_SP.STATUS_PARAM, expDetails.GetExpenseStatus().ToString()));
            insertCommand.Parameters.Add(new SqlParameter(INSERT_EXPENSE_SP.TYPE_PARAM, expDetails.GetExpenseType().ToString()));
            insertCommand.Parameters.Add(new SqlParameter(INSERT_EXPENSE_SP.YEAR_PARAM, expDetails.getYear()));

            connection.Open();

            try
            {
                insertCommand.ExecuteNonQuery();
            }

            catch (SqlException e)
            {
                SqlCommand updateCommand = new SqlCommand(UPDATE_EXPENSE_DETAILS_SP.SP_NAME, connection);
                updateCommand.CommandType = System.Data.CommandType.StoredProcedure;
                updateCommand.Parameters.Add(new SqlParameter(UPDATE_EXPENSE_DETAILS_SP.AMOUNT_PARAM, expDetails.getAmount()));
                updateCommand.Parameters.Add(new SqlParameter(UPDATE_EXPENSE_DETAILS_SP.ID_PARAM, expDetails.getExpenseID()));
                updateCommand.Parameters.Add(new SqlParameter(UPDATE_EXPENSE_DETAILS_SP.NAME_PARAM, expDetails.getExpenseName()));

                updateCommand.ExecuteNonQuery();
                
            }

            finally
            {
                connection.Close();
            }


        }


    }
}
