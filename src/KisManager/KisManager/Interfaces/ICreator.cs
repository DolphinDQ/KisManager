using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Interfaces
{
    public interface ICreator
    {
        T Create<T>(string name = null);
    }
}
