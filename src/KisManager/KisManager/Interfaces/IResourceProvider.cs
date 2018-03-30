using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Interfaces
{
    interface IResourceProvider
    {
        string GetText(string key);

        object Resource(string key);
    }
}
