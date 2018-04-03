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
    class TabPersonalSalesPerformanceViewModel : TabModulsBase
    {
        private ICreator m_creator;
        private IWindowManager m_window;

        public TabPersonalSalesPerformanceViewModel(IResourceProvider text, IWindowManager window, ICreator creator)
        {
            m_creator = creator;
            m_window = window;
            DisplayName = text.GetText("PersonalSalesPerformance");

        }


        protected override async void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);
            if (Data.Any()) return;
            await Task.Delay(500);
            Random r = new Random();
            try
            {
                Data.Add(await Create("张宏祥", r));
                Data.Add(await Create("李广操", r));
                Data.Add(await Create("陈玉增", r));
                Data.Add(await Create("杨显连", r));
                Data.Add(await Create("吴红丽", r));
                Data.Add(await Create("刘杰  ", r));
                Data.Add(await Create("夏培  ", r));
                Data.Add(await Create("李芳成", r));
                Data.Add(await Create("张永强", r));
                Data.Add(await Create("陈燕芳", r));
                Data.Add(await Create("谢万福", r));
                Data.Add(await Create("裴沛  ", r));
                Data.Add(await Create("黄焕云", r));
                Data.Add(await Create("裴中应", r));
                Data.Add(await Create("刘伟强", r));
                Data.Add(await Create("黄涛  ", r));
                Data.Add(await Create("谢正国", r));
                Data.Add(await Create("张敬涛", r));
                Data.Add(await Create("蔡慈作", r));
                Data.Add(await Create("黎杰  ", r));
                Data.Add(await Create("黄雪艳", r));
                Data.Add(await Create("何林坚", r));
                Data.Add(await Create("王亚海", r));
                Data.Add(await Create("李永建", r));
                Data.Add(await Create("欧盛邦", r));
                Data.Add(await Create("李孝洋", r));
                Data.Add(await Create("罗云华", r));
                Data.Add(await Create("梅阳  ", r));
                Data.Add(await Create("陶静  ", r));
                Data.Add(await Create("丘增明", r));
                Data.Add(await Create("苏永福", r));
                Data.Add(await Create("郭丕敬", r));
                Data.Add(await Create("蔡剑豪", r));
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

        public void ShowSalesPerformance(SalesPerformanceItem obj)
        {
            var dlg = m_creator.CreateDialog<DlgSalesPerformanceForCustomerViewModel>(o => o.Root = obj);
            m_window.ShowDialog(dlg);
        }

    }
}
