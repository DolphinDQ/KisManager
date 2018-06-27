namespace KisManager.Dal.Kis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ICBOM")]
    public partial class ICBOM
    {
        [Required]
        [StringLength(10)]
        public string FBrNo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FInterID { get; set; }

        [Required]
        [StringLength(300)]
        public string FBOMNumber { get; set; }

        public short FImpMode { get; set; }

        public int? FUseStatus { get; set; }

        [Required]
        [StringLength(300)]
        public string FVersion { get; set; }

        public int? FParentID { get; set; }

        public int FItemID { get; set; }

        public decimal FQty { get; set; }

        public decimal? FYield { get; set; }

        public int? FCheckID { get; set; }

        public DateTime? FCheckDate { get; set; }

        public int? FOperatorID { get; set; }

        public DateTime FEnterTime { get; set; }

        public short FStatus { get; set; }

        public bool FCancellation { get; set; }

        public int FTranType { get; set; }

        public int FRoutingID { get; set; }

        public int FBomType { get; set; }

        public int FCustID { get; set; }

        public int FCustItemID { get; set; }

        public int FAccessories { get; set; }

        [Required]
        [StringLength(300)]
        public string FNote { get; set; }

        public int FUnitID { get; set; }

        public decimal FAUXQTY { get; set; }

        public int? FCheckerID { get; set; }

        public DateTime? FAudDate { get; set; }

        public int FEcnInterID { get; set; }

        public bool FBeenChecked { get; set; }

        public short FForbid { get; set; }

        public int FAuxPropID { get; set; }

        public DateTime? FPDMImportDate { get; set; }

        public short FBOMSkip { get; set; }

        public int? FClassTypeID { get; set; }

        public int? FUserID { get; set; }

        public DateTime? FUseDate { get; set; }

        public int FPrintCount { get; set; }
    }
}
