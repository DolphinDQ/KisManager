﻿using KisManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.ViewModels
{
    class TabSalesPerformanceReportViewModel : TabModulsBase
    {
        public TabSalesPerformanceReportViewModel(IResourceProvider text)
        {
            DisplayName = text.GetText("SalesPerformanceReport");
        }

    }
}
