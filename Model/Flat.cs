using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Model
{
    public class Flat
    {
        int flatNumber;
        int floor;
        string nameOfResident;
        string email;
        string contactNumber;
        int dues;
        int monthlyFees;
        bool isManager;
        User member;
        Building apartment;
        

        public Flat(int flatNumberScheme, int floor, int index, Building apartment)
        {
            this.apartment = apartment;
            this.floor = floor;
            if(flatNumberScheme == 0)
            {
                int f = (floor * 100) + index;
                this.flatNumber = f;
            }

            
            
        }

        public Flat(int flatNumber, string nameOfResident,string email,string contactNumber,int dues, int monthlyFees, bool isManager, Building apartment)
        {
            this.flatNumber = flatNumber;
            this.floor = flatNumber - 100;
            this.nameOfResident = nameOfResident;
            this.email = email;
            this.contactNumber = contactNumber;
            this.dues = dues;
            this.monthlyFees = monthlyFees;
            this.isManager = isManager;
            this.apartment = apartment;

        }
        

        //flatNumber getter Setters
        public int getFlatNumber()
        {
            return this.flatNumber;
        }
        public void setFlatNumber(int flatNumber)
        {
            this.flatNumber = flatNumber;
        }

        // floor getter Setters
        public int getfloor()
        {
            return this.floor;
        }
        public void setfloor(int floor)
        {
            this.floor = floor;
        }

        // nameOfResident getter Setters
        public string getNameOfResident()
        {
            return this.nameOfResident;
        }
        public void setNameOfResident(string nameOfResident)
        {
            this.nameOfResident = nameOfResident;
        }

        // email getter Setters
        public String getEmail()
        {
            return this.email;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }

        // contactNumber getter Setters
        public String getContactNumber()
        {
            return this.contactNumber;
        }
        public void setContactNumber(String contactNumber)
        {
            this.contactNumber = contactNumber;
        }

       

        // dues getter Setters
        public int getDues()
        {
            return this.dues;
        }
        public void setDues(int dues)
        {
            this.dues = dues;
        }

        // monthlyFees getter Setters
        public int getMonthlyFees()
        {
            return this.monthlyFees;
        }
        public void setMonthlyFees(int monthlyFees)
        {
            this.monthlyFees = monthlyFees;
        }

        // Member getter Setters
        public User getMember()
        {
            return this.member;
        }
        public void setMember(User member)
        {
            this.member = member;
        }

        public Building getApartment()
        {
            return this.apartment;
        }

        public bool getIsManager()
        {
            return this.isManager;
        }

        
    }
}
