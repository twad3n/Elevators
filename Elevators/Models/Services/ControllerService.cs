using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Models.Services
{
    class ControllerService
    {
        ManRepository _manRepository;
        ElevatorRepository _elevatorRepository;

        public ControllerService (ManRepository manRepository, ElevatorRepository elevatorRepository)
        {
            _manRepository = manRepository;
            _elevatorRepository = elevatorRepository;
        }

        public void AddMan(int id, int floor)
        {
            _manRepository.Add(new Man(id, floor));
        }

        /*public void AddElevator(int id, int floor)
        {
            _elevatorRepository.Add(new Elevator(id, floor));
        }*/

    }
}
