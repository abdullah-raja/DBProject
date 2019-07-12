using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBproject.Model;
using DBproject.Views;

using System.Data.SqlClient;
using System.Data;


namespace DBproject.Controller
{
    class CreateAndJoinBuilding : ControllerModule
    {

        const string insertStoredProcedure = "usp_insertBuilding";
        const string updateApartmentProcedure = "usp_updateApartmentID";

        public CreateAndJoinBuilding(string connectionString, string TableName) : base(connectionString, TableName)
        {


        }


        public override void createBuilding(Building building, SignUp view, User user)
        {
            connection.Open();
            SqlCommand insertCommand = new SqlCommand(insertStoredProcedure, connection);
            insertCommand.CommandType = System.Data.CommandType.StoredProcedure;

            insertCommand.Parameters.Add(new SqlParameter("@apartmentName", building.getAppartmentName()));
            insertCommand.Parameters.Add(new SqlParameter("@numberOfFloors", building.getNoOfFloors()));
            insertCommand.Parameters.Add(new SqlParameter("@flatsPerFloor", building.getNoOfFloors()));
            insertCommand.Parameters.Add(new SqlParameter("@code", building.getCode()));
            insertCommand.Parameters.Add(new SqlParameter("@balance", building.getBalance()));
            insertCommand.Parameters.Add(new SqlParameter("@adminID", Guid.Parse(user.getID())));

            SqlParameter returnedID = insertCommand.Parameters.Add(new SqlParameter("@apartmentId", System.Data.SqlDbType.UniqueIdentifier,0, "apartmentID"));
            returnedID.Direction = ParameterDirection.Output;

            try
           {

                if (insertCommand.ExecuteNonQuery() > 0) // returns number of rows affected
                {
                    building.setID(insertCommand.Parameters["@apartmentId"].Value.ToString()); // retreiving output value
                    user.setApartmentID(insertCommand.Parameters["@apartmentId"].Value.ToString());
    
                    view.buildingCreated();
                    
                }
            }

            catch (Exception es)
            {
                view.buildingFailed();
            }

        }
    }
}
