using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Model
{
    class Building
    {
        // add getNoOfFlats(), getFlat(int flatNumber)
        String appartmentName;
        int noOfFloors;
        int apartmentId;
        int flatsPerFloor;
        String code;
        User admin;
        int flatNumberScheme;
        Flat[,] flats;
        
        public Building(string appartmentName, int noOfFloors, int flatsPerFloor, string code, User admin, int flatNumberScheme)
        {
            this.appartmentName = appartmentName;
            this.noOfFloors = noOfFloors;
            this.flatsPerFloor = flatsPerFloor;
            this.code = code;
            this.admin = admin;
            this.flatNumberScheme = flatNumberScheme;
            this.flats = new Flat[noOfFloors, flatsPerFloor];
            // Create Flats Here

            for(int i = 0; i < noOfFloors; i++)
            {
                for (int j = 0; j < flatsPerFloor; j++)
                {
                    if (flatNumberScheme == 0)
                    {
                        this.flats[i, j] = new Flat(flatNumberScheme, i, j);
                        
                    }
                }
            }
              
            

         
        }

        // id getter setter

        public int getID()
        {
            return this.apartmentId;
        }

        public void setID(int id)
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
    }
}
