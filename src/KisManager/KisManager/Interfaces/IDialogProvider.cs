using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Interfaces
{
    public interface IDialogProvider
    {
        Task<object> ShowDialog(IDialogContent content);
    }
}
