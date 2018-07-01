using KisManager.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Common
{
    class ConfigProvider : IConfigProvider
    {
        private const string CONFIG_FILE = "Config.json";

        private Dictionary<string, string> m_config = new Dictionary<string, string>();

        public T Get<T>(string key)
        {
            if (m_config.ContainsKey(key))
            {
                return JsonConvert.DeserializeObject<T>(m_config[key]);
            }
            return default(T);
        }

        public async Task Load()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CONFIG_FILE);
            if (!File.Exists(path))
            {
                //load default config.

                await Save();
            }
            else
            {
                m_config = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(path));
            }
        }

        public Task Save()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CONFIG_FILE);
            if (!File.Exists(path))
            {
                using (File.Create(path))
                { }
            }
            File.WriteAllText(path, JsonConvert.SerializeObject(m_config));
            return Task.FromResult(0);
        }

        public void Set<T>(string key, T value)
        {
            m_config[key] = JsonConvert.SerializeObject(value);
        }
    }
}
