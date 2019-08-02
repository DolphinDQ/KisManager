using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Dal.Query
{
    public class Pagin
    {
        public int Page { get; set; }

        public int Size { get; set; }

    }

    public class Pagin<T> : Pagin
    {

        public T Condition { get; set; }
    }
}
