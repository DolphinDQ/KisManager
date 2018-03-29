using Caliburn.Micro;
using KisManager.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace KisManager
{
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive, IShell
    {

        private Dictionary<string, IScreen> m_screens;

        public ShellViewModel(IHome home, ISettings settings)
        {
            m_screens = new Dictionary<string, IScreen>();
            m_screens.Add(nameof(IHome), home);
            m_screens.Add(nameof(ISettings), settings);
            Nav(nameof(IHome));
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