using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Models
{
    class ElevatorRepository
    {
        private List<Elevator> elevatorContext = new List<Elevator>(20);
        private int _endIndex = 0;

        public int Add(Elevator elevator)
        {
            elevator.ID = _endIndex;
            _endIndex++;
            elevatorContext.Add(elevator);
            return elevator.ID;
        }

        public void Remove(int id)
        {
            elevatorContext.RemoveAll(elevator => elevator.ID == id);
        }
    }
}
