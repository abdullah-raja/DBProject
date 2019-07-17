using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Util.StoredProcedures
{
    class INSERT_OUT_TR_SP
    {
        public static string SP_NAME = "usp_insertOutgoingTransaction";
        public static string TR_ID_PARAM = "@trID";
        public static string EXPENSE_ID_PARAM = "@expenseID";
        public static string DATE_PARAM = "@date";
    }
}
