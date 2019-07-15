using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Util.StoredProcedures
{
    class INSERT_TRANSACTION_SP
    {
        public static string SP_NAME = "usp_insertTransaction";
        public static string TR_ID_PARAM = "@trID";
        public static string APARTMENT_ID_PARAM = "@apartmentID";
        public static string PAID_BY_PARAM = "@paidBy";
        public static string AMOUNT_PARAM = "@amount";
        public static string DATE_PARAM = "@datePaid";
        public static string COLLECTED_BY_PARAM = "@collectedBy";
        public static string MONTH_PARAM = "@month";
    }
}
