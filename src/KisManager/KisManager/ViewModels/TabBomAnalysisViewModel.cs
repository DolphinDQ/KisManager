using Caliburn.Micro;
using KisManager.Dal.Kis;
using KisManager.Interfaces;
using KisManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.ViewModels
{
    class TabBomAnalysisViewModel : TabModulsBase
    {
        private IKisLogin m_login;
        private IResourceProvider m_resource;

        public KisContext Context { get; private set; }

        public IEnumerable<IcBomItem> IcBomList { get; set; }

        public TabBomAnalysisViewModel(IResourceProvider resource, IKisLogin login)
        {
            m_login = login;
            m_resource = resource;
            DisplayName = resource.GetText("BomAnalysis");
        }

        protected override void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);
            Refresh();
        }

        public int Year { get; set; } = 2016;

        public short Month { get; set; } = 1;

        public int StockId { get; set; } = 9;

        public override void Refresh()
        {
            base.Refresh();
            Loading = true;
            if (Context == null)
            {
                var str = m_login.GetConnectionString();
                Context = new KisContext(str);
                Loading = false;
            }
            var baseModel = Context.ICBOM
                 .Select(o => new IcBomItemModel { Count = o.FQty, ItemId = o.FItemID, IsSemiFinished = false })
                 .Concat(Context.ICBOMChild
                 .Select(o => new IcBomItemModel { Count = o.FQty, ItemId = o.FItemID, IsSemiFinished = true }))
                 ;
            var onTheWay = Context.POOrder.Where(o => o.FStatus == 1).Select(o => o.FInterID);

            var b = baseModel.Select(o => new
            {
                Model = o,
                Item = Context.t_ICItem.FirstOrDefault(i => i.FItemID == o.ItemId),
                Storage = (decimal?)Context.ICInvBal
                            .Where(i => i.FItemID == o.ItemId
                                    && i.FYear == Year
                                    && i.FPeriod == Month
                                    && i.FStockID == StockId).Sum(i => i.FEndBal),
                Plan = (decimal?)0, //(decimal?)(o.IsSemiFinished ?
                                    // Context.PPBOMEntry.Where(i => i.FItemID == o.ItemId).Sum(i => i.FAuxQty) :
                                    // Context.PPBOM.Where(i => i.FItemID == o.ItemId).Sum(i => i.FAuxQty)),
                OnTheWay = (decimal?)Context.POOrderEntry
                            .Where(i => onTheWay.Contains(i.FInterID) && i.FItemID == o.ItemId)
                            .Sum(i => i.FQty),
                OrderDate = (DateTime?)Context.POOrderEntry
                            .Where(i => onTheWay.Contains(i.FInterID) && i.FItemID == o.ItemId && i.FDate != null)
                            .Max(i => i.FDate),
                Supplier = Context.POOrder.FirstOrDefault(i =>
                                    Context.POOrderEntry
                                            .Where(p => p.FItemID == o.ItemId)
                                            .Select(p => p.FInterID)
                                            .Contains(i.FInterID)
                                    && i.FStatus == 1)
            });
            IcBomList = b.Select(o => new IcBomItem()
            {
                BomLayer = o.Model.ItemId,
                ItemId = o.Item.FNumber,
                ItemDescription = o.Item.FFullName,
                ItemModel = o.Item.FModel,
                Amount = o.Model.Count,
                CountOfStorage = o.Storage ?? 0,
                CountOfDiffProduct = o.Storage ?? 0 - o.Plan ?? 0,
                CountOfOnTheWayProduct = o.OnTheWay ?? 0,
                BuyInterval = o.OrderDate,
                Supplier = o.Supplier == null ? null : o.Supplier.FSupplyID+"",

            }).Take(1000).ToArray();
            IcBomList.Aggregate(0, (i, o) => o.Index = ++i);
        }

        public override void TryClose(bool? dialogResult = null)
        {
            base.TryClose(dialogResult);
            if (Context != null)
            {
                try
                {
                    Context.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    Context = null;
                }
            }
        }
    }
}
