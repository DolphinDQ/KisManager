using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Dal.Query
{
    public class Paged<T>
    {
        public int Total { get; set; }

        public T[] Data { get; set; }
    }
}
