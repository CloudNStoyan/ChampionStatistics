using System.IO;
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
