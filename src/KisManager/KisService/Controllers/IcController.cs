using KisManager.Dal;
using KisManager.Dal.Kis;
using KisManager.Dal.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace KisService.Controllers
{
    public class IcController : ApiController, IKisApi
    {
        public KisContext Context { get; }
        public IcController(KisContext kisContext)
        {
            Context = kisContext;
        }


        public IHttpActionResult Get()
        {
            return Json(Context.ICBOM.FirstOrDefault());
        }

        public IEnumerable<t_Stock> GetStockes()
        {
            return Context.t_Stock.ToArray();
        }

        public Paged<IcBomItem> QueryIcBomReport(Pagin<IcBomReportQuery> pagin)
        {
            if (pagin == null) return null;
            var condition = pagin.Condition ?? new IcBomReportQuery();
            var baseModel = Context.ICBOMChild.Select(i =>
                new
                {
                    Bom = Context.ICBOM.FirstOrDefault(o => o.FInterID == i.FInterID),
                    Child = i,
                    BomItem = Context.t_ICItem.FirstOrDefault(o => o.FItemID == Context.ICBOM.FirstOrDefault(p => p.FInterID == i.FInterID).FItemID),
                    ChildItem = Context.t_ICItem.FirstOrDefault(o => o.FItemID == i.FItemID),
                    Storage = (decimal?)Context.ICInvBal.Where(o =>
                                o.FItemID == i.FItemID
                                && (condition.Year == null || o.FYear == condition.Year)
                                && (condition.Month == null || o.FPeriod == condition.Month)
                                && (condition.StockId == null ? (Context.t_Stock.Where(p => !p.FName.Contains("不良")).Any(p => p.FItemID == o.FStockID)) : (o.FStockID == condition.StockId))
                                ).Sum(o => o.FEndBal),
                    Plan = (decimal?)Context.PPBOMEntry
                                    .Join(Context.PPBOM, o => o.FInterID, o => o.FInterID, (a, b) => new { Entry = a, PP = b })
                                    .Where(o => o.Entry.FItemID == i.FItemID && o.PP.FStatus == 1 && (o.Entry.FAuxQtyPick != o.Entry.FAuxStockQty))
                                    .Sum(o => o.Entry.FAuxQty),
                    OnTheWay = (decimal?)Context.POOrderEntry.Where(o => o.FItemID == i.FItemID && Context.POOrder.Any(p => p.FInterID == o.FInterID && p.FStatus == 1)).Sum(o => o.FQty),
                    LastDeliverDate = (DateTime?)Context.POOrderEntry.Where(o => Context.POOrder.Any(p => p.FInterID == o.FInterID && p.FStatus == 1) && o.FItemID == i.FItemID).Max(o => o.FDate),
                    Order = Context.POOrder.FirstOrDefault(o => o.FStatus == 1 && Context.POOrderEntry.Any(p => p.FItemID == i.FItemID && p.FInterID == o.FInterID))
                });
            var query = baseModel.Select(o => new IcBomItem
            {
                BomSn = o.Bom.FBOMNumber,
                BomItemSn = o.BomItem.FNumber,
                ItemSn = o.ChildItem.FNumber,
                ItemDescription = o.ChildItem.FName,
                ItemModel = o.ChildItem.FModel,
                Amount = o.Child.FQty,
                CountOfStorage = o.Storage == null ? 0 : o.Storage.Value,
                CountOfPlan = o.Plan == null ? 0 : o.Plan.Value,
                CountOfOnTheWay = o.OnTheWay == null ? 0 : o.OnTheWay.Value,
                LastDeliverDate = o.LastDeliverDate,
                Supplier = o.Order == null ? null : Context.t_Supplier.FirstOrDefault(i => i.FItemID == o.Order.FSupplyID).FName
            });
            return query.QueryPaging(pagin, (tmp, c) =>
            {
                if (!string.IsNullOrWhiteSpace(c.BomNo))
                {
                    tmp = tmp.Where(o => !string.IsNullOrEmpty(o.BomSn) && o.BomSn.Contains(c.BomNo));
                }
                if (!string.IsNullOrWhiteSpace(c.ProductNo))
                {
                    tmp = tmp.Where(o => !string.IsNullOrEmpty(o.ItemSn) && o.ItemSn.Contains(c.ProductNo));
                }
                var list = tmp.ToArray();
                list.Aggregate(0, (i, o) =>
                {
                    o.CountOfDiff = o.CountOfStorage - o.CountOfPlan;
                    var index = o.Index = ++i;
                    return index;
                });
                return list.AsQueryable();
            });

        }

    }
}
