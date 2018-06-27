namespace KisManager.Dal.Kis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ICBOMChild")]
    public partial class ICBOMChild
    {
        [Required]
        [StringLength(10)]
        public string FBrNo { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FEntryID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FInterID { get; set; }

        public int FItemID { get; set; }

        public decimal FAuxQty { get; set; }

        public decimal FQty { get; set; }

        public decimal FScrap { get; set; }

        public int FOperSN { get; set; }

        public int FOperID { get; set; }

        [StringLength(1000)]
        public string FMachinePos { get; set; }

        [StringLength(1000)]
        public string FNote { get; set; }

        public int FMaterielType { get; set; }

        public int FMarshalType { get; set; }

        public decimal FPercent { get; set; }

        public DateTime FBeginDay { get; set; }

        public DateTime FEndDay { get; set; }

        public decimal FOffSetDay { get; set; }

        public int FBackFlush { get; set; }

        public int? FStockID { get; set; }

        public int FSPID { get; set; }

        public short FSupply { get; set; }

        public int FUnitID { get; set; }

        public int FAuxPropID { get; set; }

        public DateTime? FPDMImportDate { get; set; }

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

        public short? FHasChar { get; set; }

        public Guid FDetailID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FEntryKey { get; set; }

        public decimal? FCostPercentage { get; set; }
    }
}
