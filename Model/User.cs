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
        

        public User(string userName, string email, string password, bool isAdmin)
        {
            this.userName = userName;
            this.email = email;
            this.password = password;
            this.isAdmin = isAdmin;

            
        }
    }
}
