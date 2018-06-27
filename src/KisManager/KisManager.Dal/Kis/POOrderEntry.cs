namespace KisManager.Dal.Kis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("POOrderEntry")]
    public partial class POOrderEntry
    {
        [Required]
        [StringLength(10)]
        public string FBrNo { get; set; }

        public int FInterID { get; set; }

        public int FEntryID { get; set; }

        public int FItemID { get; set; }

        public decimal FQty { get; set; }

        public decimal FCommitQty { get; set; }

        public DateTime? FDate { get; set; }

        public decimal FPrice { get; set; }

        public decimal FAmount { get; set; }

        public decimal? FTaxRate { get; set; }

        public decimal? FTax { get; set; }

        public decimal? FTaxAmount { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public int FUnitID { get; set; }

        public decimal FAuxCommitQty { get; set; }

        public decimal FAuxPrice { get; set; }

        public decimal FAuxQty { get; set; }

        public int FSourceEntryID { get; set; }

        public decimal FCess { get; set; }

        public decimal FStockQty { get; set; }

        public decimal FAuxStockQty { get; set; }

        [Required]
        [StringLength(80)]
        public string FMapNumber { get; set; }

        [StringLength(256)]
        public string FMapName { get; set; }

        public decimal FAllAmount { get; set; }

        public int FAuxPropID { get; set; }

        public decimal FAuxPriceDiscount { get; set; }

        public decimal FPriceDiscount { get; set; }

        public decimal FQtyInvoice { get; set; }

        public decimal FQtyInvoiceBase { get; set; }

        public decimal FAuxTaxPrice { get; set; }

        public decimal FTaxPrice { get; set; }

        public decimal FReceiveAmountFor_Commit { get; set; }

        public decimal FReceiveAmount_Commit { get; set; }

        public decimal FSecCoefficient { get; set; }

        public decimal FSecQty { get; set; }

        public decimal FSecCommitQty { get; set; }

        public int FSourceTranType { get; set; }

        public int FSourceInterId { get; set; }

        [Required]
        [StringLength(255)]
        public string FSourceBillNo { get; set; }

        public int FContractInterID { get; set; }

        public int FContractEntryID { get; set; }

        [Required]
        [StringLength(255)]
        public string FContractBillNo { get; set; }

        public int FMRPLockFlag { get; set; }

        public decimal FAuxQtyInvoice { get; set; }

        public int FMrpClosed { get; set; }

        [Key]
        public int FDetailID { get; set; }

        public int FMapID { get; set; }

        public int FSProducingAreaID { get; set; }

        public decimal FAmtDiscount { get; set; }

        public decimal FCheckAmount { get; set; }

        public int? FMrpAutoClosed { get; set; }

        public decimal FPayApplyAmountFor_Commit { get; set; }

        public decimal FPayApplyAmount_Commit { get; set; }

        public decimal FSecStockQty { get; set; }

        public decimal FSecInvoiceQty { get; set; }

        public int FPlanMode { get; set; }

        [Required]
        [StringLength(50)]
        public string FMTONo { get; set; }

        public decimal FDescount { get; set; }

        [StringLength(10)]
        public string FSupConfirm { get; set; }

        public DateTime? FSupConDate { get; set; }

        public decimal? FSupConQty { get; set; }

        [StringLength(255)]
        public string FSupConMem { get; set; }

        public DateTime? FSupConFetchDate { get; set; }

        public int? FSupConfirmor { get; set; }

        public int FQualityRptBillID { get; set; }

        public int FLockByAlter { get; set; }

        public decimal FDeliveryQty { get; set; }

        public decimal FAuxDeliveryQty { get; set; }

        public decimal FSecDeliveryQty { get; set; }

        [Required]
        [StringLength(255)]
        public string FRejectRefuseNote { get; set; }

        [Required]
        [StringLength(255)]
        public string FRefuseNote { get; set; }

        public byte FLockBySupplier { get; set; }

        public int? FEntryAccessoryCount { get; set; }

        public int FPRInterID { get; set; }

        public int FPREntryID { get; set; }

        public decimal? FAuxReceiptQty { get; set; }

        public decimal? FReceiptQty { get; set; }

        public decimal? FAuxReturnQty { get; set; }

        public decimal? FReturnQty { get; set; }

        public int FCheckMethod { get; set; }

        public int FIsCheck { get; set; }

        public decimal FAmountExceptDisCount { get; set; }

        public decimal FAllAmountExceptDisCount { get; set; }

        public decimal FEntryDisCount { get; set; }

        public decimal? FCommitAmt { get; set; }

        public decimal? FCommitAmtTax { get; set; }

        public decimal? FCommitTax { get; set; }

        public decimal FPayReqPayAmountFor { get; set; }
    }
}
