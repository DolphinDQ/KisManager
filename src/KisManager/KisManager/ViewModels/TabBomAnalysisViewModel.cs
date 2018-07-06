using Caliburn.Micro;
using KisManager.Dal;
using KisManager.Dal.Kis;
using KisManager.Dal.Query;
using KisManager.Interfaces;
using KisManager.Model;
using Microsoft.Win32;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KisManager.ViewModels
{
    class TabBomAnalysisViewModel : TabModulsBase
    {
        private const int ALL_ID = -1;
        private const int MIN_YEAR = 2012;

        private IResourceProvider m_resource;

        public TabBomAnalysisViewModel(IKisLogin login,
            IEventAggregator eventAggregator,
            IResourceProvider resource) : base(login, eventAggregator)
        {
            m_resource = resource;
            DisplayName = resource.GetText("BomAnalysis");
        }

        public IEnumerable<IcBomItem> IcBomList { get; set; }
        public IEnumerable<Tuple<string, int?>> YearList { get; set; }
        public IEnumerable<Tuple<string, short?>> MonthList { get; set; }
        public IEnumerable<t_Stock> StorageList { get; set; }
        public t_Stock Storage { get; set; }
        public int? Year { get; set; } = 2016;
        public short? Month { get; set; } = 1;
        public string BomNo { get; set; }
        public string ProductNo { get; set; }

        protected override void OnContextLoad()
        {
            base.OnContextLoad();
            StorageList = new[] { new t_Stock() { FName = "<全部>", FItemID = ALL_ID } }.Concat(Context.t_Stock.Where(o => o.FName != null && !o.FName.Contains("不良")));
            Storage = StorageList.First();
            var year = new List<Tuple<string, int?>>();
            var y = MIN_YEAR;
            var t = DateTime.Today.Year;
            year.Add(Tuple.Create("<全部>", (int?)null));
            while (y <= t)
            {
                year.Add(Tuple.Create(y + "年", (int?)y));
                y++;
            }
            YearList = year;
            var month = new List<Tuple<string, short?>>();
            month.Add(Tuple.Create("<全部>", (short?)null));
            for (short i = 1; i < 13; i++)
            {
                month.Add(Tuple.Create(i + "月", (short?)i));
            }
            MonthList = month;
        }



        public override void Refresh()
        {
            base.Refresh();
            OnSearch();
        }

        private async void OnSearch()
        {
            Loading = true;
           
            Loading = false;
            //IcBomList = aa;
        }

        public void ExportToExcel()
        {
            if (IcBomList != null && IcBomList.Any())
            {
                try
                {
                    var dialog = new SaveFileDialog();
                    dialog.AddExtension = true;
                    dialog.DefaultExt = "xlsx";
                    dialog.Filter = "Excel|*.xlsx";
                    dialog.ShowDialog();
                    using (var file = File.Open(dialog.FileName, FileMode.OpenOrCreate))
                    {
                        using (var package = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("BOM报表");
                            WriteData(worksheet, 0, "序号", IcBomList.Select(o => o.Index));
                            WriteData(worksheet, 1, "BOM编号", IcBomList.Select(o => o.BomSn));
                            WriteData(worksheet, 2, "半成品/成品编码", IcBomList.Select(o => o.BomItemSn));
                            WriteData(worksheet, 3, "物料编号", IcBomList.Select(o => o.ItemSn));
                            WriteData(worksheet, 4, "物料描述", IcBomList.Select(o => o.ItemDescription));
                            WriteData(worksheet, 5, "规格", IcBomList.Select(o => o.ItemModel));
                            WriteData(worksheet, 6, "用量", IcBomList.Select(o => o.Amount));
                            WriteData(worksheet, 7, "库存数", IcBomList.Select(o => o.CountOfStorage));
                            WriteData(worksheet, 8, "任务需求数", IcBomList.Select(o => o.CountOfPlan));
                            WriteData(worksheet, 9, "数量差异", IcBomList.Select(o => o.CountOfDiff));
                            WriteData(worksheet, 10, "在途量", IcBomList.Select(o => o.CountOfOnTheWay));
                            WriteData(worksheet, 11, "最近交货期", IcBomList.Select(o => o.LastDeliverDate));
                            WriteData(worksheet, 12, "供应商", IcBomList.Select(o => o.Supplier));
                            package.SaveAs(file);
                        }
                    }

                    if (MessageBox.Show("导出成功是否打开报表？", null, MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        Process.Start("explorer", dialog.FileName);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("操作失败：" + e.Message);
                }
            }
        }

        private void WriteData<T>(ExcelWorksheet worksheet, int col, string title, IEnumerable<T> enumerable)
        {

            var arr = enumerable.ToArray();
            worksheet.Cells[1, col + 1].Value = title;
            for (int i = 0; i < arr.Length; i++)
            {
                worksheet.Cells[i + 2, col + 1].Value = arr[i];
            }
        }



        //private void Search()
        //{

        //    var baseModel = Context.ICBOM
        //         .Select(o => new IcBomItemModel { Count = o.FQty, ItemId = o.FItemID, IsSemiFinished = false })
        //         .Concat(Context.ICBOMChild
        //         .Select(o => new IcBomItemModel { Count = o.FQty, ItemId = o.FItemID, IsSemiFinished = true }))
        //         ;
        //    var onTheWay = Context.POOrder.Where(o => o.FStatus == 1).Select(o => o.FInterID);

        //    var b = baseModel.Select(o => new
        //    {
        //        Model = o,
        //        Item = Context.t_ICItem.FirstOrDefault(i => i.FItemID == o.ItemId),
        //        Storage = (decimal?)Context.ICInvBal
        //                    .Where(i => i.FItemID == o.ItemId
        //                            && i.FYear == Year
        //                            && i.FPeriod == Month
        //                            && i.FStockID == Storage.FItemID).Sum(i => i.FEndBal),
        //        Plan = (decimal?)(o.IsSemiFinished ?
        //               Context.PPBOMEntry.Where(i => i.FItemID == o.ItemId).Sum(i => i.FAuxQty) :
        //               Context.PPBOM.Where(i => i.FItemID == o.ItemId).Sum(i => i.FAuxQty)),
        //        OnTheWay = (decimal?)Context.POOrderEntry
        //                    .Where(i => onTheWay.Contains(i.FInterID) && i.FItemID == o.ItemId)
        //                    .Sum(i => i.FQty),
        //        OrderDate = (DateTime?)Context.POOrderEntry
        //                    .Where(i => onTheWay.Contains(i.FInterID) && i.FItemID == o.ItemId && i.FDate != null)
        //                    .Max(i => i.FDate),
        //        SupplierId = Context.POOrder.FirstOrDefault(i =>
        //                            Context.POOrderEntry
        //                                    .Where(p => p.FItemID == o.ItemId)
        //                                    .Select(p => p.FInterID)
        //                                    .Contains(i.FInterID)
        //                            && i.FStatus == 1)
        //    });
        //    IcBomList = b.Select(o => new IcBomItem()
        //    {
        //        ItemSn = o.Item.FNumber,
        //        ItemDescription = o.Item.FFullName,
        //        ItemModel = o.Item.FModel,
        //        Amount = o.Model.Count,
        //        CountOfStorage = o.Storage ?? 0,
        //        CountOfDiff = o.Storage ?? 0 - o.Plan ?? 0,
        //        CountOfOnTheWay = o.OnTheWay ?? 0,
        //        LastDeliverDate = o.OrderDate,
        //        Supplier = Context.t_Supplier.FirstOrDefault(i => i.FItemID == o.SupplierId.FSupplyID).FName,

        //    }).Take(1000).ToArray();
        //}

    }
}
