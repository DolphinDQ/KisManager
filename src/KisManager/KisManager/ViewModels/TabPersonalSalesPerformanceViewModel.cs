using KisManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.ViewModels
{
    class TabPersonalSalesPerformanceViewModel : TabModulsBase
    {
        public TabPersonalSalesPerformanceViewModel(IResourceProvider text)
        {
            DisplayName = text.GetText("PersonalSalesPerformance");
        }

    }
}
