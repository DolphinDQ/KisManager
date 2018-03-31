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
    class DlgAreaSalesPerformanceViewModel : Screen
    {
        private IWindowManager m_window;
        private ICreator m_creator;
        private IResourceProvider m_res;

        public DlgAreaSalesPerformanceViewModel(IResourceProvider res, IWindowManager window, ICreator creator)
        {
            m_window = window;
            m_creator = creator;
            m_res = res;
        }
        public dynamic Root { get; set; }

        protected override void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);
            DisplayName = Root.Name + "-" + m_res.GetText("AreaSalesPerformance");
            Task.Factory.StartNew(() =>
            {
                Create("何林坚");
                Create("王亚海");
                Create("李永建");
                Create("欧盛邦");
                Create("李孝洋");
                Create("罗云华");
                Create("梅阳  ");
                Create("陶静  ");
                Create("丘增明");
                Create("苏永福");
                Create("郭丕敬");
                Create("蔡剑豪");
                foreach (var item in o)
                {
                    OnUIThread(() =>
                    {
                        Data.Add(item);
                    });
                }
                o.Clear();
            });
        }

        Random r = new Random();
        List<object> o = new List<object>();
        public void Create(string name)
        {
            var d1 = Math.Round(r.NextDouble() * 3000, 2);
            var d2 = Math.Round(r.NextDouble() * 5000, 2);
            o.Add(new { Name = name, D1 = d1, D2 = d2, D3 = Math.Round(d2 - d1, 2) });

        }
        public ObservableCollection<object> Data { get; set; } = new ObservableCollection<object>();

        public dynamic CurrentData { get; set; }

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


    }
}
