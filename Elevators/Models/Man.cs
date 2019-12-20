﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Models
{
    public class Man: BasicEntity, IMan
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

        private int currentFloor
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
    }
}
