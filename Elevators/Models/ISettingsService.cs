using Elevators.Models.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Models
{
    public interface ISettingsService
    {

        //IEnumerable<string> GetAllCharacters();
        Settings ImportSettings(StreamReader reader);
        void ExportSettings(StreamWriter writer, Settings settings);
    }
}