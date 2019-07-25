using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Model
{
    public class Building
    {
        // add getNoOfFlats(), getFlat(int flatNumber)

        String appartmentName;
        int noOfFloors;
        int balance;
        string apartmentId;

        int flatsPerFloor;
        String code;
        User admin;
        int flatNumberScheme;
        Flat[,] flats;

        public Building()
        {

        }
        
        public Building(string appartmentName, int noOfFloors, int flatsPerFloor, string code, User admin, int flatNumberScheme, int balance)
        {
            this.appartmentName = appartmentName;
            this.noOfFloors = noOfFloors;
            this.flatsPerFloor = flatsPerFloor;
            this.code = code;
            this.admin = admin;
            this.flatNumberScheme = flatNumberScheme;
            this.flats = new Flat[noOfFloors, flatsPerFloor];
            this.balance = balance;
            // Create Flats Here

            for(int i = 0; i < noOfFloors; i++)
            {
                for (int j = 0; j < flatsPerFloor; j++)
                {
                    if (flatNumberScheme == 0)
                    {
                        this.flats[i, j] = new Flat(flatNumberScheme, i+1, j+1,this);
                        
                    }
                }
            }
              
            

         
        }

        // id getter setter
        public Building(string apartmentID, string apartmentName, int noOfFloors, int flatsPerFloor, string code, User admin, int flatNumberScheme, int balance):this(apartmentName,noOfFloors,flatsPerFloor,code,admin,flatNumberScheme, balance)
        {
            this.apartmentId = apartmentID;
        }

        public void setAllValues(string apartmentID, string apartmentName, int noOfFloors, int flatsPerFloor, string code, User admin, int flatNumberScheme, int balance)
        {
            this.apartmentId = apartmentID;
            this.appartmentName = apartmentName;
            this.noOfFloors = noOfFloors;
            this.flatsPerFloor = flatsPerFloor;
            this.code = code;
            this.admin = admin;
            this.flatNumberScheme = flatNumberScheme;
            this.flats = new Flat[noOfFloors, flatsPerFloor];
            this.balance = balance;
            // Create Flats Here

            for (int i = 0; i < noOfFloors; i++)
            {
                for (int j = 0; j < flatsPerFloor; j++)
                {
                    if (flatNumberScheme == 0)
                    {
                        this.flats[i, j] = new Flat(flatNumberScheme, i+1, j+1,this);
                        

                    }
                }
            }
        }

        public int getBalance()
        {
            return this.balance;
        }

        public void setBalance(int balance)
        {
            this.balance = balance;
        }

        public string getID()

        {
            return this.apartmentId;
        }



        public void setID(string id)

        {
            this.apartmentId = id;
        }

        // apartmentNAme getter Setters
        public string getAppartmentName()
        {
            return this.appartmentName;
        }
        public void setAppartmentName(string appartmentName)
        {
            this.appartmentName = appartmentName;
        }

        // noOfFloors getter Setters
        public int getNoOfFloors()
        {
            return this.noOfFloors;
        }
        public void setNoOfFloors(int noOfFloors)
        {
            this.noOfFloors = noOfFloors;
        }

        // flatsPerFloor getter Setters
        public int getFlatsPerFloor()
        {
            return this.flatsPerFloor;
        }
        public void setFlatsPerFloor(int flatsPerFloor)
        {
            this.flatsPerFloor = flatsPerFloor;
        }

        // Admin getter Setters
        public User getAdmin()
        {
            return this.admin;
        }
        public void setAdmin(User admin)
        {
            this.admin = admin;
        }

        // flatNumberScheme getter Setters
        public int getFlatNumberScheme()
        {
            return this.flatNumberScheme;
        }
        public void setFlatNumberScheme(int flatNumberScheme)
        {
            this.flatNumberScheme = flatNumberScheme;
        }

        // code getter Setters
        public String getCode()
        {
            return this.code;
        }
        public void setCode(String code)
        {
            this.code = code;
        }

        public Flat getFlatAt(int floor, int flat)
        {
            return flats[floor, flat];
            
        }

        public Flat getFlatAt(int flatNumber)
        {
            return flats[(flatNumber/100) - 1, (flatNumber%100) - 1 ];

        }

        public void setFlatAt(int floor, int flat, Flat newFlat)
        {
            flats[floor, flat] = newFlat;

        }

        public void makeAdmin(int floor, int flat)
        {
            this.flats[floor, flat].makeManager(3);
        }

        public void makeAdmin(int flatNumber)
        {
            this.flats[flatNumber/100-1, flatNumber%100-1].makeManager(3);
        }

        public Flat getAdminFlat()
        {
            Flat f = null;
            for (int i = 0; i < noOfFloors; i++)
                for (int j = 0; j < flatsPerFloor; j++)
                    if (flats[i, j].getIsManager() == 3)
                        f = flats[i, j];

            return f;
        }

    }
}
