using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Model
{
    class User
    {
        string userID;
        String userName;
        String email;
        String password;
        bool isAdmin;
        static int userCount = 0;
        

        public User(string userName, string email, string password, bool isAdmin)
        {
            this.userName = userName;
            this.email = email;
            this.password = encodePassword(password);
            this.isAdmin = isAdmin;
            userCount++;
            this.userID = "U" + userCount + DateTime.Today.Year.ToString(); // U232019
            
        }


        // ID getter Setters
        public string getID()
        {
            return this.userID;
        }



        // UserName Getter Setters
        public string getUserName()
        {
            return this.userName;
        }

        public void setUserName(string userName)
        {
            this.userName = userName;
        }


        // Email

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        // Password Getters Setters

        public string getPassword()
        {
            return this.password;
        }

        // Password Encoding Decoding

        public string encodePassword(string s)
        {
            string encodedString = "";
            for (int i = s.Length; i >= 0; i--)
            {
                encodedString += s;
            }

            return encodedString;
                
        }

        // Password Matching

        public bool checkPassowrd(string p)
        {
            return encodePassword(p) == this.password;
        }

    }
}
