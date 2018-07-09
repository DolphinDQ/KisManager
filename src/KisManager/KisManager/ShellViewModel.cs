using Caliburn.Micro;
using KisManager.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace KisManager
{
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive, IShell
    {
        private IConfigProvider m_config;
        private Dictionary<string, IScreen> m_screens;

        public ShellViewModel(IHome home, ISettings settings, IConfigProvider config)
        {
            m_config = config;
            m_screens = new Dictionary<string, IScreen>();
            m_screens.Add(nameof(IHome), home);
            m_screens.Add(nameof(ISettings), settings);
            Nav(nameof(IHome));
        }

        protected override async void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);
            await m_config.Load();
        }

        public void Nav(string page)
        {
            if (m_screens.ContainsKey(page))
            {
                ActivateItem(m_screens[page]);
            }
        }

    }
}