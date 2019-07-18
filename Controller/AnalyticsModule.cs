using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBproject.Views;
using DBproject.Model;
using DBproject.Util;
using DBproject.Views.UserControls;
using System.Data.SqlClient;

namespace DBproject.Controller
{
    class AnalyticsModule : ControllerModule
    {

        public AnalyticsModule(string connectionString) : base(connectionString, "")
        {


        }
        public override void showExpensePieChart(Anaytics view, Building apartment)
        {
            int paidCount = 0, paidSum = 0, unpaidCount = 0, unpaidSum = 0;
            string paidQuery = "SELECT COUNT(*), SUM(" + Util.Tables.TABLE_EXPENSES.KEY_AMOUNT + ") FROM EXPENSE_PAID WHERE " + Util.Tables.TABLE_EXPENSES.KEY_APARTMENT_ID + " = '" + apartment.getID() + "'";
            string unPaidQuery = "SELECT COUNT(*), SUM(" + Util.Tables.TABLE_EXPENSES.KEY_AMOUNT + ") FROM EXPENSE_UNPAID WHERE " + Util.Tables.TABLE_EXPENSES.KEY_APARTMENT_ID + " = '" + apartment.getID() + "'";

            connection.Open();
            using (SqlCommand command = new SqlCommand(paidQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        try
                        {

                            paidCount = (int)reader[0];
                            paidSum = (int)reader[1];
                        }

                        catch
                        {

                        }
                    }
                }
            }
            connection.Close();

            connection.Open();
            using (SqlCommand command = new SqlCommand(unPaidQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            unpaidCount = (int)reader[0];
                            unpaidSum = (int)reader[1];
                        }

                        catch
                        {

                        }
                    }
                }
            }

            view.showExpenseGraph(paidCount, paidSum, unpaidCount, unpaidSum);


        }


    }
}
