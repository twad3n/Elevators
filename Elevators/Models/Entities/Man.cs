using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Models
{
    public class Man: BasicEntity
    {
        public int ID;
        public int currentFloor;


        public Man(int id, int floor)
        {
            this.ID = id;
            this.currentFloor = floor;
        }



    }
}
