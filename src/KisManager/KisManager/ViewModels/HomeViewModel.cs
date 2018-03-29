using Caliburn.Micro;
using KisManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.ViewModels
{
    class HomeViewModel : Screen, IHome
    {
        private ICreator m_creator;

        public HomeViewModel(ICreator creator)
        {
            m_creator = creator;
        }

        public ObservableCollection<IModule> Modules { get; set; } = new ObservableCollection<IModule>();

        public IModule ActiveModule { get; set; }

        public void Close(IModule obj)
        {
            obj.CanClose(o =>
            {
                if (o)
                {
                    obj.TryClose();
                    Modules.Remove(obj);
                    if (obj == ActiveModule)
                    {
                        ActiveModule = Modules.FirstOrDefault();
                    }
                }
            });
        }

        public void Open(string moduleName)
        {
            var module = Modules.FirstOrDefault(o => o.GetType().Name == moduleName);
            if (module != null)
            {
                if (!module.CanMultiCreate)
                {
                    ActiveModule = module;
                    return;
                }
            }
            module = m_creator.Create<IModule>(moduleName);
            if (module != null)
            {
                Modules.Add(module);
                ActiveModule = module;
            }
        }
    }
}
