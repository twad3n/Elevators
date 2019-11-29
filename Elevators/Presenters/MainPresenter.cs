using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elevators.Views;

namespace Elevators.Presenters
{
    public class MainPresenter: IMainPresenter
    {
        private MainView _mainView;

        MainPresenter (MainView mainMenu)
        {
            this._mainView = mainMenu;
        }

        public void Run()
        {
            _mainView.Show();
        }
    }
}
