﻿using System;
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
        const string BUILDINGS_TABLE = "tbl_Buildings";

        public AuthorizationModule(string connectionString, string TableName) : base(connectionString, TableName)
        {
        }



        override public void signIn(Model.User user, Views.SignUp view, string enteredEmail, string enteredPassword, Model.Building apartment)
        {
            bool passwordMatched = false;
            string selectAllQuery = "SELECT userID, userFirstName, userLastName, userStatus, userMobileNumber, apartmentID FROM " + TABLE_NAME + " WHERE userEmail = '" + enteredEmail + "'";
         

            connection.Open();
            string selectQuery = "SELECT password FROM " + TABLE_NAME + " WHERE userEmail = '" + enteredEmail + "'";

            using (SqlCommand command = new SqlCommand(selectQuery, connection)) // getting password against entered email
            {
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                        passwordMatched = enteredPassword == Model.User.encodePassword(dr["password"].ToString()); // if password matches

                    else
                    {
                        view.logInInFailed(false);
                        return;
                    }

                }

            }

            if (passwordMatched)
            {
                
            using (SqlCommand getUserCommand = new SqlCommand(selectAllQuery, connection))
            {
                using (SqlDataReader dr2 = getUserCommand.ExecuteReader())
                {
                    
                        while (dr2.Read())
                        {
                            bool isAdmin;
                            if (dr2["userStatus"].ToString() == "Admin")
                                isAdmin = true;

                            else
                                isAdmin = false;

                            user.setAllValues(dr2["userID"].ToString(), dr2["userFirstName"].ToString(), dr2["userLastName"].ToString(), enteredEmail, enteredPassword, isAdmin, dr2["userMobileNumber"].ToString());

                            if (dr2["apartmentID"].ToString() != "") // user have already joined/created a building
                            {
                                user.setApartmentID(dr2["apartmentID"].ToString());
                                view.logInSuccessful();
                            }

                            else // user have to join or create a building first
                            {

                                view.signUpSuccessful(isAdmin);

                            }

                            
                        }

                       
                }

            }

                if (user.getApartmentID() != null)
                {
                    string selectApartmentQuery = "SELECT * FROM tbl_Buildings WHERE apartmentID = " + "'" + Guid.Parse(user.getApartmentID()) + "'";
                    using (SqlCommand getApartmentCommand = new SqlCommand(selectApartmentQuery, connection))
                    {
                        using (SqlDataReader apartmentReader = getApartmentCommand.ExecuteReader())
                        {
                            while (apartmentReader.Read())
                            {
                                apartment.setAllValues(user.getApartmentID(), apartmentReader["apartmentName"].ToString(), (Int32)apartmentReader["numberOfFloors"], (Int32)apartmentReader["flatsPerFloor"], apartmentReader["code"].ToString(), user, 0, (int)apartmentReader["balance"]);
                            }
                        }
                    }

                }

                else
                    apartment = null;

            }

            else // password incorrect
            {
                view.logInInFailed(true);
            }


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
