using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace KisManager.Config
{
    /// <summary>
    /// 
    /// </summary>
    public class KisClsLogin : IKisLogin
    {
        private Type m_kisType;
        private object m_kis;

        /// <summary>
        /// 创建金蝶登录组件。运行的电脑必须安装金蝶客户端。
        /// </summary>
        public KisClsLogin()
        {
            m_kisType = Type.GetTypeFromProgID("K3Login.ClsLogin");
            if (m_kisType != null)
            {
                m_kis = Activator.CreateInstance(m_kisType);
            }
        }

        private T Kis<T>(int dispId, BindingFlags flags, params object[] args)
        {
            if (m_kis == null)
            {
                throw new NotSupportedException("当前计算机没有安装金蝶客户端");
            }
            var obj = m_kisType.InvokeMember($"[DispID={dispId}]", flags, null, m_kis, args);
            return obj == null ? default(T) : (T)obj;
        }

        public bool CheckLogin() => Kis<bool>(0x60030006, BindingFlags.InvokeMethod);

        public string UserName => Kis<string>(0x68030005, BindingFlags.GetProperty);

        public string PropsString => Kis<string>(0x68030004, BindingFlags.GetProperty);

        public object ServerMgr => Kis<object>(0x68030003, BindingFlags.GetProperty);

        public bool IsDemo => Kis<bool>(0x68030002, BindingFlags.GetProperty);

        public string AcctName => Kis<string>(0x68030001, BindingFlags.GetProperty);

        public bool IsIndustry => Kis<bool>(0x68030000, BindingFlags.GetProperty);


    }
}
