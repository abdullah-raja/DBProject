using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Util.StoredProcedures
{
    class INSERT_EXPENSE_SP
    {
        public static String SP_NAME = "usp_InsertExpense";
        public static string ID_PARAM = "@expenseID";
        public static string APARTMENT_ID_PARAM = "@apartmentID";
        public static string NAME_PARAM = "@name";
        public static string AMOUNT_PARAM = "@amount";
        public static string TYPE_PARAM = "@type";
        public static string STATUS_PARAM = "@status";
        public static string MONTH_PARAM = "@month";
        public static string YEAR_PARAM = "@year";
    }
}
