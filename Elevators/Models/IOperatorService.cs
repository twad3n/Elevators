﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Models
{
    public interface IOperatorService
    {
        event Action MoveUp;
        event Action MoveDown;


    }
}
