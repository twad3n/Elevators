using Elevators.Models.Repositories;
using Elevators.Presenters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Views
{
    public interface ISettingsView: IBasicView
    {
        event Action GoToScenario;
        event Action ApplySettings;
        event Action<int, int> SettingsChanged;
        event Action<string> ImportSettings;
        event Action<string> ExportSettings;
        event Action SettingsUpdated;

        void UpdateSettingsField(Settings settings);
        void Show();
        void Close();
    }
}
