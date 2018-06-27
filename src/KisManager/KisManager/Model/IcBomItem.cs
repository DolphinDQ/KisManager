using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Model
{
    public class IcBomItem
    {

        /// <summary>
        /// 序列号
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// Bom层次
        /// </summary>
        public int BomLayer { get; set; }
        /// <summary>
        /// 物料编号
        /// </summary>
        public string ItemId { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string ItemDescription { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string ItemModel { get; set; }
        /// <summary>
        /// 用量
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 库存数
        /// </summary>
        public decimal CountOfStorage { get; set; }
        /// <summary>
        /// 不良品
        /// </summary>
        public decimal CountOfBadProduct { get; set; }
        /// <summary>
        /// 未登记
        /// </summary>
        public decimal CountOfDiffProduct { get; set; }
        /// <summary>
        /// 在路上
        /// </summary>
        public decimal CountOfOnTheWayProduct { get; set; }
        /// <summary>
        /// 采购周期。
        /// </summary>
        public DateTime? BuyInterval { get; set; }
        /// <summary>
        /// 供应商。
        /// </summary>
        public string Supplier { get; set; }
    }
}
