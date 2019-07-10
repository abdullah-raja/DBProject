﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Controller
{
    class AuthorizationModule
    {
        string TABLE_NAME;
        const string insertStoredProcedure = "usp_insertUser";

        string connectionString;
        SqlConnection connection;

        public AuthorizationModule(string connectionString, string TableName)
        {
            this.TABLE_NAME = TableName;
            try
            {
                this.connectionString = connectionString;
                this.connection = new SqlConnection(this.connectionString);
            }

            catch (Exception es)
            {
                
            }

        }

        public bool insertRecord(Model.User user, Views.SignUp view) // Sending instance of View to make changes, will return true if successful
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

            try
            {

                if (insertCommand.ExecuteNonQuery() > 0) // returns number of rows affected
                {
                    view.signUpSuccessful();
                    view.setWelcomeTitle("Welcome " + user.getFirstName());
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