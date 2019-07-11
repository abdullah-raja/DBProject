using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Controller
{
    abstract class ControllerModule
    {
        protected string TABLE_NAME;
        

        protected string connectionString;
        protected SqlConnection connection;

        public ControllerModule()
        {

        }

        public ControllerModule(string connectionString, string TableName)
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

        virtual public bool signUp(Model.User user, Views.SignUp view)
        {
            return false;
        }

        virtual public void signIn(Model.User user, Views.SignUp view, string enteredEmail, string enteredPassword, Model.Building apartment)
        {

        }


        virtual public void createBuilding(Model.Building building, Views.SignUp view, Model.User user)
        {
            

        }
    }
}
