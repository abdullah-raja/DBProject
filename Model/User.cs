using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Model
{
    public class User
    {
        string userID;
        String firstName;
        String lastName;
        String email;
        String password;
        bool isAdmin;
        string mobileNumber;
        static int userCount = 0;
        string apartmentID;
        Flat userFlat;

        public User()
        {

        }

        public User(string firstName, string lastName, string email, string password, bool isAdmin, string number)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = encodePassword(password);
            this.isAdmin = isAdmin;
            this.mobileNumber = number;
            userCount++;
            

        }

        public User(string id, string firstName, string lastName, string email, string password, bool isAdmin, string number) : this(firstName,lastName,email,password,isAdmin,number)
        {
            this.userID = id;
        }


        public void setAllValues(string id, string firstName, string lastName, string email, string password, bool isAdmin, string number)
        {
            this.userID = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = encodePassword(password);
            this.isAdmin = isAdmin;
            this.mobileNumber = number;
            userCount++;
            

        }

        public void setFlat(Flat flat)
        {
            this.userFlat = flat;
            userFlat.setContactNumber(this.mobileNumber);
            userFlat.setEmail(this.email);
            userFlat.setNameOfResident(this.firstName + " " + this.lastName);
        }

        public Flat getFlat()
        {
            return this.userFlat;
        }

        //apartment getters setters
        public void setApartmentID(string id)
        {
            
            this.apartmentID = id;
        }

        public string getApartmentID()
        {
            return this.apartmentID;
        }

        // ID getter Setters
        public string getID()
        {
            return this.userID;
        }

        public void setID(string id)
        {
            this.userID = id;
        }


        // UserName Getter Setters
        public string getFirstName()
        {
            return this.firstName;
        }

        public void setUserName(string firstName)
        {
            this.firstName = firstName;
        }

        public string getLastname()
        {
            return this.lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        // Number

        public string getMobileNumber()
        {
            return this.mobileNumber;
        }

        public void setMobileNumber(string number)
        {
            this.mobileNumber = number;
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

        public static string encodePassword(string s)
        {
            string encodedString = "";
            for (int i = s.Length-1; i >= 0; i--)
            {
                encodedString += s[i];
            }

            return encodedString;

        }

        // Password Matching

        public bool checkPassowrd(string p)
        {
            return encodePassword(p) == this.password;
        }

        public string getUserStatus()
        {
            if(isAdmin)
            return "Admin";

            return "Member";
        }

        public bool getIsAdmin()
        {
            return isAdmin;
        }
    }
}
