using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Util
{
    class CONNECTION_DETAILS
    {
       // public static string CONNECITION_STRING = "Data Source=HAIER-PC;Initial Catalog=Project_Database;Integrated Security=True";
        public static string CONNECITION_STRING => ConfigurationManager.ConnectionStrings["Default Connection"].ConnectionString;
    }
}
