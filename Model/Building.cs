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
        List<Flat> flats;
        
        public Building(string appartmentName, int noOfFloors, int flatsPerFloor, string code, User admin, int flatNumberScheme)
        {
            this.appartmentName = appartmentName;
            this.noOfFloors = noOfFloors;
            this.flatsPerFloor = flatsPerFloor;
            this.code = code;
            this.admin = admin;
            this.flatNumberScheme = flatNumberScheme;

            // Create Flats Here
        }
       
    }
}
