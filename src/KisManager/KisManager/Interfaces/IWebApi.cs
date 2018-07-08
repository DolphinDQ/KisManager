using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Interfaces
{
    public interface IWebApi
    {
        Task<T> PostAsync<T>(string resource, object parameters = null, object body = null);
        Task<T> GetAsync<T>(string resource, object parameters = null);
    }
}
