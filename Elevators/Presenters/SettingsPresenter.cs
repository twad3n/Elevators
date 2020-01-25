using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elevators.Views;
using Elevators.Models;
using System.IO;
using Elevators.Models.Services;
using Elevators.Models.Repositories;

namespace Elevators.Presenters
{
    public class SettingsPresenter
    {
        private IKernel _kernel;
        private ISettingsView _view;
        private ISettingsService _service;
        private Settings _settings;

        public SettingsPresenter(IKernel kernel, ISettingsView view, ISettingsService service, Settings settings)
        {
            _kernel = kernel;
            _view = view;
            _service = service;
            _settings = settings;

            _view.GoToScenario += _GoToScenario;
            _view.ImportSettings += _ImportSettings;
            _view.ExportSettings += _ExportSettings;
            _view.ApplySettings += _ApplySettings;
            _view.SettingsChanged += _SettingsChanged;
        }

        public void _ImportSettings(string filePath)
        {
            try
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    _service.ImportSettings(reader);
                }
            }
            catch (Exception ex)
            {
                //_view.ShowError(ex.Message);
            }
        }

        public void _ExportSettings(string filePath)
        {
            try
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    _service.ExportSettings(writer);
                }
            }
            catch (Exception ex)
            {
                //_view.ShowError(ex.Message);
            }
        }
        
        public void _SettingsChanged(int floors, int elevators)
        {
            _settings.numberOfElevators = elevators;
            _settings.numberOfFloors = floors;
        }

        private void _GoToScenario()
        {
            _kernel.Get<ScenarioPresenter>().Run();
            _view.Close();
        }

        private void _ApplySettings()
        {
            _kernel.Get<MainPresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }

    }
}
