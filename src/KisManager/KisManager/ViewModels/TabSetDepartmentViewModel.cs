using KisManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.ViewModels
{
    class TabSetDepartmentViewModel : TabModulsBase
    {
        public TabSetDepartmentViewModel(ITextProvider text)
        {
            DisplayName = text.GetText("SetDepartment");
        }
    }
}
