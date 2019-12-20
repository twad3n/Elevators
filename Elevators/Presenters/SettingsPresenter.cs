using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elevators.Views;

namespace Elevators.Presenters
{
    public class SettingsPresenter
    {
        private IKernel _kernel;
        private ISettingsView _view;

        public event Delegates.GoToScenario GoToScenario;


        public SettingsPresenter(IKernel kernel, ISettingsView view)
        {
            _kernel = kernel;
            _view = view;

            _view.GoToScenario += _view_GoToScenario;
        }

        private void _view_GoToScenario()
        {
            _kernel.Get<ScenarioPresenter>().Run();
        }

        public void Show()
        {
            _kernel.Get<SettingsPresenter>().Run();
        }
        public void Run()
        {
            _view.Show();
            //_settingsMenu.Show();
        }
        public void Close()
        {

        }
    }
}
