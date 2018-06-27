using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
