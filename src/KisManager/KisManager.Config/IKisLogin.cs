using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KisManager
{
    public interface IKisLogin
    {
        string AcctName { get; }
        bool IsDemo { get; }
        bool IsIndustry { get; }
        string PropsString { get; }
        object ServerMgr { get; }
        string UserName { get; }
        bool CheckLogin();
    }
}
