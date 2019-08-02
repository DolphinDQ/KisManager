using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KisManager.Sql
{
    public class SqlProvider : ISqlProvider
    {

        public string Dir { get; }

        public SqlProvider()
        {
            Dir = AppDomain.CurrentDomain.BaseDirectory + "SQL/";
            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }
        }

        public SqlBlock GetSql(string path)
        {
            var p = Dir + path;
            //p = p.EndsWith(".json") ? p : (p + ".json");
            if (!File.Exists(p))
            {
                Console.WriteLine("not exist file {0}", p);
                return null;
            }
            return p.EndsWith(".json")
                ? ReadJsonBlock(new FileInfo(p))
                : ReadSqlBlock(new FileInfo(p));
        }

        public SqlBlock[] GetSqlList(string dir)
        {
            var d = Dir + dir;
            if (!Directory.Exists(d))
            {
                Console.WriteLine("not exist dir {0}", d);
                return null;
            }
            var inf = new DirectoryInfo(d);
            var sql = inf.GetFiles("*.sql");
            var json = inf.GetFiles("*.json");
            return sql.Select(ReadSqlBlock)
                .Concat(json.Select(ReadJsonBlock))
                .Where(o => o != null)
                .ToArray();
        }

        private SqlBlock ReadSqlBlock(FileInfo sqlFile)
        {
            try
            {
                using (var s = sqlFile.OpenText())
                {
                    return new SqlBlock
                    {
                        SqlCommand = s.ReadToEnd()
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("read sql file {0} error {1}", sqlFile.FullName, e.Message);
                return null;
            }

        }

        private SqlBlock ReadJsonBlock(FileInfo jsonFile)
        {
            try
            {
                using (var s = jsonFile.OpenText())
                {
                    return JsonConvert.DeserializeObject<SqlBlock>(s.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("read json file {0} error {1}", jsonFile.FullName, e.Message);
                return null;
            }

        }
    }
}
