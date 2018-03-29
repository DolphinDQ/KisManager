using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Interfaces
{
    /// <summary>
    /// 模块通用接口
    /// </summary>
    public interface IModule : IScreen
    {
        /// <summary>
        /// 是否可以重复创建。
        /// </summary>
        bool CanMultiCreate { get; set; }
    }
}
