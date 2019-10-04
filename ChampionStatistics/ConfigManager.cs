using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ChampionStatistics
{
    public class ConfigManager<T>
    {
        public T ConfigClass { get; }

        public ConfigManager(string path)
        {
            this.ConfigClass = JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
        }
    }
}
