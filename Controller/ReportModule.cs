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
            view.exportPdf(generateIncomeReport(apartment, month, year), null);

        }

        private DataTable generateIncomeReport(Building apartment, int month, int year)
        {
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
            using (SqlCommand insertCommand = new SqlCommand(incomeQuery, connection))
            {
                using (SqlDataReader insertReader = insertCommand.ExecuteReader())
                {

                    while (insertReader.Read())
                    {
                        try
                        {
                            incomeTable.Rows.Add(insertReader[TABLE_FLATS.KEY_FLAT_NUMBER].ToString(), insertReader[TABLE_INCOMING_TRANSACTIONS.KEY_AMOUNT].ToString(), insertReader[TABLE_INCOMING_TRANSACTIONS.KEY_MONTH].ToString(), Convert.ToDateTime(insertReader[TABLE_INCOMING_TRANSACTIONS.KEY_DATE_PAID]), insertReader[TABLE_FLATS.KEY_DUES].ToString());
                        }

                        catch (InvalidCastException es)
                        {
                            incomeTable.Rows.Add(insertReader[TABLE_FLATS.KEY_FLAT_NUMBER].ToString(), "-", insertReader[TABLE_INCOMING_TRANSACTIONS.KEY_MONTH].ToString(), "-", insertReader[TABLE_FLATS.KEY_DUES].ToString());
                        }
                    }
                }


            }
            connection.Close();
            return incomeTable;
        }
    }
}
