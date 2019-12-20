using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elevators.Views;
using Ninject;

namespace Elevators.Presenters
{
    public class MainPresenter: IMainPresenter
    {
        public IMainPresenter _mainView;
        public IKernel _kernel;

        public event Delegates.GoToSettings GoToSettings;

        public MainPresenter (IKernel kernel, IMainPresenter mainMenu)
        {
            _mainView = mainMenu;
            _kernel = kernel;

            _mainView.GoToSettings += _mainView_GoToSettings;
        }

        private void _mainView_GoToSettings()
        {
            _kernel.Get<SettingsPresenter>().Run();
        }

        public void ShowSettingsMenu()
        {
            _kernel.Get<SettingsPresenter>().Run();
            //_mainView.Close();
        }



        public void Show()
        {
            _kernel.Get<MainPresenter>().Run();
        }

        public void Run()
        {
            _mainView.Show();
        }
    }
}
