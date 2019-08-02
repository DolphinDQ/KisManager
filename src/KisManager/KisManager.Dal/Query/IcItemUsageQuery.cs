using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Dal.Query
{
    public class IcItemUsageQuery
    {

        public int? Year { get; set; }

        public short? Month { get; set; }

        public int? StockId { get; set; }

        public int? ItemCount { get; set; }

        public string ItemNo { get; set; }
    }
}
