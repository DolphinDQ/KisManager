using KisManager.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KisManager
{
    public interface ISqlProvider
    {
        SqlBlock[] GetSqlList(string dir);

        SqlBlock GetSql(string path);
    }
}
