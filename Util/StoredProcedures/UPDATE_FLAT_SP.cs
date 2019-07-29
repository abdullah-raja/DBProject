using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Util.StoredProcedures
{
    class UPDATE_FLAT_SP
    {
        public static string SP_NAME = "usp_updateFlat";
        public static string FLAT_NUM_PARAm = "@flatNumber", EMAIL_PARAM = "@email",
            MOBILE_NUM_PARAM = "@mobileNumber", DUES_PARAM = "@dues", FEE_PARAM = "@monthlyFee", APARTMENT_ID_PARAM = "@apartmentID",
            NAME_PARAM = "@name", IS_MANAGER_PARAM = "@manager";


    }
}
