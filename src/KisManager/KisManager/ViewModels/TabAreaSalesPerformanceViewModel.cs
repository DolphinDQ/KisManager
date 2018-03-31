using Caliburn.Micro;
using KisManager.Interfaces;
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
        Random r = new Random();
        List<object> o = new List<object>();
        private ICreator m_creator;
        private IWindowManager m_window;

        public TabAreaSalesPerformanceViewModel(IResourceProvider text, IWindowManager window, ICreator creator)
        {
            m_creator = creator;
            m_window = window;
            DisplayName = text.GetText("AreaSalesPerformance");
            Task.Factory.StartNew(() =>
            {
                Create("广东");
                Create("广西");
                Create("湖北");
                Create("河北");
                Create("海南");
                Create("湖南");
                Create("河南");
                Create("江苏");
                Create("江西");
                Create("四川");
                Create("山东");
                Create("陕西");
                Create("新疆");
                Create("云南");
                Create("浙江");
                Create("其他");
                OnUIThread(() =>
                {
                    foreach (var item in o)
                    {
                        Data.Add(item);
                    }
                    o.Clear();
                });

            });
        }

        public void Create(string name)
        {
            var d1 = Math.Round(r.NextDouble() * 3000, 2);
            var d2 = Math.Round(r.NextDouble() * 5000, 2);
            o.Add(new { Name = name, D1 = d1, D2 = d2, D3 = Math.Round(d2 - d1, 2) });
        }

        public ObservableCollection<object> Data { get; set; } = new ObservableCollection<object>();

        public void ShowAreaSalesPerformance(dynamic obj)
        {
            var dlg = m_creator.CreateDialog<DlgAreaSalesPerformanceViewModel>(o => o.Root = obj);
            m_window.ShowDialog(dlg);
        }

    }
}
