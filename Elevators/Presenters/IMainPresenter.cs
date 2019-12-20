using Elevators.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Presenters
{
    public interface IMainPresenter: IPresenter
    {
        event Delegates.GoToSettings GoToSettings;
        //public MainView _mainView { get; set; }


        void Show();
    }
}
