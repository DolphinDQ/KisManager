using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KisManager.Dal;
using KisManager.Dal.Kis;
using KisManager.Dal.Query;
using KisManager.Interfaces;

namespace KisManager.Common
{
    public class KisWebApi : IKisApi
    {

        public KisWebApi(IConfigProvider config)
        {
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
