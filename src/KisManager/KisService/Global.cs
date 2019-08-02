using KisManager;
using KisManager.Dal.Query;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisService
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

        public static Paged<T> QueryPaging<T, C>(this IQueryable<T> ts, Pagin<C> pagin, Func<IQueryable<T>, C, IQueryable<T>> filter)
            where C : class, new()
        {
            pagin.Condition = pagin.Condition ?? new C();
            var items = filter(ts, pagin.Condition);
            return new Paged<T>()
            {
                Data = items.Skip(pagin.Page * pagin.Size).Take(pagin.Size).ToArray(),
                Total = items.Count(),
            };
        }

        public static Paged<T> QueryPaging<T>(this Database db, string sql, Pagin pagin, params SqlParameter[] parameters)
        {
            var a = $@"select count(*) from ({sql}) x";
            var total = db.SqlQuery<int>(a, parameters.ToArray()).FirstOrDefault();
            sql = $@"
                select * from ({sql})  t where t.pageIndex between @p_begin and @p_end
                ";
            var param = new List<SqlParameter>()
            {
                new SqlParameter("p_begin", pagin.Page * pagin.Size + 1),
                new SqlParameter("p_end", pagin.Page * pagin.Size + pagin.Size)
            };
            foreach (var item in parameters)
            {
                param.Add(new SqlParameter(item.ParameterName, item.Value));
            }
            var data = db.SqlQuery<T>(sql, param.ToArray()).ToArray();
            return new Paged<T>
            {
                Total = total,
                Data = data
            };
        }

    }
}
