using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Models
{
    public class Elevator: BasicEntity, IElevator
    {
        public UInt32 ID
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

        public int floorPosition
        {
            get
            {
                return floorPosition;
            }
            set
            {
                floorPosition = value;
            }
        }

        public int numberOfJobs;

        public Elevator(UInt32 ID)
        {
            this.ID = ID;
            numberOfJobs = 0;
        }
    }
}
