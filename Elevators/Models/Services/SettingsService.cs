using Elevators.Models.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Models.Services
{
    public class SettingsService: ISettingsService
    {

        private Settings settings;
        private JsonSerializer _serializer;
        public SettingsService(Settings repository)
        {
            settings = repository;
            _serializer = new JsonSerializer();
        }

        public Settings ImportSettings(StreamReader reader)
        {
            var jsonTextReader = new JsonTextReader(reader);
            return (Settings)_serializer.Deserialize<Settings>(jsonTextReader) as Settings;
        }

        public void ExportSettings(StreamWriter writer, Settings settings)
        {
            this.settings = settings;
            _serializer.Serialize(writer, this.settings);
        }


    }
}
