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

namespace DBproject.Controller
{
    class MainScreenController : ControllerModule
    {
        string updateFlatSP = "usp_updateFlat";
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
            SqlCommand updateCommand = new SqlCommand(updateFlatSP, connection);
            updateCommand.CommandType = System.Data.CommandType.StoredProcedure;

            updateCommand.Parameters.Add(new SqlParameter("@flatNumber", flat.getFlatNumber()));
            updateCommand.Parameters.Add(new SqlParameter("@email", flat.getEmail()));
            updateCommand.Parameters.Add(new SqlParameter("@mobileNumber", flat.getContactNumber()));
            updateCommand.Parameters.Add(new SqlParameter("@dues", flat.getDues()));
            
            updateCommand.Parameters.Add(new SqlParameter("@monthlyFee", flat.getMonthlyFees()));
            updateCommand.Parameters.Add(new SqlParameter("@apartmentID", Guid.Parse(flat.getApartment().getID())));
            updateCommand.Parameters.Add(new SqlParameter("@name", flat.getNameOfResident()));
            updateCommand.Parameters.Add(new SqlParameter("@manager", flat.getIsManager()));

            updateCommand.ExecuteNonQuery();

        }

        override public void updateBalance(Building apartment, MainScreen view)
        {
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
                        view.updateBalance();
                    }
                }
            }
        }

        public override void newMonthStarted(Income view)
        {
            SqlCommand command = new SqlCommand(Util.StoredProcedures.MONTH_STARTED_SP.SP_NAME, connection);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
