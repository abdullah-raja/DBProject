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
             

    }
}
