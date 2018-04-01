using Caliburn.Micro;
using KisManager.Interfaces;
using KisManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager
{
    public static class GlobalExtensions
    {
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

    }
}
