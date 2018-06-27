namespace KisManager.Dal.Kis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ICInvBal")]
    public partial class ICInvBal
    {
        [Required]
        [StringLength(10)]
        public string FBrNo { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FYear { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FPeriod { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FStockID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FItemID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string FBatchNo { get; set; }

        public decimal FBegQty { get; set; }

        public decimal FReceive { get; set; }

        public decimal FSend { get; set; }

        public decimal FYtdReceive { get; set; }

        public decimal FYtdSend { get; set; }

        public decimal FEndQty { get; set; }

        public decimal FBegBal { get; set; }

        public decimal FDebit { get; set; }

        public decimal FCredit { get; set; }

        public decimal FYtdDebit { get; set; }

        public decimal FYtdCredit { get; set; }

        public decimal FEndBal { get; set; }

        public decimal FBegDiff { get; set; }

        public decimal FReceiveDiff { get; set; }

        public decimal FSendDiff { get; set; }

        public decimal FEndDiff { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FBillInterID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FStockPlaceID { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FKFPeriod { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string FKFDate { get; set; }

        public decimal FYtdReceiveDiff { get; set; }

        public decimal FYtdSendDiff { get; set; }

        public decimal FSecBegQty { get; set; }

        public decimal FSecReceive { get; set; }

        public decimal FSecSend { get; set; }

        public decimal FSecYtdReceive { get; set; }

        public decimal FSecYtdSend { get; set; }

        public decimal FSecEndQty { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FAuxPropID { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string FStockInDate { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string FMTONo { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FSupplyID { get; set; }
    }
}
