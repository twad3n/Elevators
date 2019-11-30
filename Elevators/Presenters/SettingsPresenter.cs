using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Presenters
{
    public class SettingsPresenter: ISettingsPresenter
    {
        public IMainPresenter _mainMenu;
        public ISettingsPresenter _settingsMenu;
        public IKernel _kernel;

        //public event Action GoToSettings;


        public SettingsPresenter(IKernel kernel, ISettingsPresenter settingsMenu, IMainPresenter mainMenu)
        {
            _settingsMenu = settingsMenu;
            _kernel = kernel;
            _mainMenu = mainMenu;

        }


        public void Show()
        {
            _kernel.Get<SettingsPresenter>().Run();
        }
        public void Run()
        {
            _settingsMenu.Show();
        }
    }
}
