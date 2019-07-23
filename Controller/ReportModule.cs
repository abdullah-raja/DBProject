using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBproject.Views;
using DBproject.Model;
using DBproject.Util.Tables;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;

namespace DBproject.Controller
{
    class ReportModule : ControllerModule
    {
        public ReportModule(string connectionString) : base(connectionString, "")
        {
            
        }

        public override void generateReprt(ReportDialogBox view ,Building apartment, int month, int year)
        {
            int incomeSum = 0, expenseSum = 0;
            view.exportPdf(generateIncomeReport(apartment, month, year, ref incomeSum), generateExpenseReport(apartment, month, year, ref expenseSum), incomeSum, expenseSum);

        }

        private DataTable generateIncomeReport(Building apartment, int month, int year, ref int sum)
        {
            sum = 0;
            string incomeQuery = "SELECT " + TABLE_FLATS.KEY_FLAT_NUMBER + ", " + TABLE_INCOMING_TRANSACTIONS.KEY_AMOUNT;
            DataTable incomeTable = new DataTable();
            incomeTable.Columns.Add("FLAT NUMBER");
            incomeTable.Columns.Add("AMOUNT");

            // Concatnating column name according to the check box


            incomeQuery += ", " + TABLE_INCOMING_TRANSACTIONS.KEY_MONTH;
            incomeTable.Columns.Add("FOR THE MONTH");



            incomeTable.Columns.Add("DATE PAID");
            incomeQuery += ", " + TABLE_INCOMING_TRANSACTIONS.KEY_DATE_PAID;




            incomeTable.Columns.Add("RECEIVABLE DUES");
            incomeQuery += ", " + TABLE_FLATS.KEY_DUES;

            // completing the query
            incomeQuery += " FROM " + Util.VIEWS.INCOME_REPORT_VIEW + " WHERE " + TABLE_FLATS.KEY_APPARTMENT_ID + " = '" + apartment.getID() + "' AND MONTH(" + TABLE_INCOMING_TRANSACTIONS.KEY_DATE_PAID + ") = " + month +
                " OR MONTH(" + TABLE_INCOMING_TRANSACTIONS.KEY_DATE_PAID + ") is null" + " AND YEAR(" + Util.Tables.TABLE_INCOMING_TRANSACTIONS.KEY_DATE_PAID + ") = " + year + " OR YEAR(" + Util.Tables.TABLE_INCOMING_TRANSACTIONS.KEY_DATE_PAID + ") is null";

            connection.Open();
            using (SqlCommand incomeCommand = new SqlCommand(incomeQuery, connection))
            {
                using (SqlDataReader incomeReader = incomeCommand.ExecuteReader())
                {

                    while (incomeReader.Read())
                    {
                        try
                        {
                            incomeTable.Rows.Add(incomeReader[TABLE_FLATS.KEY_FLAT_NUMBER].ToString(), incomeReader[TABLE_INCOMING_TRANSACTIONS.KEY_AMOUNT].ToString(), incomeReader[TABLE_INCOMING_TRANSACTIONS.KEY_MONTH].ToString(), Convert.ToDateTime(incomeReader[TABLE_INCOMING_TRANSACTIONS.KEY_DATE_PAID]).ToShortDateString(), incomeReader[TABLE_FLATS.KEY_DUES].ToString());
                            sum += (int)incomeReader[TABLE_INCOMING_TRANSACTIONS.KEY_AMOUNT];
                        }

                        catch (InvalidCastException es)
                        {
                            incomeTable.Rows.Add(incomeReader[TABLE_FLATS.KEY_FLAT_NUMBER].ToString(), "-", incomeReader[TABLE_INCOMING_TRANSACTIONS.KEY_MONTH].ToString(), "-", incomeReader[TABLE_FLATS.KEY_DUES].ToString());
                        }
                    }
                }


            }
            connection.Close();
            return incomeTable;
        }



        private DataTable generateExpenseReport(Building apartment, int month, int year, ref int sum)
        {
            sum = 0;
            string expenseQuery = "SELECT " + TABLE_OUTGOING_TRANSACTION.KEY_DATE + ", " + TABLE_EXPENSES.KEY_NAME
                + ", " + TABLE_EXPENSES.KEY_AMOUNT + " FROM " + Util.VIEWS.EXPENSE_REPORT_VIEW
                + " WHERE " + TABLE_EXPENSES.KEY_APARTMENT_ID + " = '" + apartment.getID() + "' AND MONTH(" + TABLE_OUTGOING_TRANSACTION.KEY_DATE + ") = " + month +
                " AND YEAR(" + Util.Tables.TABLE_OUTGOING_TRANSACTION.KEY_DATE + ") = " + year;

            DataTable expenseTable = new DataTable();
            expenseTable.Columns.Add("DATE PAID");
            expenseTable.Columns.Add("DETAILS");
            expenseTable.Columns.Add("AMOUNT");

            // Concatnating column name according to the check box


       

            connection.Open();
            using (SqlCommand expenseCommand = new SqlCommand(expenseQuery, connection))
            {
                using (SqlDataReader expenseReader = expenseCommand.ExecuteReader())
                {

                    while (expenseReader.Read())
                    {
                        
                            expenseTable.Rows.Add(Convert.ToDateTime(expenseReader[TABLE_OUTGOING_TRANSACTION.KEY_DATE]).ToShortDateString(), expenseReader[TABLE_EXPENSES.KEY_NAME].ToString(), expenseReader[TABLE_INCOMING_TRANSACTIONS.KEY_AMOUNT].ToString());
                            sum += (int)expenseReader[TABLE_EXPENSES.KEY_AMOUNT];
                        
                        
                    }
                }


            }
            connection.Close();
            return expenseTable;
        }


        override public void setMonthAndYears(ReportDialogBox view, Building apartment)
        {
            List<String> months = new List<String>();
            List<String> years = new List<String>();
            string selectQuery = "SELECT DISTINCT MONTH(" + TABLE_OUTGOING_TRANSACTION.KEY_DATE + "), YEAR(" + TABLE_OUTGOING_TRANSACTION.KEY_DATE + ") FROM " +
                                Util.VIEWS.EXPENSE_REPORT_VIEW + " WHERE " + TABLE_EXPENSES.KEY_APARTMENT_ID + " = '" + apartment.getID() + "'";
            connection.Open();

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (Convert.ToInt32(reader[0]) != DateTime.Now.Month || Convert.ToInt32(reader[1]) != DateTime.Now.Year)
                        {
                            int month = Convert.ToInt32(reader[0]);

                            months.Add(miscFunctions.ToMonthName(month));
                            years.Add(reader[1].ToString());
                        }
                    }
                }
            }

            connection.Close();
            view.setMonths(months);
            view.setYears(years);
        }
    }
}
