using KisManager.Interfaces;
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
        Random r = new Random();
        List<object> o = new List<object>();
        public TabPersonalSalesPerformanceViewModel(IResourceProvider text)
        {
            DisplayName = text.GetText("PersonalSalesPerformance");
            Task.Factory.StartNew(() =>
            {
                Create("张宏祥");
                Create("李广操");
                Create("陈玉增");
                Create("杨显连");
                Create("吴红丽");
                Create("刘杰  ");
                Create("夏培  ");
                Create("李芳成");
                Create("张永强");
                Create("陈燕芳");
                Create("谢万福");
                Create("裴沛  ");
                Create("黄焕云");
                Create("裴中应");
                Create("刘伟强");
                Create("黄涛  ");
                Create("谢正国");
                Create("张敬涛");
                Create("蔡慈作");
                Create("黎杰  ");
                Create("黄雪艳");
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
    
        public void Create(string name)
        {
            var d1 = Math.Round(r.NextDouble() * 3000, 2);
            var d2 = Math.Round(r.NextDouble() * 5000, 2);
            o.Add(new { AreaName = name, D1 = d1, D2 = d2, D3 = Math.Round(d2 - d1, 2) });

        }

        public ObservableCollection<object> Data { get; set; } = new ObservableCollection<object>();


    }
}
