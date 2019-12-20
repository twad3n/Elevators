using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Presenters
{
    public interface IPresenter
    {
        void Show();

    }
    public static class Delegates
    {
        public delegate void GoToScenario();

        public delegate void GoToSettings();
    }
}
