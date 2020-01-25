using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Models
{
    public class Man: BasicEntity
    {
        public int ID
        {
            get
            {
                return this.ID;
            }

            set
            {
                this.ID = value;
            }
        }

        public int currentFloor
        {
            get
            {
                return currentFloor;
            }
            set
            {
                currentFloor = value;
            }
        }


        public Man(int id, int floor)
        {
            this.ID = id;
            this.currentFloor = floor;
        }



    }
}
