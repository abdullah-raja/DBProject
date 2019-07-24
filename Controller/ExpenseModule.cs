using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBproject.Views.UserControls;
using DBproject.Model;
using System.Data.SqlClient;
using DBproject.Util.StoredProcedures;
using DBproject.Util.Tables;
using System.Windows.Forms;

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

        public override void getAllExpense(List<ExpenseCard> expenses, Building apartment, string month, int year)
        {
            string selectQuery = "SELECT * FROM " + TABLE_EXPENSES.TABLE_NAME +
                                " WHERE " + TABLE_EXPENSES.KEY_APARTMENT_ID + " = '" + apartment.getID() + "' AND "
                                + TABLE_EXPENSES.KEY_MONTH + " = '" + month + "' AND " + TABLE_EXPENSES.KEY_YEAR + " = " + year;

            connection.Open();
            using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        ExpenseDetails exp = new ExpenseDetails(reader[TABLE_EXPENSES.KEY_ID].ToString(), apartment, reader[TABLE_EXPENSES.KEY_NAME].ToString(), Convert.ToInt32(reader[TABLE_EXPENSES.KEY_AMOUNT]), (ExpenseType)Enum.Parse(typeof(ExpenseType), reader[TABLE_EXPENSES.KEY_TYPE].ToString(), true), (ExpenseStatus)Enum.Parse(typeof(ExpenseStatus), reader[TABLE_EXPENSES.KEY_STATUS].ToString(), true), reader[TABLE_EXPENSES.KEY_MONTH].ToString(), (int)reader[TABLE_EXPENSES.KEY_YEAR]);
                        expenses.Add(new ExpenseCard(exp));
                    }
                }
            }
        }

        public override void confirmPayment(OutgoingTransaction transaction, ExpenseCard expense)
        {
            SqlCommand insertCommand = new SqlCommand(INSERT_OUT_TR_SP.SP_NAME, connection);
            insertCommand.CommandType = System.Data.CommandType.StoredProcedure;

            insertCommand.Parameters.Add(new SqlParameter(INSERT_OUT_TR_SP.TR_ID_PARAM, transaction.getTrID()));
            insertCommand.Parameters.Add(new SqlParameter(INSERT_OUT_TR_SP.EXPENSE_ID_PARAM, transaction.getExpense().getExpenseID()));
            insertCommand.Parameters.Add(new SqlParameter(INSERT_OUT_TR_SP.DATE_PARAM, transaction.getDate()));
            insertCommand.Parameters.Add(new SqlParameter(INSERT_OUT_TR_SP.PAID_BY_PARAM, transaction.getPaidBy().getFlatNumber()));
            insertCommand.Parameters.Add(new SqlParameter(INSERT_OUT_TR_SP.APARTMENT_ID_PARAM, Guid.Parse(transaction.getPaidBy().getApartment().getID())));
            connection.Open();
            insertCommand.ExecuteNonQuery();
            connection.Close();
            expense.changeToPaid();
        }


        override public void deleteExpense(ExpenseDetails expense)
        {
            connection.Open();
            string deleteQuery = "DELETE " + TABLE_EXPENSES.TABLE_NAME + " WHERE " + TABLE_EXPENSES.KEY_ID + " = '" + expense.getExpenseID().ToString() + "'";
            SqlCommand command = new SqlCommand(deleteQuery,connection);

            try
            {
                command.ExecuteNonQuery();
            }

            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

    }
}
