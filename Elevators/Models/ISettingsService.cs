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
        void ImportSettings(StreamReader reader);
        void ExportSettings(StreamWriter writer);

    }
}