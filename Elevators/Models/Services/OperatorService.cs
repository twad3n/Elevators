using Elevators.Presenters;
using Elevators.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Models
{
    public class OperatorService: IOperatorService
    {
        public event Action MoveUp;
        public event Action MoveDown;

        

    }
}
