using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBproject.Model;
using DBproject.Util.StoredProcedures;
using DBproject.Views.UserControls;

namespace DBproject.Controller
{
    class TransactionModule : ControllerModule
    {
        public TransactionModule(string connectionString, string TableName) : base(connectionString, TableName)
        {


        }
        
        override public void confirmTransaction(IncomingTransaction transaction)
        {
            SqlCommand insertCommand = new SqlCommand(INSERT_TRANSACTION_SP.SP_NAME, connection);
            insertCommand.CommandType = System.Data.CommandType.StoredProcedure;

            insertCommand.Parameters.AddWithValue(INSERT_TRANSACTION_SP.TR_ID_PARAM, transaction.getTrID());
            insertCommand.Parameters.AddWithValue(INSERT_TRANSACTION_SP.APARTMENT_ID_PARAM, Guid.Parse(transaction.getApartment().getID()));
            insertCommand.Parameters.AddWithValue(INSERT_TRANSACTION_SP.AMOUNT_PARAM, transaction.getAmount());
            insertCommand.Parameters.AddWithValue(INSERT_TRANSACTION_SP.COLLECTED_BY_PARAM, transaction.getCollectedBy().getFlatNumber());
            insertCommand.Parameters.AddWithValue(INSERT_TRANSACTION_SP.DATE_PARAM, transaction.getDate());
            insertCommand.Parameters.AddWithValue(INSERT_TRANSACTION_SP.MONTH_PARAM, transaction.getMonth());
            insertCommand.Parameters.AddWithValue(INSERT_TRANSACTION_SP.PAID_BY_PARAM, transaction.getPaidBy().getFlatNumber());

            connection.Open();
            try
            {
                insertCommand.ExecuteNonQuery();
            }

            catch (Exception es)
            {

            }
            
            connection.Close();
        }

        override public void sendEmail(string email)
        {
            // send email functionality here
        }
    }
}
