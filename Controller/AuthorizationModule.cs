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
        const string loginStoredProcedure = "usp_checkLoginInfo";

        public AuthorizationModule(string connectionString, string TableName) : base(connectionString, TableName)
        {
        }



        override public void signIn(Model.User user, Views.SignUp view)
        {
            // check login info 
            // retrive data from DB, using emailAddress
            // store a record in the user, i.e user.setname(<name returned from DB>)
            // call view.signIn fail/successs functions
            // oye dekh?

            // pehle SQL command ko use kr k password read krna ha
            // Select password from tbl_Users where userEmail = view.<login email ka jo textbox ha wo>.Text
            // neeche select statement ki bachodi poori krni ha jisse password read hojayga phr uski match krna ha

            // phr loginStoredProcedure ko execute krna ha aur uske jo output parameters hn unko user k constructor me pass krna ha jese sign up k function me kya ha


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

           


          // try
          // {

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
            /* }



               
           


           catch (Exception es)
           {
              view.signUpFailed();
           }
           */
            
            
            connection.Close();

            
            return insertSuccessul;

                

        }
    }
}
