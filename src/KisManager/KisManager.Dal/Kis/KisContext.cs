using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.Dal.Kis
{
    public class KisContext : DbContext
    {
        public KisContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {

        }
        public virtual DbSet<ICBOM> ICBOM { get; set; }
        public virtual DbSet<ICBOMChild> ICBOMChild { get; set; }
        public virtual DbSet<ICInvBal> ICInvBal { get; set; }
        public virtual DbSet<POOrder> POOrder { get; set; }
        public virtual DbSet<POOrderEntry> POOrderEntry { get; set; }
        public virtual DbSet<PPBOM> PPBOM { get; set; }
        public virtual DbSet<PPBOMEntry> PPBOMEntry { get; set; }
        public virtual DbSet<t_ICItem> t_ICItem { get; set; }
        public virtual DbSet<t_Stock> t_Stock { get; set; }
        public virtual DbSet<t_Supplier> t_Supplier { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ICBOM>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<ICBOM>()
                .Property(e => e.FBOMNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ICBOM>()
                .Property(e => e.FVersion)
                .IsUnicode(false);

            modelBuilder.Entity<ICBOM>()
                .Property(e => e.FQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICBOM>()
                .Property(e => e.FYield)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICBOM>()
                .Property(e => e.FNote)
                .IsUnicode(false);

            modelBuilder.Entity<ICBOM>()
                .Property(e => e.FAUXQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICBOMChild>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<ICBOMChild>()
                .Property(e => e.FAuxQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICBOMChild>()
                .Property(e => e.FQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICBOMChild>()
                .Property(e => e.FScrap)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICBOMChild>()
                .Property(e => e.FMachinePos)
                .IsUnicode(false);

            modelBuilder.Entity<ICBOMChild>()
                .Property(e => e.FNote)
                .IsUnicode(false);

            modelBuilder.Entity<ICBOMChild>()
                .Property(e => e.FPercent)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICBOMChild>()
                .Property(e => e.FOffSetDay)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICBOMChild>()
                .Property(e => e.FCostPercentage)
                .HasPrecision(6, 2);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FBegQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FReceive)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FSend)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FYtdReceive)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FYtdSend)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FEndQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FBegBal)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FDebit)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FCredit)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FYtdDebit)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FYtdCredit)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FEndBal)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FBegDiff)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FReceiveDiff)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FSendDiff)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FEndDiff)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FKFDate)
                .IsUnicode(false);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FYtdReceiveDiff)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FYtdSendDiff)
                .HasPrecision(20, 2);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FSecBegQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FSecReceive)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FSecSend)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FSecYtdReceive)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FSecYtdSend)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FSecEndQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<ICInvBal>()
                .Property(e => e.FStockInDate)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.FTotalCostFor)
                .HasPrecision(28, 4);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.FOperDate)
                .IsFixedLength();

            modelBuilder.Entity<POOrder>()
                .Property(e => e.FValidaterName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FCommitQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAmount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FTaxRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FTax)
                .HasPrecision(20, 2);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FTaxAmount)
                .HasPrecision(20, 2);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FNote)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAuxCommitQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAuxPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAuxQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FCess)
                .HasPrecision(20, 2);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FStockQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAuxStockQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FMapNumber)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAllAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAuxPriceDiscount)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FPriceDiscount)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FQtyInvoice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FQtyInvoiceBase)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAuxTaxPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FTaxPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FReceiveAmountFor_Commit)
                .HasPrecision(28, 4);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FReceiveAmount_Commit)
                .HasPrecision(28, 4);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FSecCoefficient)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FSecQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FSecCommitQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAuxQtyInvoice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAmtDiscount)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FCheckAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FPayApplyAmountFor_Commit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FPayApplyAmount_Commit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FSecStockQty)
                .HasPrecision(23, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FSecInvoiceQty)
                .HasPrecision(23, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FDescount)
                .HasPrecision(23, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FSupConQty)
                .HasPrecision(23, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FDeliveryQty)
                .HasPrecision(23, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAuxDeliveryQty)
                .HasPrecision(23, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FSecDeliveryQty)
                .HasPrecision(23, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAuxReceiptQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FReceiptQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAuxReturnQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FReturnQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAmountExceptDisCount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FAllAmountExceptDisCount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FEntryDisCount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FCommitAmt)
                .HasPrecision(23, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FCommitAmtTax)
                .HasPrecision(23, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FCommitTax)
                .HasPrecision(23, 10);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.FPayReqPayAmountFor)
                .HasPrecision(28, 2);

            modelBuilder.Entity<PPBOM>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<PPBOM>()
                .Property(e => e.FBillNo)
                .IsUnicode(false);

            modelBuilder.Entity<PPBOM>()
                .Property(e => e.FAuxQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOM>()
                .Property(e => e.FOrderBillNo)
                .IsUnicode(false);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FBatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FQtyMust)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FAuxQtyMust)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FAuxQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FMachinePos)
                .IsUnicode(false);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FSequenceID)
                .IsUnicode(false);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FNote)
                .IsUnicode(false);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FQtyScrap)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FAuxQtyScrap)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FScrap)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FQtyPick)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FAuxQtyPick)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FQtyBackFlush)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FStockQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FAuxStockQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FAuxQtyLoss)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FQtyLoss)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FBOMInPutQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FWIPQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FWIPAuxQTY)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FSelDiscardQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FSelDiscardAuxQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FDiscardQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FDiscardAuxQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FBomInputAuxQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FQtySupply)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FAuxQtySupply)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FSelTransLateAuxQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FSelTransLateQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FTransLateAuxQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FTransLateQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FQtyConsume)
                .HasPrecision(23, 10);

            modelBuilder.Entity<PPBOMEntry>()
                .Property(e => e.FAuxQtyConsume)
                .HasPrecision(23, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FModel)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FHelpCode)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FShortNumber)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FNumber)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FModifyTime)
                .IsFixedLength();

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FLowLimit)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FHighLimit)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FSecInv)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FEquipmentNum)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FFullName)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FSecCoefficient)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FAlias)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FApproveNo)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FPOHighPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FWWHghPrc)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FSOLowPrc)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FProfitRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FSalePrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FKFPeriod)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FPlanPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FTaxRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FNote)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FSOHighLimit)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FSOLowLimit)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FOIHighLimit)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FOILowLimit)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FStockPrice)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FABCCls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FPickHighLimit)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FPickLowLimit)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FOnlineShopPNo)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FQtyMin)
                .HasPrecision(23, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FQtyMax)
                .HasPrecision(23, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FBatchAppendQty)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FOrderPoint)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FBatFixEconomy)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FBatChangeEconomy)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FDailyConsume)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FInHighLimit)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FInLowLimit)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FBatchSplit)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.F_102)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FChartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FGrossWeight)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FNetWeight)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FLength)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FWidth)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FHeight)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FSize)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FVersion)
                .IsUnicode(false);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FStandardCost)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FStandardManHour)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FStdPayRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FChgFeeRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FStdFixFeeRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FOutMachFee)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FPieceRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FStdBatchQty)
                .HasPrecision(23, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FCBAppendRate)
                .HasPrecision(23, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FFirstUnitRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FSecondUnitRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FImpostTaxRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FConsumeTaxRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FExportRate)
                .HasPrecision(28, 10);

            modelBuilder.Entity<t_ICItem>()
                .Property(e => e.FBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_Stock>()
                .Property(e => e.FBrNO)
                .IsUnicode(false);

            modelBuilder.Entity<t_Stock>()
                .Property(e => e.FHelperCode)
                .IsUnicode(false);

            modelBuilder.Entity<t_Stock>()
                .Property(e => e.FAddress)
                .IsUnicode(false);

            modelBuilder.Entity<t_Stock>()
                .Property(e => e.FPhone)
                .IsUnicode(false);

            modelBuilder.Entity<t_Stock>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<t_Stock>()
                .Property(e => e.FNumber)
                .IsUnicode(false);

            modelBuilder.Entity<t_Stock>()
                .Property(e => e.FShortNumber)
                .IsUnicode(false);

            modelBuilder.Entity<t_Stock>()
                .Property(e => e.FModifyTime)
                .IsFixedLength();

            modelBuilder.Entity<t_Supplier>()
           .Property(e => e.FAddress)
           .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FCity)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FProvince)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FCountry)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FPostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FPhone)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FFax)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FEmail)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FHomePage)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FCreditLimit)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FTaxID)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FBank)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FAccount)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FShortName)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FLegalPerson)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FContact)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FContactAcct)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FPhoneAcct)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FFaxAcct)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FZipAcct)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FEmailAcct)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FAddrAcct)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FTaxNum)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FCIQNumber)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FNumber)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FShortNumber)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FlastTradeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FLastRPAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FFavorPolicy)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.Fcorperate)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FcashDiscount)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FValueAddRate)
                .HasPrecision(28, 2);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FDiscount)
                .HasPrecision(18, 10);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FCreditLevel)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FRegmark)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FLicence)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FHelpCode)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FModifyTime)
                .IsFixedLength();

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FMobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FRegsterAmount)
                .HasPrecision(23, 10);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.FPrepayAmount)
                .HasPrecision(23, 10);

            modelBuilder.Entity<t_Supplier>()
                .Property(e => e.F1688MemberId)
                .IsUnicode(false);

        }
    }
}
