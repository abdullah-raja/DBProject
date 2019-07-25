using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBproject.Model;
using DBproject.Views;

using System.Data.SqlClient;
using System.Data;
using DBproject.Util.Tables;
using DBproject.Util.StoredProcedures;

namespace DBproject.Controller
{
    class CreateAndJoinBuilding : ControllerModule
    {

        const string insertStoredProcedure = "usp_insertBuilding";
        const string updateApartmentProcedure = "usp_updateApartmentID";
        const string createFlatsProcedure = "usp_InsertFlat";

        public CreateAndJoinBuilding(string connectionString, string TableName) : base(connectionString, TableName)
        {


        }


        public override void createBuilding(Building building, SignUp view, User user, int adminFlat)
        {
            connection.Open();
            SqlCommand insertCommand = new SqlCommand(insertStoredProcedure, connection);
            insertCommand.CommandType = System.Data.CommandType.StoredProcedure;

            insertCommand.Parameters.Add(new SqlParameter("@apartmentName", building.getAppartmentName()));
            insertCommand.Parameters.Add(new SqlParameter("@numberOfFloors", building.getNoOfFloors()));
            insertCommand.Parameters.Add(new SqlParameter("@flatsPerFloor", building.getFlatsPerFloor()));
            insertCommand.Parameters.Add(new SqlParameter("@code", building.getCode()));
            insertCommand.Parameters.Add(new SqlParameter("@balance", building.getBalance()));
            insertCommand.Parameters.Add(new SqlParameter("@adminID", Guid.Parse(user.getID())));

            SqlParameter returnedID = insertCommand.Parameters.Add(new SqlParameter("@apartmentId", System.Data.SqlDbType.UniqueIdentifier,0, "apartmentID"));
            returnedID.Direction = ParameterDirection.Output;

           // try
         //  {

                if (insertCommand.ExecuteNonQuery() > 0) // returns number of rows affected
                {
                    building.setID(insertCommand.Parameters["@apartmentId"].Value.ToString()); // retreiving output value
                    user.setApartmentID(insertCommand.Parameters["@apartmentId"].Value.ToString());

                    
                    
                    // setting flats
                    for(int i = 0; i<building.getNoOfFloors(); i++)
                    {
                        for(int j = 0; j<building.getFlatsPerFloor(); j++)
                        {


                        SqlCommand createFlats = new SqlCommand(createFlatsProcedure, connection);
                        createFlats.CommandType = CommandType.StoredProcedure;
                        createFlats.Parameters.Add(new SqlParameter("@flatNumber", building.getFlatAt(i, j).getFlatNumber()));
                        createFlats.Parameters.Add(new SqlParameter("@apartmentID", Guid.Parse(building.getID())));


                        if (i + 1 == adminFlat / 100 && j + 1 == adminFlat % 10)
                        {
                            building.getFlatAt(i, j).makeManager(3);
                            user.setFlat(building.getFlatAt(i, j));
                        }
                        
                        createFlats.Parameters.Add(new SqlParameter("@isManager", building.getFlatAt(i, j).getIsManager()));  // 1 = not manager, // 2 = manager, 3 = admi, 


                        createFlats.ExecuteNonQuery();

                        createFlats.Dispose();
                        }
                    }

                    

                    view.buildingCreated();
                    
                }
           // }

           /* catch (Exception es)
            {
                view.buildingFailed();
            }
            */



        }



        public override void joinApartment(string id, string code, Views.SignUp view)
        {
            List<string> flatsNumbers = new List<string>();
            string flatQuer = "SELECT " + TABLE_FLATS.KEY_FLAT_NUMBER + " FROM " + Util.VIEWS.FLATS_VIEW +
                " WHERE " + TABLE_FLATS.KEY_APPARTMENT_ID + " = '" + id + "' AND " + TABLE_BUILDING.KEY_CODE + " = '" + code + "'";
            connection.Open();
            using (SqlCommand flatsCommand = new SqlCommand(flatQuer, connection))
            {
                using (SqlDataReader reader = flatsCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        flatsNumbers.Add((reader[0].ToString()));
                    }
                }
            }

            view.joinApartmentSuccessful(flatsNumbers);




        }

        override public void joinFlat(User user, SignUp view, string id, Building apartment, int flatNumber)
        {
            connection.Open();
            SqlCommand updateCommand = new SqlCommand(Util.StoredProcedures.UPDATE_APARTMENT_ID_SP.SP_NAME, connection);
            updateCommand.CommandType = CommandType.StoredProcedure;
            updateCommand.Parameters.AddWithValue(Util.StoredProcedures.UPDATE_APARTMENT_ID_SP.USER_ID_PARAM, Guid.Parse(user.getID()));
            updateCommand.Parameters.AddWithValue(Util.StoredProcedures.UPDATE_APARTMENT_ID_SP.APARTMENT_ID_PARAM, Guid.Parse(id));


            try
            {
                updateCommand.ExecuteNonQuery();
                user.setApartmentID(id);
                apartment.setID(id);
            }

            catch
            {

            }

            string selectApartmentQuery = "SELECT * FROM tbl_Buildings WHERE apartmentID = " + "'" + Guid.Parse(user.getApartmentID()) + "'";
            using (SqlCommand getApartmentCommand = new SqlCommand(selectApartmentQuery, connection))
            {
                using (SqlDataReader apartmentReader = getApartmentCommand.ExecuteReader())
                {
                    while (apartmentReader.Read())
                    {
                        //  int  l = (Int32)apartmentReader["flatsPerFloor"];
                        apartment.setAllValues(user.getApartmentID(), apartmentReader["apartmentName"].ToString(), (Int32)apartmentReader["numberOfFloors"], (Int32)apartmentReader["flatsPerFloor"], apartmentReader["code"].ToString(), user, 0, (int)apartmentReader["balance"]);
                        
                    }
                }
            }
            connection.Close();

            // setting admin flat

            this.getAllFlats(apartment); // get all flats from db and update apartment
            user.setFlat(apartment.getFlatAt(flatNumber));
            this.updateFlat(user);     // flat updated with userID
            view.flatUserSuccessful();
            


        }


    }
}
