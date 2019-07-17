using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Util.StoredProcedures
{
    class UPDATE_EXPENSE_DETAILS_SP
    {
        public static string SP_NAME = "usp_updateExpenseDetails";
        public static string ID_PARAM = "@expenseID";
        public static string NAME_PARAM = "@name";
        public static string AMOUNT_PARAM = "@amount";
    }
}
