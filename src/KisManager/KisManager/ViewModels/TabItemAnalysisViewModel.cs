using Caliburn.Micro;
using KisManager.Dal.Kis;
using KisManager.Dal.Query;
using KisManager.Interfaces;
using Microsoft.Win32;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KisManager.ViewModels
{
    class TabItemAnalysisViewModel : TabModulsBase
    {

        private const int ALL_ID = -1;
        private const int MIN_YEAR = 2012;

        private IResourceProvider m_resource;
        private IWebApi m_api;

        public TabItemAnalysisViewModel(IKisLogin login,
            IWebApi api,
            IEventAggregator eventAggregator,
            IResourceProvider resource) : base(login, eventAggregator)
        {
            m_resource = resource;
            m_api = api;
            DisplayName = resource.GetText("ItemAnalysis");
            Pagin = new Pagin<IcItemUsageQuery>()
            {
                Condition = new IcItemUsageQuery()
                {
                    Year = 2018,
                    Month = 1,
                },
                Page = 0,
                Size = 50
            };
        }

        public IEnumerable<Tuple<string, int?>> YearList { get; set; }
        public IEnumerable<Tuple<string, short?>> MonthList { get; set; }
        public IEnumerable<Tuple<string, int?>> StorageList { get; set; }
        public Paged<IcItemUsage> Paged { get; set; }
        public Pagin<IcItemUsageQuery> Pagin { get; set; }

        public IcItemUsageQuery Condition => Pagin?.Condition;

        protected override async void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);
            var storage = new List<Tuple<string, int?>>();
            storage.Add(Tuple.Create("<全部>", (int?)null));
            try
            {
                storage.AddRange((await m_api.GetIcAsync<IEnumerable<t_Stock>>(o => nameof(o.GetStockes))).Where(o => o.FName != null && !o.FName.Contains("不良")).Select(o => Tuple.Create(o.FName, (int?)o.FItemID)));
            }
            catch (Exception e)
            {
                MessageBox.Show("获取仓库列表失败:{0}", e.Message);
            }
            //StorageList = new[] { new t_Stock() { FName = "<全部>", FItemID = ALL_ID } }.Concat(Context.t_Stock.Where(o => o.FName != null && !o.FName.Contains("不良")));
            StorageList = storage;
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


        public int PagedTotal { get; set; }


        public override void Refresh()
        {
            base.Refresh();
            OnSearch();
        }

        private async void OnSearch()
        {
            if (string.IsNullOrWhiteSpace( Pagin.Condition.ItemNo))
            {
                MessageBox.Show("请输入物料编号");
                return;
            }
            Loading = true;
            try
            {
                Paged = await m_api.PostIcAsync<Paged<IcItemUsage>>(o => nameof(o.QueryItemUsage), null, Pagin);
                PagedTotal = Paged.Total;
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("错误：{0}", e.Message));
            }
            Loading = false;
            //IcBomList = aa;
        }

        public void ExportToExcel()
        {
            var IcBomList = Paged?.Data;
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
                            WriteData(worksheet, 1, "物料编号", IcBomList.Select(o => o.ItemSn));
                            WriteData(worksheet, 2, "物料描述", IcBomList.Select(o => o.ItemDescription));
                            WriteData(worksheet, 3, "规格", IcBomList.Select(o => o.ItemModel));
                            WriteData(worksheet, 4, "单位用量", IcBomList.Select(o => o.Unit));
                            WriteData(worksheet, 5, "需用量", IcBomList.Select(o => o.Amount));
                            WriteData(worksheet, 6, "库存数", IcBomList.Select(o => o.CountOfStorage));
                            WriteData(worksheet, 7, "任务需求数", IcBomList.Select(o => o.CountOfPlan));
                            WriteData(worksheet, 8, "数量差异", IcBomList.Select(o => o.CountOfDiff));
                            WriteData(worksheet, 9, "在途量", IcBomList.Select(o => o.CountOfOnTheWay));
                            WriteData(worksheet, 10, "最近交货期", IcBomList.Select(o => o.LastDeliverDate));
                            WriteData(worksheet, 11, "供应商", IcBomList.Select(o => o.Supplier));
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
    }
}
