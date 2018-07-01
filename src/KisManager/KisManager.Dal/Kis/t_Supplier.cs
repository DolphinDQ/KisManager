namespace KisManager.Dal.Kis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FItemID { get; set; }

        [StringLength(255)]
        public string FAddress { get; set; }

        [StringLength(80)]
        public string FCity { get; set; }

        [StringLength(80)]
        public string FProvince { get; set; }

        [StringLength(80)]
        public string FCountry { get; set; }

        [StringLength(20)]
        public string FPostalCode { get; set; }

        [StringLength(40)]
        public string FPhone { get; set; }

        [StringLength(40)]
        public string FFax { get; set; }

        [StringLength(40)]
        public string FEmail { get; set; }

        [StringLength(80)]
        public string FHomePage { get; set; }

        [StringLength(20)]
        public string FCreditLimit { get; set; }

        [StringLength(40)]
        public string FTaxID { get; set; }

        [StringLength(255)]
        public string FBank { get; set; }

        [StringLength(80)]
        public string FAccount { get; set; }

        [StringLength(10)]
        public string FBrNo { get; set; }

        public int? FBoundAttr { get; set; }

        public int? FErpClsID { get; set; }

        [StringLength(50)]
        public string FShortName { get; set; }

        public int? FPriorityID { get; set; }

        public int? FPOGroupID { get; set; }

        public int? FStatus { get; set; }

        public int? FLanguageID { get; set; }

        public int? FRegionID { get; set; }

        public int? FTrade { get; set; }

        public double? FMinPOValue { get; set; }

        public double? FMaxDebitDate { get; set; }

        [StringLength(50)]
        public string FLegalPerson { get; set; }

        [StringLength(50)]
        public string FContact { get; set; }

        [StringLength(50)]
        public string FContactAcct { get; set; }

        [StringLength(50)]
        public string FPhoneAcct { get; set; }

        [StringLength(50)]
        public string FFaxAcct { get; set; }

        [StringLength(50)]
        public string FZipAcct { get; set; }

        [StringLength(50)]
        public string FEmailAcct { get; set; }

        [StringLength(50)]
        public string FAddrAcct { get; set; }

        public float? FTax { get; set; }

        public int? FCyID { get; set; }

        public int? FSetID { get; set; }

        public int? FSetDLineID { get; set; }

        [StringLength(50)]
        public string FTaxNum { get; set; }

        public int? FPriceClsID { get; set; }

        public int? FOperID { get; set; }

        [StringLength(20)]
        public string FCIQNumber { get; set; }

        public short FDeleted { get; set; }

        public short FSaleMode { get; set; }

        [StringLength(80)]
        public string FName { get; set; }

        [StringLength(255)]
        public string FNumber { get; set; }

        public int FParentID { get; set; }

        [StringLength(80)]
        public string FShortNumber { get; set; }

        public int FARAccountID { get; set; }

        public int FAPAccountID { get; set; }

        public int FpreAcctID { get; set; }

        [Column(TypeName = "money")]
        public decimal FlastTradeAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal FLastRPAmount { get; set; }

        [StringLength(255)]
        public string FFavorPolicy { get; set; }

        public int Fdepartment { get; set; }

        public int Femployee { get; set; }

        [StringLength(80)]
        public string Fcorperate { get; set; }

        public DateTime? FBeginTradeDate { get; set; }

        public DateTime? FEndTradeDate { get; set; }

        public DateTime? FLastTradeDate { get; set; }

        public DateTime? FLastReceiveDate { get; set; }

        [Required]
        [StringLength(255)]
        public string FcashDiscount { get; set; }

        public int FcurrencyID { get; set; }

        public double FMaxDealAmount { get; set; }

        public double FMinForeReceiveRate { get; set; }

        public double FMinReserveRate { get; set; }

        public double FMaxForePayAmount { get; set; }

        public double FMaxForePayRate { get; set; }

        public int FdebtLevel { get; set; }

        public int FCreditDays { get; set; }

        public decimal? FValueAddRate { get; set; }

        public int FPayTaxAcctID { get; set; }

        public decimal FDiscount { get; set; }

        public int FTypeID { get; set; }

        public decimal? FCreditAmount { get; set; }

        [StringLength(20)]
        public string FCreditLevel { get; set; }

        public int FStockIDAssignee { get; set; }

        public int FBr { get; set; }

        [StringLength(255)]
        public string FRegmark { get; set; }

        public bool FLicAndPermit { get; set; }

        [StringLength(255)]
        public string FLicence { get; set; }

        public DateTime? FPaperPeriod { get; set; }

        public int? FAlarmPeriod { get; set; }

        public int FOtherARAcctID { get; set; }

        public int FOtherAPAcctID { get; set; }

        public int FPreARAcctID { get; set; }

        [StringLength(50)]
        public string FHelpCode { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] FModifyTime { get; set; }

        [StringLength(255)]
        public string FNameEN { get; set; }

        [StringLength(255)]
        public string FAddrEn { get; set; }

        [StringLength(255)]
        public string FCIQCode { get; set; }

        public int? FRegion { get; set; }

        [StringLength(50)]
        public string FMobilePhone { get; set; }

        public int? FManageType { get; set; }

        public DateTime? FRegsterDate { get; set; }

        public DateTime? FPassDate { get; set; }

        public DateTime? FInureDate { get; set; }

        public DateTime? FAbateDate { get; set; }

        public int FSupplyGrade { get; set; }

        public int? FSupplyType { get; set; }

        public int? FCompanyType { get; set; }

        public int FEvalutionType { get; set; }

        public bool FSupplierCoroutineFlag { get; set; }

        public bool FAutoCreateMR { get; set; }

        public bool? FAutoValidateOrderFlag { get; set; }

        public bool? FAPFrozenFlag { get; set; }

        public int FID { get; set; }

        public int FClassTypeID { get; set; }

        [Required]
        [StringLength(30)]
        public string FBillNo { get; set; }

        public int FBiller { get; set; }

        public int FModifier { get; set; }

        public DateTime? FBillDate { get; set; }

        public DateTime? FModifyDate { get; set; }

        [Required]
        [StringLength(50)]
        public string FScale { get; set; }

        [Required]
        [StringLength(80)]
        public string FCharacter { get; set; }

        public DateTime? FCreateDate { get; set; }

        public decimal FRegsterAmount { get; set; }

        [Required]
        [StringLength(80)]
        public string FProducePermit { get; set; }

        public int FSumPepole { get; set; }

        public decimal FPrepayAmount { get; set; }

        public int FIsAutoNumber { get; set; }

        public int FVMIStockID { get; set; }

        public int FPOMode { get; set; }

        public DateTime? FSRMStartDate { get; set; }

        public int FProvinceID { get; set; }

        [StringLength(1)]
        public string F1688MemberId { get; set; }
    }
}
