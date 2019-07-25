using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Util.StoredProcedures
{
    class UPDATE_FLAT_USER_SP
    {
        public static string SP_NAME = "usp_updateFlatUser";
        public static string USER_ID_PARAM = "@userID", EMAIL_PARAM = "@email",
            MOBILE_NUM_PARAM = "@mobileNumber", APARTMENT_ID_PARAM = "@apartmentID",
            NAME_PARAM = "@name", IS_MANAGER_PARAM = "@manager", FLAT_PARAM = "@flatNumber";
    }
}
