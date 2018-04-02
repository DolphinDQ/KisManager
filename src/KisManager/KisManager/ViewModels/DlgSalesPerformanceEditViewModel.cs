using Caliburn.Micro;
using KisManager.Interfaces;
using KisManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.ViewModels
{
    class DlgSalesPerformanceEditViewModel : Screen
    {
        public DlgSalesPerformanceEditViewModel(IResourceProvider res)
        {
            DisplayName = res.GetText("EditSalesPerformance");
        }

        public SalesPerformanceItem Data { get; set; }
    }
}
