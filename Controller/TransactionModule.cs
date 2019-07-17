using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBproject.Model;
using DBproject.Util.StoredProcedures;
using DBproject.Views.UserControls;
using DBproject.Util.Tables;
using System.Windows.Forms;

namespace DBproject.Controller
{
    class TransactionModule : ControllerModule
    {
        public TransactionModule(string connectionString, string TableName) : base(connectionString, TableName)
        {


        }
        
        override public void showPaidReceipt(Receipt recipt, string month, int flatNumber)
        {
            string selectQuery = "SELECT " + TABLE_INCOMING_TRANSACTIONS.KEY_DATE_PAID + ", " + TABLE_INCOMING_TRANSACTIONS.KEY_TRID + ", " + TABLE_FLATS.KEY_RESIDENT_NAME + ", " + TABLE_FLATS.KEY_FLAT_NUMBER + ", " + TABLE_INCOMING_TRANSACTIONS.KEY_AMOUNT + ", " + TABLE_INCOMING_TRANSACTIONS.KEY_MONTH + ", " + TABLE_INCOMING_TRANSACTIONS.KEY_YEAR + " FROM " + TABLE_FLATS.TBL_FLATS +
                                 " INNER JOIN " + TABLE_INCOMING_TRANSACTIONS.TABLE_NAME + " ON " + TABLE_FLATS.KEY_FLAT_NUMBER + " = " + TABLE_INCOMING_TRANSACTIONS.KEY_FLAT_NUMBER + " AND " + TABLE_FLATS.TBL_FLATS + "." + TABLE_FLATS.KEY_APPARTMENT_ID + " = " + TABLE_INCOMING_TRANSACTIONS.TABLE_NAME + "." + TABLE_INCOMING_TRANSACTIONS.KEY_APARTMENT_ID +
                                 " WHERE " + TABLE_INCOMING_TRANSACTIONS.KEY_MONTH + " = '" + month + "' AND " + TABLE_FLATS.KEY_FLAT_NUMBER + " = " + flatNumber;

            connection.Open();
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        recipt.setValues((DateTime)reader[TABLE_INCOMING_TRANSACTIONS.KEY_DATE_PAID], reader[TABLE_FLATS.KEY_RESIDENT_NAME].ToString(), reader[TABLE_INCOMING_TRANSACTIONS.KEY_TRID].ToString(), (Int32)reader[TABLE_FLATS.KEY_FLAT_NUMBER], (int)reader[TABLE_INCOMING_TRANSACTIONS.KEY_AMOUNT], reader[TABLE_INCOMING_TRANSACTIONS.KEY_MONTH].ToString(), Convert.ToInt32(reader[TABLE_INCOMING_TRANSACTIONS.KEY_YEAR]));
                    }
                }
            }
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
            insertCommand.Parameters.AddWithValue(INSERT_TRANSACTION_SP.YEAR_PARAM, transaction.getYear());

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

        override public void sendEmail(string email, Receipt receipt)
        {
            // send email functionality here
        }

        public override void setMonths(Income view, int year) // for income
        {
            
            List<String> months = new List<String>();
            string selectQuery = "SELECT DISTINCT " + TABLE_INCOMING_TRANSACTIONS.KEY_MONTH + " FROM " + TABLE_INCOMING_TRANSACTIONS.TABLE_NAME + " WHERE " + TABLE_INCOMING_TRANSACTIONS.KEY_YEAR + " = " + year;
            connection.Open();
            
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader monthReader = command.ExecuteReader())
                {
                    while(monthReader.Read())
                    {
                        months.Add(monthReader[TABLE_INCOMING_TRANSACTIONS.KEY_MONTH].ToString());
                    }
                }
            }
            
            connection.Close();
            view.setMonths(months);
        }
        public override void setMonths(Expense view, int year)
        {
            List<String> months = new List<String>();
            string selectQuery = "SELECT DISTINCT " + TABLE_INCOMING_TRANSACTIONS.KEY_MONTH + " FROM " + TABLE_INCOMING_TRANSACTIONS.TABLE_NAME + " WHERE " + TABLE_INCOMING_TRANSACTIONS.KEY_YEAR + " = " + year;
            connection.Open();

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader monthReader = command.ExecuteReader())
                {
                    while (monthReader.Read())
                    {
                        months.Add(monthReader[TABLE_INCOMING_TRANSACTIONS.KEY_MONTH].ToString());
                    }
                }
            }

            connection.Close();
            view.setMonths(months);

        }

        override public void setYears(Income view)
        {
            List<String> years = new List<String>();
            string selectQuery = "SELECT DISTINCT " + TABLE_INCOMING_TRANSACTIONS.KEY_YEAR + " FROM " + TABLE_INCOMING_TRANSACTIONS.TABLE_NAME;
            connection.Open();

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader yearReader = command.ExecuteReader())
                {
                    while (yearReader.Read())
                    {
                        years.Add(yearReader[TABLE_INCOMING_TRANSACTIONS.KEY_YEAR].ToString());
                    }
                }
            }

            connection.Close();
            view.setYears(years);
        }

        public override void setYears(Expense view)
        {
            List<String> years = new List<String>();
            string selectQuery = "SELECT DISTINCT " + TABLE_INCOMING_TRANSACTIONS.KEY_YEAR + " FROM " + TABLE_INCOMING_TRANSACTIONS.TABLE_NAME;
            connection.Open();

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader yearReader = command.ExecuteReader())
                {
                    while (yearReader.Read())
                    {
                        years.Add(yearReader[TABLE_INCOMING_TRANSACTIONS.KEY_YEAR].ToString());
                    }
                }
            }

            connection.Close();
            view.setYears(years);
        }
    }
}
