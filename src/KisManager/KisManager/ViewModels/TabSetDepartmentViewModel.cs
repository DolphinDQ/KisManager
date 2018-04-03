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
    class TabSetDepartmentViewModel : TabModulsBase
    {
        public TabSetDepartmentViewModel(IResourceProvider text)
        {
            DisplayName = text.GetText("SetDepartment");
        }
        public ObservableCollection<DepartmentItem> Data { get; set; } = new ObservableCollection<DepartmentItem>();


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
                Data.OrderBy(o => o.Code);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private async Task<DepartmentItem> Create(string v, Random r)
        {
            await Task.Delay(1);
            return new DepartmentItem()
            {
                Name = v,
                Code = "D." + r.Next(100, 999),
            };
        }
    }
}
