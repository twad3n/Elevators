using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Models
{
    class ElevatorRepository: IElevatorRepository
    {
        private List<Man> elevatorContext = new List<Man>(20);

        public IElevatorRepository IElevatorRepository
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
