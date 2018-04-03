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
    class TabSetEmploymentViewModel : TabModulsBase
    {
        public TabSetEmploymentViewModel(IResourceProvider res)
        {
            DisplayName = res.GetText("SetEmployment");
        }
        public ObservableCollection<EmployeeItem> Data { get; set; } = new ObservableCollection<EmployeeItem>();

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
                Data.OrderBy(o => o.Code);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private async Task<EmployeeItem> Create(string name, Random r)
        {
            await Task.Delay(1);
            return new EmployeeItem()
            {
                Name = name,
                Code = "D." + (r.Next() % 2 == 0 ? "H." : "") + r.Next(10000, 99999),
                Email = r.Next(1000000, 999999999) + "@qq.com",
                Gender = r.Next() % 2 == 0,
                MobilePhone = (r.Next() % 2 == 0 ? "133" : "138") + r.Next(10000000, 99999999)
            };
        }

    }
}
