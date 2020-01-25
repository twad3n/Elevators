using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Models
{
    public class Elevator: BasicEntity
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

        public Elevator(int id, int floor)
        {
            this.ID = ID;
            this.currentFloor = floor;
        }


    }
}
