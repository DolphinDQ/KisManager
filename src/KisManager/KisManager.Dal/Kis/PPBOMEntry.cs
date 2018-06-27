namespace KisManager.Dal.Kis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PPBOMEntry")]
    public partial class PPBOMEntry
    {
        [Required]
        [StringLength(10)]
        public string FBrNo { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FInterID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FEntryID { get; set; }

        public int FItemID { get; set; }

        [StringLength(200)]
        public string FBatchNo { get; set; }

        public int FUnitID { get; set; }

        public decimal FQtyMust { get; set; }

        public decimal FAuxQtyMust { get; set; }

        public decimal FQty { get; set; }

        public decimal FAuxQty { get; set; }

        [StringLength(1000)]
        public string FMachinePos { get; set; }

        [StringLength(30)]
        public string FSequenceID { get; set; }

        public int? FStockID { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public int FSourceEntryID { get; set; }

        public decimal FQtyScrap { get; set; }

        public decimal FAuxQtyScrap { get; set; }

        public decimal FScrap { get; set; }

        public DateTime? FSendItemDate { get; set; }

        public decimal FQtyPick { get; set; }

        public decimal FAuxQtyPick { get; set; }

        public int FSPID { get; set; }

        public int FMaterielType { get; set; }

        public int FOperID { get; set; }

        public int FBackFlush { get; set; }

        public int FMarshalType { get; set; }

        public bool FStockType { get; set; }

        public decimal FQtyBackFlush { get; set; }

        public decimal FStockQty { get; set; }

        public decimal FAuxStockQty { get; set; }

        public decimal? FAuxQtyLoss { get; set; }

        public decimal? FQtyLoss { get; set; }

        public decimal? FBOMInPutQTY { get; set; }

        public decimal? FWIPQTY { get; set; }

        public decimal? FWIPAuxQTY { get; set; }

        public short FLockFlag { get; set; }

        public decimal FSelDiscardQty { get; set; }

        public decimal FSelDiscardAuxQty { get; set; }

        public decimal FDiscardQty { get; set; }

        public decimal FDiscardAuxQty { get; set; }

        public decimal FBomInputAuxQty { get; set; }

        public int FICItemReplaceID { get; set; }

        public decimal FQtySupply { get; set; }

        public decimal FAuxQtySupply { get; set; }

        public int FOperSN { get; set; }

        public int FBomInterID { get; set; }

        public decimal FSelTransLateAuxQty { get; set; }

        public decimal FSelTransLateQty { get; set; }

        public decimal FTransLateAuxQty { get; set; }

        public decimal FTransLateQty { get; set; }

        public int FICMOInterID { get; set; }

        public int FChangeTimes { get; set; }

        [Required]
        [StringLength(4000)]
        public string FPositionNo { get; set; }

        [Required]
        [StringLength(255)]
        public string FItemSize { get; set; }

        [Required]
        [StringLength(255)]
        public string FItemSuite { get; set; }

        [Required]
        [StringLength(255)]
        public string FNote1 { get; set; }

        [Required]
        [StringLength(255)]
        public string FNote2 { get; set; }

        [Required]
        [StringLength(255)]
        public string FNote3 { get; set; }

        public int FPlanMode { get; set; }

        [Required]
        [StringLength(50)]
        public string FMTONo { get; set; }

        public int FOrderEntryID { get; set; }

        public decimal FQtyConsume { get; set; }

        public decimal FAuxQtyConsume { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FDetailID { get; set; }

        public int FItemConvertType { get; set; }

        public int FSubsBillEntryID { get; set; }

        public Guid? FBomDetailID { get; set; }

        public int FICSubsID { get; set; }

        public int FICSubsEntryID { get; set; }

        public short FIsKeyItem { get; set; }

        public int FPriorityID { get; set; }
    }
}
