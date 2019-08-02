using KisManager.Dal.Kis;
using KisManager.Dal.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Dal
{
    public interface IKisIcApi
    {
        IEnumerable<t_Stock> GetStockes();
        Paged<IcBomItem> QueryIcBomReport(Pagin<IcBomReportQuery> pagin);
        Paged<IcItemUsage> QueryItemUsage(Pagin<IcItemUsageQuery> pagin);
    }
}
