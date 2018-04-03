using Caliburn.Micro;
using KisManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KisManager.Model;
using System.Windows;

namespace KisManager.ViewModels
{
    class DlgSalesPerformanceForCustomerViewModel : Screen
    {
        private IWindowManager m_window;
        private ICreator m_creator;
        private IResourceProvider m_res;

        public DlgSalesPerformanceForCustomerViewModel(IResourceProvider res, IWindowManager window, ICreator creator)
        {
            DisplayName = "客户绩效";
            m_window = window;
            m_creator = creator;
            m_res = res;
        }
        public SalesPerformanceItem Root { get; set; }

        protected override async void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);
            if (Data.Any()) return;
            await Task.Delay(500);
            Random r = new Random();
            try
            {
                Data.Add(await Create("安徽安庆市 冯定平         ", r));
                Data.Add(await Create("安徽安庆市容和农资有限公司 ", r));
                Data.Add(await Create("安徽灵壁县光灵农资有限公司 ", r));
                Data.Add(await Create("东至县创丰农资有限公司     ", r));
                Data.Add(await Create("安徽铜陵县兴农农资经营部   ", r));
                Data.Add(await Create("安徽宿松县维农农资经营部   ", r));
                Data.Add(await Create("安徽太和县金土地农化有限公司", r));
                Data.Add(await Create("安徽无为县城南农药经营部   ", r));
                Data.Add(await Create("安徽合肥润禾农业科技有限公司", r));
                Data.Add(await Create("安徽省明光市绿野农化有限公司", r));
                Data.Add(await Create("安徽省蚌埠五河县青松农资总汇", r));
                Data.Add(await Create("安徽南陵红宝种业有限公司   ", r));
                Data.Add(await Create("安徽省舒城县李军农资经营部 ", r));
            }
            catch (Exception)
            {
            }
        }


        public async Task<SalesPerformanceItem> Create(string name, Random r)
        {
            await Task.Delay(1);
            var d1 = Math.Round(r.NextDouble() * 3000, 2);
            var d2 = Math.Round(r.NextDouble() * 5000, 2);
            return new SalesPerformanceItem
            {
                Name = name,
                Actual = d1 * 12,
                Expect = d2 * 12,
                M1Actual = d1,
                M2Actual = d1,
                M3Actual = d1,
                M4Actual = d1,
                M5Actual = d1,
                M6Actual = d1,
                M7Actual = d1,
                M8Actual = d1,
                M9Actual = d1,
                M10Actual = d1,
                M11Actual = d1,
                M12Actual = d1,
                M1Except = d2,
                M2Except = d2,
                M3Except = d2,
                M4Except = d2,
                M5Except = d2,
                M6Except = d2,
                M7Except = d2,
                M8Except = d2,
                M9Except = d2,
                M10Except = d2,
                M11Except = d2,
                M12Except = d2,
                M1Different = Math.Round(d2 - d1, 2),
                M2Different = Math.Round(d2 - d1, 2),
                M3Different = Math.Round(d2 - d1, 2),
                M4Different = Math.Round(d2 - d1, 2),
                M5Different = Math.Round(d2 - d1, 2),
                M6Different = Math.Round(d2 - d1, 2),
                M7Different = Math.Round(d2 - d1, 2),
                M8Different = Math.Round(d2 - d1, 2),
                M9Different = Math.Round(d2 - d1, 2),
                M10Different = Math.Round(d2 - d1, 2),
                M11Different = Math.Round(d2 - d1, 2),
                M12Different = Math.Round(d2 - d1, 2),
            };
        }

        public ObservableCollection<SalesPerformanceItem> Data { get; set; } = new ObservableCollection<SalesPerformanceItem>();

        public override void TryClose(bool? dialogResult = null)
        {
            base.TryClose(dialogResult);
            Data.Clear();
        }

        public SalesPerformanceItem CurrentData { get; set; }

        public void Edit()
        {
            if (CurrentData != null)
            {
                var dlg = m_creator.CreateDialog<DlgSalesPerformanceEditViewModel>(o => o.Data = CurrentData);
                var arg = new Dictionary<string, object>();
                arg.Add("Width", 470);
                arg.Add("Height", 560);
                arg.Add("ResizeMode", 0);
                m_window.ShowDialog(dlg, null, arg);
            }
        }

        public void Reload()
        {

        }

        public void Save()
        {

        }
        public void ShowSalesPerformance(SalesPerformanceItem obj)
        {
            if (CurrentData != null)
            {
                var dlg = m_creator.CreateDialog<DlgSaleItemsViewModel>();
                var arg = new Dictionary<string, object>();
                arg.Add("Width", 640);
                arg.Add("Height", 480);
                m_window.ShowDialog(dlg, null, arg);
            }

        }

    }
}
