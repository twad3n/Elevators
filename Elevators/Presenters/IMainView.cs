using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Elevators.Models;
using Elevators.Models.Repositories;

namespace Elevators.Views
{
    public interface IMainView: IBasicView
    {
        event Action GoToSettings;
        event Action Start;
        event Action Pause;
        event Action Stop;
        event Action AddMan;
        event Action MoveUpABit;
        event Action MoveDownABit;

        void GetSettings(Settings settings);
        void _AddMan(Man man);

        void Show();
        void Close();
        void _MoveUpElevator();
        void _MoveDownElevator();
    }
}
