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
        public TabAreaSalesPerformanceViewModel(ITextProvider text)
        {
            DisplayName = text.GetText("AreaSalesPerformance");
            Data.Add(new { AreaName = "区域1", D1 = 1111, D2 = 2222, D3 = 3333 });
            Data.Add(new { AreaName = "区域1", D1 = 1111, D2 = 2222, D3 = 3333 });
            Data.Add(new { AreaName = "区域1", D1 = 1111, D2 = 2222, D3 = 3333 });
            Data.Add(new { AreaName = "区域1", D1 = 1111, D2 = 2222, D3 = 3333 });
        }

        public ObservableCollection<object> Data { get; set; } = new ObservableCollection<object>();


    }
}
