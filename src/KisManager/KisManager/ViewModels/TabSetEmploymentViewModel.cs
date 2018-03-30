using KisManager.Interfaces;
using System;
using System.Collections.Generic;
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
    }
}
