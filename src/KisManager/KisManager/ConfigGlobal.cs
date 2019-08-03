using KisManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager
{
    public static class ConfigGlobal
    {
        public const string KEY_API_URL = "KEY_API_URL";

        public static string GetApiUrl(this IConfigProvider provider)
        {
            var url = provider.Get(KEY_API_URL);
            if (url == null)
            {
                url = "http://127.0.0.1:8888/api/";
                provider.SetApiUrl(url);
            }
            return url;
        }

        public static async void SetApiUrl(this IConfigProvider provider, string url)
        {
            provider.Set(KEY_API_URL, url);
            await provider.Save();
            await provider.Load();
        }
    }
}
