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

        private Settings _repository;
        private JsonSerializer _serializer;
        public SettingsService(Settings repository)
        {
            _repository = repository;
            _serializer = new JsonSerializer();
        }

        public void ImportSettings(StreamReader reader)
        {
            List<Settings> settings = (List<Settings>)_serializer.Deserialize(reader, typeof(List<Settings>));
            foreach (var c in settings)
            {
                _repository = c;
            }

            //CharacterUpdated?.Invoke();
        }

        public void ExportSettings(StreamWriter writer)
        {
            _serializer.Serialize(writer, _repository);
        }


    }
}
