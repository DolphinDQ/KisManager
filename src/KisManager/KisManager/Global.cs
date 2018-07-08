using Caliburn.Micro;
using KisManager.Dal;
using KisManager.Interfaces;
using KisManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KisManager
{
    public static class Global
    {

        public static string GetConnectionString(this IKisLogin login)
        {
            if (login.CheckLogin())
            {
                try
                {
                    var str = login.PropsString;
                    var start = str.IndexOf('{');
                    var end = str.IndexOf('}');
                    str = str.Substring(start + 1, end - start - 1);
                    var providerStart = str.IndexOf("Provider=");
                    var providerEnd = str.IndexOf(';', providerStart);
                    return str.Replace(str.Substring(providerStart, providerEnd - providerStart + 1), "");
                }
                catch (Exception)
                {
                }
                return null;

            }
            return null;
        }

        public static object CreateDialog<T>(this ICreator creator, Action<T> setting = null)
           where T : IScreen
        {
            var dlg = creator.Create<DlgViewModel>();
            var content = creator.Create<T>();
            setting?.Invoke(content);
            dlg.Content = content;
            return dlg;
        }

        public static string Get(this IConfigProvider config, string key) => config.Get<string>(key);

        public static Task<T> PostIcAsync<T>(this IWebApi api, Func<IKisIcApi, string> method, object parameters = null, object body = null)
        {
            return api.PostAsync<T>("ic/" + method(null), parameters, body);
        }
        public static Task<T> GetIcAsync<T>(this IWebApi api, Func<IKisIcApi, string> method, object parameters = null)
        {
            return api.GetAsync<T>("ic/" + method(null), parameters);
        }

        
    }
}
