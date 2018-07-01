using Caliburn.Micro;
using KisManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.EventArgs
{
    public class EvtTabClose
    {
        public EvtTabCloseReson Reason { get; set; }

        public string Message { get; set; }

        public TabModulsBase Tab { get; set; }
    }

    public enum EvtTabCloseReson
    {
        None,
        Error,
        NoLogin
    }
}
