using System;
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

            string query = "INSERT INTO " + TABLE_NAME + " VALUES('" + user.getID() + "' , '" + user.getEmail() + "' , '" + user.getUserStatus() + "' , '" + user.getPassword() + "' ,  '" + user.getFirstName() + "' , '" + user.getLastname() + "' , '" + user.getMobileNumber() + "' )";
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.InsertCommand = new SqlCommand(query, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            insertSuccessul = true;
            connection.Close();

            view.setWelcomeTitle("Welcome " + user.getFirstName());
            return insertSuccessul;

                

        }
    }
}
