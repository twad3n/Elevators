using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elevators.Views;
using Elevators.Models;

namespace Elevators.Presenters
{
    public interface ISettingsPresenter: IPresenter
    {
        event Delegates.GoToScenario GoToScenario;

        void Show();
        void Close();
    }
}
