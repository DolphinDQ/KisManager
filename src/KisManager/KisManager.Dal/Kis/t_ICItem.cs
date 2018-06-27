namespace KisManager.Dal.Kis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_ICItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FItemID { get; set; }

        [StringLength(255)]
        public string FModel { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(80)]
        public string FName { get; set; }

        [StringLength(50)]
        public string FHelpCode { get; set; }

        public short? FDeleted { get; set; }

        [StringLength(80)]
        public string FShortNumber { get; set; }

        [StringLength(80)]
        public string FNumber { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] FModifyTime { get; set; }

        public int? FParentID { get; set; }

        [StringLength(10)]
        public string FBrNo { get; set; }

        public int? FTopID { get; set; }

        public short? FRP { get; set; }

        public short? FOmortize { get; set; }

        public short? FOmortizeScale { get; set; }

        public bool? FForSale { get; set; }

        public double? FStaCost { get; set; }

        public double? FOrderPrice { get; set; }

        public int? FOrderMethod { get; set; }

        public int? FPriceFixingType { get; set; }

        public int? FSalePriceFixingType { get; set; }

        public double? FPerWastage { get; set; }

        public int? FARAcctID { get; set; }

        public short? FPlanPriceMethod { get; set; }

        public short? FPlanClass { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string FPY { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string FPinYin { get; set; }

        public int? FErpClsID { get; set; }

        public int? FUnitID { get; set; }

        public int? FUnitGroupID { get; set; }

        public int? FDefaultLoc { get; set; }

        public int? FSPID { get; set; }

        public int? FSource { get; set; }

        public short? FQtyDecimal { get; set; }

        public decimal? FLowLimit { get; set; }

        public decimal? FHighLimit { get; set; }

        public decimal? FSecInv { get; set; }

        public int? FUseState { get; set; }

        public bool? FIsEquipment { get; set; }

        [StringLength(80)]
        public string FEquipmentNum { get; set; }

        public bool? FIsSparePart { get; set; }

        [StringLength(250)]
        public string FFullName { get; set; }

        public int? FSecUnitID { get; set; }

        public decimal? FSecCoefficient { get; set; }

        public int? FSecUnitDecimal { get; set; }

        [StringLength(80)]
        public string FAlias { get; set; }

        public int? FOrderUnitID { get; set; }

        public int? FSaleUnitID { get; set; }

        public int? FStoreUnitID { get; set; }

        public int? FProductUnitID { get; set; }

        [StringLength(80)]
        public string FApproveNo { get; set; }

        public int? FAuxClassID { get; set; }

        public int? FTypeID { get; set; }

        public int? FPreDeadLine { get; set; }

        public int? FSerialClassID { get; set; }

        public int? FDefaultReadyLoc { get; set; }

        public int? FSPIDReady { get; set; }

        public int? FOrderRector { get; set; }

        public int? FPOHghPrcMnyType { get; set; }

        public decimal? FPOHighPrice { get; set; }

        public decimal? FWWHghPrc { get; set; }

        public int? FWWHghPrcMnyType { get; set; }

        public decimal? FSOLowPrc { get; set; }

        public int? FSOLowPrcMnyType { get; set; }

        public bool? FIsSale { get; set; }

        public decimal? FProfitRate { get; set; }

        public decimal? FSalePrice { get; set; }

        public bool? FBatchManager { get; set; }

        public bool? FISKFPeriod { get; set; }

        public decimal? FKFPeriod { get; set; }

        public int? FTrack { get; set; }

        public decimal? FPlanPrice { get; set; }

        public short? FPriceDecimal { get; set; }

        public int? FAcctID { get; set; }

        public int? FSaleAcctID { get; set; }

        public int? FCostAcctID { get; set; }

        public int? FAPAcctID { get; set; }

        public int? FGoodSpec { get; set; }

        public int? FCostProject { get; set; }

        public bool? FIsSnManage { get; set; }

        public bool? FStockTime { get; set; }

        public bool? FBookPlan { get; set; }

        public int? FBeforeExpire { get; set; }

        public decimal? FTaxRate { get; set; }

        public int? FAdminAcctID { get; set; }

        [StringLength(80)]
        public string FNote { get; set; }

        public bool? FIsSpecialTax { get; set; }

        public decimal? FSOHighLimit { get; set; }

        public decimal? FSOLowLimit { get; set; }

        public decimal? FOIHighLimit { get; set; }

        public decimal? FOILowLimit { get; set; }

        public int? FDaysPer { get; set; }

        public DateTime? FLastCheckDate { get; set; }

        public int? FCheckCycle { get; set; }

        public int? FCheckCycUnit { get; set; }

        public decimal? FStockPrice { get; set; }

        [StringLength(1)]
        public string FABCCls { get; set; }

        public double? FBatchQty { get; set; }

        public bool? FClass { get; set; }

        public double? FCostDiffRate { get; set; }

        public int? FDepartment { get; set; }

        public int? FSaleTaxAcctID { get; set; }

        public int? FCBBmStandardID { get; set; }

        public int? FCBRestore { get; set; }

        public decimal? FPickHighLimit { get; set; }

        public decimal? FPickLowLimit { get; set; }

        [StringLength(60)]
        public string FOnlineShopPName { get; set; }

        [StringLength(80)]
        public string FOnlineShopPNo { get; set; }

        public int? FPlanTrategy { get; set; }

        public int? FOrderTrategy { get; set; }

        public float? FLeadTime { get; set; }

        public float? FFixLeadTime { get; set; }

        public int? FTotalTQQ { get; set; }

        public decimal? FQtyMin { get; set; }

        public decimal? FQtyMax { get; set; }

        public int? FCUUnitID { get; set; }

        public int? FOrderInterVal { get; set; }

        public decimal? FBatchAppendQty { get; set; }

        public decimal? FOrderPoint { get; set; }

        public decimal? FBatFixEconomy { get; set; }

        public decimal? FBatChangeEconomy { get; set; }

        public int? FRequirePoint { get; set; }

        public int? FPlanPoint { get; set; }

        public int? FDefaultRoutingID { get; set; }

        public int? FDefaultWorkTypeID { get; set; }

        public int? FProductPrincipal { get; set; }

        public decimal? FDailyConsume { get; set; }

        public bool? FMRPCon { get; set; }

        public int? FPlanner { get; set; }

        public bool? FPutInteger { get; set; }

        public decimal? FInHighLimit { get; set; }

        public decimal? FInLowLimit { get; set; }

        public int? FLowestBomCode { get; set; }

        public bool? FMRPOrder { get; set; }

        public int? FIsCharSourceItem { get; set; }

        public int? FCharSourceItemID { get; set; }

        public int? FPlanMode { get; set; }

        public int? FCtrlType { get; set; }

        public int? FCtrlStraregy { get; set; }

        [StringLength(50)]
        public string FContainerName { get; set; }

        public int? FKanBanCapability { get; set; }

        public int? FIsBackFlush { get; set; }

        public int? FBackFlushStockID { get; set; }

        public int? FBackFlushSPID { get; set; }

        public int? FBatchSplitDays { get; set; }

        public decimal? FBatchSplit { get; set; }

        public bool? FIsFixedReOrder { get; set; }

        [StringLength(30)]
        public string F_102 { get; set; }

        [StringLength(255)]
        public string FChartNumber { get; set; }

        public bool? FIsKeyItem { get; set; }

        public int? FMaund { get; set; }

        public decimal? FGrossWeight { get; set; }

        public decimal? FNetWeight { get; set; }

        public int? FCubicMeasure { get; set; }

        public decimal? FLength { get; set; }

        public decimal? FWidth { get; set; }

        public decimal? FHeight { get; set; }

        public decimal? FSize { get; set; }

        [StringLength(10)]
        public string FVersion { get; set; }

        public bool? FStartService { get; set; }

        public bool? FMakeFile { get; set; }

        public bool? FIsFix { get; set; }

        public int? FTtermOfService { get; set; }

        public int? FTtermOfUsefulTime { get; set; }

        public decimal? FStandardCost { get; set; }

        public decimal? FStandardManHour { get; set; }

        public decimal? FStdPayRate { get; set; }

        public decimal? FChgFeeRate { get; set; }

        public decimal? FStdFixFeeRate { get; set; }

        public decimal? FOutMachFee { get; set; }

        public decimal? FPieceRate { get; set; }

        public decimal? FStdBatchQty { get; set; }

        public int? FPOVAcctID { get; set; }

        public int? FPIVAcctID { get; set; }

        public int? FMCVAcctID { get; set; }

        public int? FPCVAcctID { get; set; }

        public int? FSLAcctID { get; set; }

        public int? FCAVAcctID { get; set; }

        public decimal? FCBAppendRate { get; set; }

        public int? FCBAppendProject { get; set; }

        public int? FCostBomID { get; set; }

        public int? FCBRouting { get; set; }

        public int? FOutMachFeeProject { get; set; }

        public int? FInspectionLevel { get; set; }

        public int? FInspectionProject { get; set; }

        public int? FIsListControl { get; set; }

        public int? FProChkMde { get; set; }

        public int? FWWChkMde { get; set; }

        public int? FSOChkMde { get; set; }

        public int? FWthDrwChkMde { get; set; }

        public int? FStkChkMde { get; set; }

        public int? FOtherChkMde { get; set; }

        public int? FStkChkPrd { get; set; }

        public int? FStkChkAlrm { get; set; }

        public int? FIdentifier { get; set; }

        [StringLength(50)]
        public string FSampStdCritical { get; set; }

        [StringLength(50)]
        public string FSampStdStrict { get; set; }

        [StringLength(50)]
        public string FSampStdSlight { get; set; }

        [StringLength(255)]
        public string FNameEn { get; set; }

        [StringLength(255)]
        public string FModelEn { get; set; }

        public int? FHSNumber { get; set; }

        [StringLength(255)]
        public string FFirstUnit { get; set; }

        [StringLength(255)]
        public string FSecondUnit { get; set; }

        public decimal? FFirstUnitRate { get; set; }

        public decimal? FSecondUnitRate { get; set; }

        public bool? FIsManage { get; set; }

        public int? FPackType { get; set; }

        public int? FLenDecimal { get; set; }

        public int? FCubageDecimal { get; set; }

        public int? FWeightDecimal { get; set; }

        public decimal? FImpostTaxRate { get; set; }

        public decimal? FConsumeTaxRate { get; set; }

        public int? FManageType { get; set; }

        public decimal? FExportRate { get; set; }

        [StringLength(128)]
        public string FBarcode { get; set; }
    }
}
