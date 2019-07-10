using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Controller
{
    class AuthorizationModule : ControllerModule
    {
        
        const string insertStoredProcedure = "usp_insertUser";

        public AuthorizationModule(string connectionString, string TableName) : base(connectionString, TableName)
        {
        }



        override public void signIn(Model.User user, Views.SignUp view)
        {
            // check login info 
            // retrive data from DB, using emailAddress
            // store a record in the user, i.e user.setname(<name returned from DB>)
            // call view.signIn fail/successs functions

            

        }

        override public bool signUp(Model.User user, Views.SignUp view) // Sending instance of View to make changes, will return true if successful
        {
            bool insertSuccessul = false;
            connection.Open();

            SqlCommand insertCommand = new SqlCommand(insertStoredProcedure, connection);
            insertCommand.CommandType = System.Data.CommandType.StoredProcedure;

            insertCommand.Parameters.Add(new SqlParameter("@email", user.getEmail()));
            insertCommand.Parameters.Add(new SqlParameter("@status", user.getUserStatus()));
            insertCommand.Parameters.Add(new SqlParameter("@password", user.getPassword()));
            insertCommand.Parameters.Add(new SqlParameter("@firstName", user.getFirstName()));
            insertCommand.Parameters.Add(new SqlParameter("@lastName", user.getLastname()));
            insertCommand.Parameters.Add(new SqlParameter("@mobile", user.getMobileNumber()));

            // creating output parameter
            SqlParameter returnedUserID = insertCommand.Parameters.Add("@userID", System.Data.SqlDbType.UniqueIdentifier, 0, "userID");
            returnedUserID.Direction = System.Data.ParameterDirection.Output;

           


           try
           {

                if (insertCommand.ExecuteNonQuery() > 0) // returns number of rows affected
                {
                    user.setID(insertCommand.Parameters["@userID"].Value.ToString()); // retreiving output value
                    view.signUpSuccessful();
                    view.setWelcomeTitle("Welcome " + user.getFirstName());
                }

                else
                {
                    view.signUpFailed();
                }
            }



               
           


           catch (Exception es)
           {
              view.signUpFailed();
           }

            
            
            connection.Close();

            
            return insertSuccessul;

                

        }
    }
}
