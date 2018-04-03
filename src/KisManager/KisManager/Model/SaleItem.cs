using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Model
{
    class SaleItem
    {
        public string Id { get; set; }

        public string OutStorageId { get; set; }

        public DateTime OutStorageDate { get; set; }

        public string Salesman { get; set; }

        public string Name { get; set; }

        public double ConsignPrice { get; set; }

        public double ConsignAmount { get; set; }
    }
}
