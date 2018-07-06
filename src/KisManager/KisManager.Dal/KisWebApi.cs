using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KisManager.Dal.Kis;
using KisManager.Dal.Query;

namespace KisManager.Dal
{
    public class KisWebApi : IKisApi
    {

        public KisWebApi(string apiUrl)
        {
            BaseUrl = apiUrl;

        }

        public string BaseUrl { get; }

        public IEnumerable<t_Stock> GetStockes()
        {
            throw new NotImplementedException();
        }

        public Paged<IcBomItem> QueryIcBomReport(Pagin<IcBomReportQuery> pagin)
        {
            throw new NotImplementedException();
        }
    }
}
