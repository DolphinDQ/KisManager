namespace KisManager.Dal.Kis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PPBOM")]
    public partial class PPBOM
    {
        [Required]
        [StringLength(10)]
        public string FBrNo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FInterID { get; set; }

        [Required]
        [StringLength(255)]
        public string FBillNo { get; set; }

        public int FTranType { get; set; }

        public DateTime? FDate { get; set; }

        public int? FBillerID { get; set; }

        public int? FCheckerID { get; set; }

        public DateTime? FCheckDate { get; set; }

        public short FStatus { get; set; }

        public int? FICMOInterID { get; set; }

        public bool FCancellation { get; set; }

        public int FItemID { get; set; }

        public int FUnitID { get; set; }

        public decimal FAuxQty { get; set; }

        public int? FType { get; set; }

        public short FStockType { get; set; }

        public int? FWorkSHop { get; set; }

        public int FOrderInterID { get; set; }

        [Required]
        [StringLength(255)]
        public string FOrderBillNo { get; set; }

        public int FChangeTimes { get; set; }

        public int FOrderEntryID { get; set; }

        public int FPrintCount { get; set; }

        public int FSelTranType { get; set; }
    }
}
