using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject.Model
{
    class Building
    {
        String appartmentName;
        int noOfFloors;
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
        // apartmentNAme getter Setters
        public string getappartmentName()
        {
            return this.appartmentName;
        }
        public void setappartmentName(string appartmentName)
        {
            this.appartmentName = appartmentName;
        }

        // noOfFloors getter Setters
        public int getnoOfFloors()
        {
            return this.noOfFloors;
        }
        public void setnoOfFloors(int noOfFloors)
        {
            this.noOfFloors = noOfFloors;
        }

        // flatsPerFloor getter Setters
        public int getflatsPerFloor()
        {
            return this.flatsPerFloor;
        }
        public void setflatsPerFloor(int flatsPerFloor)
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
        public int getflatNumberScheme()
        {
            return this.flatNumberScheme;
        }
        public void setflatNumberScheme(int flatNumberScheme)
        {
            this.flatNumberScheme = flatNumberScheme;
        }

        // code getter Setters
        public String getcode()
        {
            return this.code;
        }
        public void setcode(String code)
        {
            this.code = code;
        }
    }
}
