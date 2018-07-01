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
        /// Bom编号
        /// </summary>
        public string BomSn { get; set; }
        /// <summary>
        /// 半成品/成品编码
        /// </summary>
        public string BomItemSn { get; set; }
        /// <summary>
        /// 物料编码
        /// </summary>
        public string ItemSn { get; set; }
     
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
        /// 计划数量（任务需求数量）
        /// </summary>
        public decimal CountOfPlan { get; set; }
        /// <summary>
        /// 数量差异
        /// </summary>
        public decimal CountOfDiff { get; set; }
        /// <summary>
        /// 在路上
        /// </summary>
        public decimal CountOfOnTheWay { get; set; }
        /// <summary>
        /// 采购周期。
        /// </summary>
        public DateTime? LastDeliverDate { get; set; }
        /// <summary>
        /// 供应商。
        /// </summary>
        public string Supplier { get; set; }
    }
}
