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
using Newtonsoft.Json;

namespace Elevators.Presenters
{
    public class SettingsPresenter
    {
        private IKernel _kernel;
        private ISettingsView _view;
        private ISettingsService _service;
        public Settings _settings;

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
            _view.SettingsUpdated += _SettingsUpdated;
        }

        public void _ImportSettings(string filePath)
        {
            try
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    _settings = _service.ImportSettings(reader);
                    
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("error while reading");
            }
            
        }



        public void _ExportSettings(string filePath)
        {
            try
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    _service.ExportSettings(writer, _settings);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("error while reading");
            }
        }

        public void _SettingsUpdated()
        {
            _view.UpdateSettingsField(_settings);
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
            MainPresenter pres = _kernel.Get<MainPresenter>();
            pres._settings = this._settings;
            pres._mainView.GetSettings(this._settings);
            pres.Run();
            //_kernel.Get<MainPresenter>().Run();
            _view.Close();
        }




        public void UpdateSettings(Settings settings)
        {

        }

        public void Run()
        {
            _view.Show();
        }

    }
}
