using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Model
{
    /// <summary>
    /// 表中间模型。
    /// </summary>
    public class IcBomItemModel
    {
        public decimal Count { get; set; }

        public int ItemId { get; set; }
        /// <summary>
        /// 是否是半成品。
        /// </summary>
        public bool IsSemiFinished { get; set; }

    }
}
