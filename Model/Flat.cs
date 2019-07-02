using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Model
{
    class Flat
    {
        int flatNumber;
        int floor;
        string nameOfResident;
        string email;
        string contactNumber;
        int dues;
        int monthlyFees;
        User member;

        public Flat(int flatNumberScheme, int floor, int index)
        {
            this.floor = floor;
            if(flatNumberScheme == 0)
            {
                int f = (floor * 100) + index;
            }
            
        }
        

        //flatNumber getter Setters
        public int getflatNumber()
        {
            return this.flatNumber;
        }
        public void setflatNumber(int flatNumber)
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
        public string getnameOfResident()
        {
            return this.nameOfResident;
        }
        public void setnameOfResident(string nameOfResident)
        {
            this.nameOfResident = nameOfResident;
        }

        // email getter Setters
        public String getemail()
        {
            return this.email;
        }
        public void setemail(String email)
        {
            this.email = email;
        }

        // contactNumber getter Setters
        public String getcontactNumber()
        {
            return this.contactNumber;
        }
        public void setcontactNumber(String contactNumber)
        {
            this.contactNumber = contactNumber;
        }

       

        // dues getter Setters
        public int getdues()
        {
            return this.dues;
        }
        public void setdues(int dues)
        {
            this.dues = dues;
        }

        // monthlyFees getter Setters
        public int getmonthlyFees()
        {
            return this.monthlyFees;
        }
        public void setmonthlyFees(int monthlyFees)
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
    }
}
