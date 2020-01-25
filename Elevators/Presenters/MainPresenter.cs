using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elevators.Views;
using Ninject;
using Elevators.Models;

namespace Elevators.Presenters
{

    public class MainPresenter
    {
        public IKernel _kernel;
        public IMainView _mainView;
        public IOperatorService _operatorService;
        //public IControllerService _controllerService;


        public MainPresenter (IKernel kernel, IMainView mainMenu, IOperatorService operatorService/*, IControllerService controllerService*/)
        {
            _mainView = mainMenu;
            _kernel = kernel;
            _operatorService = operatorService;
            //_controllerService = controllerService;

            _mainView.GoToSettings += _GoToSettings;
            _mainView.AddMan += _AddMan;
            _mainView.MoveUpABit += _MoveUp;

            _operatorService.MoveUp += _MoveUp;
            _operatorService.MoveDown += _MoveDown;
        }

        private void _AddMan()
        {
            
        }

        private void _MoveUp()
        {
            _mainView._MoveUpElevator();
        }
        private void _MoveDown()
        {

        }

        private void _GoToSettings()
        {
            _kernel.Get<SettingsPresenter>().Run();
            _mainView.Close();
        }

        public void Run()
        {
            _mainView.Show();
        }
    }
}
