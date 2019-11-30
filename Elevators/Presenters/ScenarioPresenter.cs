using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elevators.Views;

namespace Elevators.Presenters
{
    public class ScenarioPresenter
    {
        private IKernel _kernel;
        private IScenarioView _view;

        //public event Action GoToSettings;


        public ScenarioPresenter(IKernel kernel, IScenarioView view)
        {
            _kernel = kernel;
            _view = view;
        }


        public void Show()
        {
            _kernel.Get<ScenarioPresenter>().Run();
        }
        public void Run()
        {
            _view.Show();
            //_settingsMenu.Show();
        }
    }
}
