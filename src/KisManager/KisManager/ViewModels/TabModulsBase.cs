using Caliburn.Micro;
using KisManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.ViewModels
{
    public abstract class TabModulsBase : Screen, IModule
    {
        public bool CanMultiCreate { get; set; } = false;

        public TabModulsBase()
        {
            DisplayName = GetType().Name;
        }
    }
}
