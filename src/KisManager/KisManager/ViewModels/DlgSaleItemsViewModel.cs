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
    class DlgSaleItemsViewModel : Screen
    {
        public bool Loading { get; set; } = false;
        public DlgSaleItemsViewModel(IResourceProvider resource)
        {
            DisplayName = resource.GetText("SaleItemsDetail");
        }

        public ObservableCollection<SaleItem> Data { get; set; } = new ObservableCollection<SaleItem>();

        protected override async void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);
            if (Data.Any()) return;
            await Task.Delay(500);
            Random r = new Random();

            try
            {
                Data.Add(await Create("张宏祥", "银禾秀水分散颗粒剂", r));
                Data.Add(await Create("李广操", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("陈玉增", "耀都水悬浮剂     ", r));
                Data.Add(await Create("杨显连", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("吴红丽", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("刘杰  ", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("夏培  ", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("李芳成", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("张永强", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("陈燕芳", "农舟行微乳剂     ", r));
                Data.Add(await Create("谢万福", "农舟行微乳剂     ", r));
                Data.Add(await Create("裴沛  ", "农舟行微乳剂     ", r));
                Data.Add(await Create("黄焕云", "农舟行微乳剂     ", r));
                Data.Add(await Create("裴中应", "农舟行微乳剂     ", r));
                Data.Add(await Create("刘伟强", "农精灵水悬浮剂   ", r));
                Data.Add(await Create("黄涛  ", "农精灵水悬浮剂   ", r));
                Data.Add(await Create("谢正国", "农精灵水悬浮剂   ", r));
                Data.Add(await Create("张敬涛", "农精灵水悬浮剂   ", r));
                Data.Add(await Create("蔡慈作", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("黎杰  ", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("黄雪艳", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("何林坚", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("王亚海", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("李永建", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("欧盛邦", "农舟行微乳剂     ", r));
                Data.Add(await Create("李孝洋", "农舟行微乳剂     ", r));
                Data.Add(await Create("罗云华", "银锐水分散颗粒剂 ", r));
                Data.Add(await Create("梅阳  ", " 银锐水分散颗粒剂 ", r));
                Data.OrderBy(o => o.Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private async Task<SaleItem> Create(string name, string itemName, Random r)
        {
            await Task.Delay(1);
            var price = r.NextDouble() * r.Next(10, 999);
            return new SaleItem()
            {
                Salesman = name,
                Name = itemName,
                OutStorageDate = DateTime.Now - TimeSpan.FromMinutes(r.Next(30 * 24 * 60, 2 * 365 * 24 * 60)),
                Id = "11.01.0"+r.Next(10, 99),
                OutStorageId = "XOUT" + r.Next(10000, 99999),
                ConsignPrice = Math.Round(price, 2),
                ConsignAmount = Math.Round(price * (1 + r.NextDouble()), 2)
            };
        }
    }
}
