using Caliburn.Micro;
using KisManager.Interfaces;
using KisManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.ViewModels
{
    class TabAreaSalesPerformanceViewModel : TabModulsBase
    {
        private ICreator m_creator;
        private IWindowManager m_window;

        public TabAreaSalesPerformanceViewModel(IResourceProvider text, IWindowManager window, ICreator creator)
        {
            m_creator = creator;
            m_window = window;
            DisplayName = text.GetText("AreaSalesPerformance");

        }


        protected override async void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);
            if (Data.Any()) return;
            await Task.Delay(500);
            Random r = new Random();
            try
            {
                Data.Add(await Create("广东", r));
                Data.Add(await Create("广西", r));
                Data.Add(await Create("湖北", r));
                Data.Add(await Create("河北", r));
                Data.Add(await Create("海南", r));
                Data.Add(await Create("湖南", r));
                Data.Add(await Create("河南", r));
                Data.Add(await Create("江苏", r));
                Data.Add(await Create("江西", r));
                Data.Add(await Create("四川", r));
                Data.Add(await Create("山东", r));
                Data.Add(await Create("陕西", r));
                Data.Add(await Create("新疆", r));
                Data.Add(await Create("云南", r));
                Data.Add(await Create("浙江", r));
                Data.Add(await Create("其他", r));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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

        public void ShowSalesPerformance(SalesPerformanceItem obj)
        {
            var dlg = m_creator.CreateDialog<DlgSalesPerformanceForCustomerViewModel>(o => o.Root = obj);
            m_window.ShowDialog(dlg);
        }


    }
}
