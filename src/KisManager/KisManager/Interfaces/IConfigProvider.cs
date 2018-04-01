using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Interfaces
{
    /// <summary>
    /// 配置提供者。
    /// </summary>
    public interface IConfigProvider
    {
        T Get<T>(string key);

        void Set<T>(string key, T value);

        Task Load();

        Task Save();
    }
}
