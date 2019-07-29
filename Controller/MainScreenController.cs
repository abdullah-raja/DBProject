using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBproject.Model;
using DBproject.Views;
using System.Data.SqlClient;
using DBproject.Util.Tables;
using DBproject.Views.UserControls;
using DBproject.Util.StoredProcedures;

namespace DBproject.Controller
{
    class MainScreenController : ControllerModule
    {
        
        public MainScreenController(string connectionString, string TableName) : base(connectionString, TableName)
        {


        }

        override public void showDetailsPanel(Flat flat, Views.UserControls.Income view)
        {
            string SelectFlatDetails = "SELECT * FROM " + TABLE_NAME + " WHERE flatNumber = " + flat.getFlatNumber() + " AND apartmentID = '" + flat.getApartment().getID() + "'";
            connection.Open();

            using (SqlCommand command = new SqlCommand(SelectFlatDetails, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        try
                        {
                            view.showDetails(reader["residentName"].ToString(), Convert.ToInt32(reader["flatNumber"]), Convert.ToInt32(reader["monthlyFee"]), Convert.ToInt32(reader["dues"]), Convert.ToBoolean(reader["isManager"]), reader["email"].ToString(), reader["mobileNumber"].ToString());
                        }

                        catch (System.InvalidCastException es)
                        {
                            view.showDetails("-", Convert.ToInt32(reader["flatNumber"]), 0, 0, false, "-", "-");
                        }
                    }
                }

            }

            connection.Close();
        }

        override public void updateDetailsPanel(Flat flat)
        {
            connection.Open();
            SqlCommand updateCommand = new SqlCommand(UPDATE_FLAT_SP.SP_NAME, connection);
            updateCommand.CommandType = System.Data.CommandType.StoredProcedure;

            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_SP.FLAT_NUM_PARAm, flat.getFlatNumber()));
            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_SP.EMAIL_PARAM, flat.getEmail()));
            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_SP.MOBILE_NUM_PARAM, flat.getContactNumber()));
            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_SP.DUES_PARAM, flat.getDues()));
            
            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_SP.FEE_PARAM, flat.getMonthlyFees()));
            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_SP.APARTMENT_ID_PARAM, Guid.Parse(flat.getApartment().getID())));
            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_SP.NAME_PARAM, flat.getNameOfResident()));
            updateCommand.Parameters.Add(new SqlParameter(UPDATE_FLAT_SP.IS_MANAGER_PARAM, flat.getIsManager()));

            updateCommand.ExecuteNonQuery();
            

        }

        override public void updateBalance(Building apartment, MainScreen view)
        {
            int income = 0, expense = 0;
            string query = "SELECT " + TABLE_BUILDING.KEY_BALANCE + " FROM " + TABLE_BUILDING.TBL_BUILDING +
                            " WHERE " + TABLE_BUILDING.KEY_APPARTMENT_ID + " = '" + apartment.getID() + "'";

            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {
                    while(reader.Read())
                    {
                        apartment.setBalance(Convert.ToInt32(reader[TABLE_BUILDING.KEY_BALANCE]));
                        
                    }
                }
            }

            string incomeQuery = "SELECT SUM(" + TABLE_INCOMING_TRANSACTIONS.KEY_AMOUNT + ") FROM " + TABLE_INCOMING_TRANSACTIONS.TABLE_NAME +
                                 " WHERE MONTH(" + TABLE_INCOMING_TRANSACTIONS.KEY_DATE_PAID + ") = MONTH(GETDATE()) AND YEAR(" + TABLE_INCOMING_TRANSACTIONS.KEY_DATE_PAID +") = YEAR(GETDATE()) AND " + TABLE_INCOMING_TRANSACTIONS.KEY_APARTMENT_ID + " = '" + apartment.getID() + "'";

            using (SqlCommand incomeCommand = new SqlCommand(incomeQuery, connection))
            {
                using (SqlDataReader incomeReader = incomeCommand.ExecuteReader())
                {
                    if (incomeReader.Read())
                    {
                        try
                        {
                            income = (int)incomeReader[0];
                        }
                        catch
                        {

                        }
                    }
                }
            }

            string expenseQuery = "SELECT SUM(" + TABLE_EXPENSES.KEY_AMOUNT + ") FROM [paidExpenses] v INNER JOIN " + TABLE_OUTGOING_TRANSACTION.TABLE_NAME + " t on v.expenseID = t.expenseID GROUP BY MONTH(t." + TABLE_OUTGOING_TRANSACTION.KEY_DATE + "), t." + TABLE_OUTGOING_TRANSACTION.KEY_APARTMENT_ID +
                " HAVING MONTH(t." + TABLE_OUTGOING_TRANSACTION.KEY_DATE + ") = MONTH(GETDATE()) AND t." + TABLE_OUTGOING_TRANSACTION.KEY_APARTMENT_ID + " = '" + apartment.getID() + "'"; 
            using (SqlCommand expenseCommand = new SqlCommand(expenseQuery, connection))
            {
                using (SqlDataReader expenseReader = expenseCommand.ExecuteReader())
                {
                    if (expenseReader.Read())
                    {
                        try
                        {
                            expense = (int)expenseReader[0];
                        }
                        catch
                        {

                        }
                    }
                }
            }

            view.updateBalance(income, expense);
        }

        public  void newMonthStarted(Income view)
        {
           
        }
    }
}
