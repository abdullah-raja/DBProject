using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBproject.Model;
using DBproject.Views;

namespace DBproject.Controller
{
    class CreateAndJoinBuilding : ControllerModule
    {
        public CreateAndJoinBuilding(string connectionString, string TableName) : base(connectionString, TableName)
        {


        }

        public override bool createBuilding(Building building, SignUp view)
        {
            return false;
        }
    }
}
