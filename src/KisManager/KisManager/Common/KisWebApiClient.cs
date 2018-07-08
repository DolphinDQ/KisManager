using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using KisManager.Dal;
using KisManager.Dal.Kis;
using KisManager.Dal.Query;
using KisManager.Interfaces;

namespace KisManager.Common
{
    public class KisWebApiClient : IWebApi
    {
        private readonly HttpClient m_client;

        public KisWebApiClient(IConfigProvider config)
        {
            m_client = new HttpClient();
            m_client.BaseAddress = new Uri(config.GetApiUrl());
        }

        private string SerializeUrlParameters(string rawUri, object parameters)
        {
            if (parameters is null)
            {
                return rawUri;
            }
            var result = parameters.GetType().GetProperties()
                .ToDictionary(x => x.Name, x => x.GetValue(parameters)?.ToString());

            return string.Format("{0}?{1}", rawUri, string.Join("&", result.Select(kvp => string.Format("{0}={1}", kvp.Key, HttpUtility.UrlEncode(kvp.Value)))));
        }

        public async Task<T> PostAsync<T>(string resource, object parameters = null, object body = null)
        {
            var requestUri = SerializeUrlParameters(resource, parameters);
            using (var response = await m_client.PostAsJsonAsync(requestUri, body))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsAsync<T>();
            }
        }

        public async Task<T> GetAsync<T>(string resource, object parameters = null)
        {
            var requestUri = SerializeUrlParameters(resource, parameters);
            using (var response = await m_client.GetAsync(requestUri))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsAsync<T>();
            }
        }

    }
}
