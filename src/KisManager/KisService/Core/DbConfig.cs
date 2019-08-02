using KisManager;
using KisManager.Dal.Kis;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KisService.Core
{
    class DbConfig
    {
        public DbConfig(KisContext context, ISqlProvider provider)
        {
            Context = context;
            m_provider = provider;
        }

        public DbContext Context { get; }

        private ISqlProvider m_provider;

        public void Init()
        {
            var sql = m_provider.GetSqlList("Init/");
            if (sql != null && sql.Any())
            {
                try
                {
                    foreach (var item in sql)
                    {
                        var s = SplitSql(item.ToString());
                        foreach (var ss in s)
                        {
                            if (!string.IsNullOrWhiteSpace(ss))
                            {
                                Context.Database.ExecuteSqlCommand(ss);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("db config init error :" + e);
                }
            }
        }

        private IEnumerable<string> SplitSql(string sqlString)
        {
            var collection = Regex.Matches(sqlString, @"\n*\s*GO\s*\n*", RegexOptions.IgnoreCase);
            var result = new List<string>();
            if (collection.Count == 0)
            {
                result.Add(sqlString);
            }
            else
            {
                var index = 0;
                foreach (Match item in collection)
                {
                    result.Add(sqlString.Substring(index, item.Index - index));
                    index = item.Index + item.Length;
                }
            }
            return result;
        }
    }
}
