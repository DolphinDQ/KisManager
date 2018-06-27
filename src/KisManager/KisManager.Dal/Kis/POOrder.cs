namespace KisManager.Dal.Kis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("POOrder")]
    public partial class POOrder
    {
        [Required]
        [StringLength(10)]
        public string FBrNo { get; set; }

        public int FTranType { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FInterID { get; set; }

        [Required]
        [StringLength(255)]
        public string FBillNo { get; set; }

        public int? FSupplyID { get; set; }

        public DateTime? FDate { get; set; }

        public int? FEmpID { get; set; }

        public int? FDeptID { get; set; }

        public int? FCurrencyID { get; set; }

        public int? FCheckerID { get; set; }

        public int? FBillerID { get; set; }

        public int? FMangerID { get; set; }

        public short FClosed { get; set; }

        public int FTranStatus { get; set; }

        public double? FExchangeRate { get; set; }

        public short FStatus { get; set; }

        public bool FCancellation { get; set; }

        public int? FPOStyle { get; set; }

        public int? FMultiCheckLevel1 { get; set; }

        public int? FMultiCheckLevel2 { get; set; }

        public int? FMultiCheckLevel3 { get; set; }

        public int? FMultiCheckLevel4 { get; set; }

        public int? FMultiCheckLevel5 { get; set; }

        public int? FMultiCheckLevel6 { get; set; }

        public DateTime? FMultiCheckDate1 { get; set; }

        public DateTime? FMultiCheckDate2 { get; set; }

        public DateTime? FMultiCheckDate3 { get; set; }

        public DateTime? FMultiCheckDate4 { get; set; }

        public DateTime? FMultiCheckDate5 { get; set; }

        public DateTime? FMultiCheckDate6 { get; set; }

        public int? FCurCheckLevel { get; set; }

        public int? FRelateBrID { get; set; }

        public int? FOrderAffirm { get; set; }

        [Required]
        [StringLength(255)]
        public string FCashDiscount { get; set; }

        public DateTime? FCheckDate { get; set; }

        [Required]
        [StringLength(255)]
        public string FExplanation { get; set; }

        [Required]
        [StringLength(255)]
        public string FFetchAdd { get; set; }

        public DateTime? FSettleDate { get; set; }

        public int FSettleID { get; set; }

        public int FSelTranType { get; set; }

        public int FChildren { get; set; }

        public int? FBrID { get; set; }

        [StringLength(510)]
        public string FPOOrdBillNo { get; set; }

        public int FAreaPS { get; set; }

        public int FClassTypeID { get; set; }

        public decimal FTotalCostFor { get; set; }

        public DateTime? FlastModyDate { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] FOperDate { get; set; }

        public int? FManageType { get; set; }

        public short FSysStatus { get; set; }

        [Required]
        [StringLength(20)]
        public string FVersionNo { get; set; }

        public DateTime? FChangeDate { get; set; }

        [StringLength(255)]
        public string FChangeCauses { get; set; }

        public int FChangeMark { get; set; }

        public int FChangeUser { get; set; }

        [StringLength(255)]
        public string FValidaterName { get; set; }

        [StringLength(255)]
        public string FConsignee { get; set; }

        public short FPrintCount { get; set; }

        public int FExchangeRateType { get; set; }

        [Required]
        [StringLength(255)]
        public string FDeliveryPlace { get; set; }

        public int? FAccessoryCount { get; set; }

        public int? FPOMode { get; set; }

        public int FPlanCategory { get; set; }

        [Required]
        [StringLength(255)]
        public string FLastAlterBillNo { get; set; }
    }
}
