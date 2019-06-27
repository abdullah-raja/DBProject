using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Model
{
    class User
    {
        int ID;
        String userName;
        String email;
        String password;
        bool isAdmin;
        Building building;

        public User(string userName, string email, string password, bool isAdmin)
        {
            if(isAdmin)
            {
                // CREATE BUILDING HERE
            }

            else
            {
                // JOIN BUILDING
            }
        }
    }
}
