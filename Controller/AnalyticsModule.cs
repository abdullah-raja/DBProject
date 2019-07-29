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
using DBproject.Views.UserControls.Graphs;
using DBproject.Util.Tables;

namespace DBproject.Controller
{
    class AnalyticsModule : ControllerModule
    {

        public AnalyticsModule(string connectionString) : base(connectionString, "")
        {


        }


        override public void showIncomePieChart(Anaytics view, Building apartment)
        {
            int receivedCount = 0, receivedSum = 0, totalSum = 0;
            string receivedQuery = "SELECT COUNT(*), SUM(" + Util.Tables.TABLE_INCOMING_TRANSACTIONS.KEY_AMOUNT + ") FROM FLATS_PAID WHERE " + Util.Tables.TABLE_INCOMING_TRANSACTIONS.KEY_APARTMENT_ID + " = '" + apartment.getID() + "' AND " + Util.Tables.TABLE_INCOMING_TRANSACTIONS.KEY_MONTH + " = '" + DBproject.miscFunctions.ToMonthName(DateTime.Now) + "' AND " + Util.Tables.TABLE_INCOMING_TRANSACTIONS.KEY_YEAR + " = " + DateTime.Now.Year;
            string totalQuery = "SELECT SUM(" + Util.Tables.TABLE_FLATS.KEY_MONTHLYFEE + ") FROM " + Util.Tables.TABLE_FLATS.TBL_FLATS + " WHERE " + Util.Tables.TABLE_EXPENSES.KEY_APARTMENT_ID + " = '" + apartment.getID() + "'";


            connection.Open();
            using (SqlCommand command = new SqlCommand(receivedQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {

                            receivedCount = (int)reader[0];
                            receivedSum = (int)reader[1];
                        }

                        catch
                        {

                        }
                    }
                }
            }
            connection.Close();

            connection.Open();
            using (SqlCommand command = new SqlCommand(totalQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            totalSum = (int)reader[0];
                            
                        }

                        catch
                        {

                        }
                    }
                }
            }
            connection.Close();
            view.showIncomeGraph(receivedCount, receivedSum, totalSum);


        }


        public override void showExpensePieChart(Anaytics view, Building apartment)
        {
            int paidCount = 0, paidSum = 0, unpaidCount = 0, unpaidSum = 0;
            string paidQuery = "SELECT COUNT(*), SUM(" + Util.Tables.TABLE_EXPENSES.KEY_AMOUNT + ") FROM EXPENSE_PAID WHERE " + Util.Tables.TABLE_EXPENSES.KEY_APARTMENT_ID + " = '" + apartment.getID() + "' AND " + Util.Tables.TABLE_EXPENSES.KEY_MONTH + " = '" + DBproject.miscFunctions.ToMonthName(DateTime.Now) + "' AND " + Util.Tables.TABLE_EXPENSES.KEY_YEAR + " = " + DateTime.Now.Year;
            string unPaidQuery = "SELECT COUNT(*), SUM(" + Util.Tables.TABLE_EXPENSES.KEY_AMOUNT + ") FROM EXPENSE_UNPAID WHERE " + Util.Tables.TABLE_EXPENSES.KEY_APARTMENT_ID + " = '" + apartment.getID() + "' AND " + Util.Tables.TABLE_EXPENSES.KEY_MONTH + " = '" + DBproject.miscFunctions.ToMonthName(DateTime.Now) + "' AND " + Util.Tables.TABLE_EXPENSES.KEY_YEAR + " = " + DateTime.Now.Year;


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
            connection.Close();
            view.showExpenseGraph(paidCount, paidSum, unpaidCount, unpaidSum);


        }

        public override void updateBarGraphData(BarGraph bar, int year, Building apartment)
        {
            string incomeQuery = "SELECT incomeMonth, totalIncome, total FROM MONTHLY_EXPENSES_VIEW e INNER JOIN MONTHLY_INCOME_VIEW i ON e.month = i.incomeMonth AND e.apartmentID = i.apartmentID WHERE " + "i.apartmentID = '" + apartment.getID() + "'";
            // first column of everymonth = month index, second inc, third exp
            connection.Open();
            using (SqlCommand command = new SqlCommand(incomeQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int i = 1;
                    while(reader.Read() && i < 12)
                    {
                        while(Convert.ToInt32(reader[0]) != i)
                        {
                            i++;
                        }

                        bar.setData(i, Convert.ToInt32(reader[1]), Convert.ToInt32(reader[2]));
                    }
                }
            }

            bar.updateGraph();
            

        }


    }
}
