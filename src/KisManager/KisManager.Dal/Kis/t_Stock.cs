namespace KisManager.Dal.Kis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_Stock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FItemID { get; set; }

        [Required]
        [StringLength(10)]
        public string FBrNO { get; set; }

        [StringLength(30)]
        public string FHelperCode { get; set; }

        public int? FEmpID { get; set; }

        [StringLength(255)]
        public string FAddress { get; set; }

        [StringLength(30)]
        public string FPhone { get; set; }

        public short? FProperty { get; set; }

        public int? FBWorkShop { get; set; }

        [StringLength(80)]
        public string FName { get; set; }

        [StringLength(80)]
        public string FNumber { get; set; }

        public int? FParentID { get; set; }

        public short FDeleted { get; set; }

        [StringLength(30)]
        public string FShortNumber { get; set; }

        public int FTypeID { get; set; }

        public bool FIsStockMgr { get; set; }

        public int FSPGroupID { get; set; }

        public bool FMRPAvail { get; set; }

        public int FGroupID { get; set; }

        public int FStockGroupID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] FModifyTime { get; set; }

        public int? FCalcCostOrder { get; set; }

        public int? FPlanArea { get; set; }

        public int FUnderStock { get; set; }

        public bool FIncludeAccounting { get; set; }
    }
}
