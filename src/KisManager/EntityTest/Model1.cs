namespace KisManager.Dal.Kis
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model13")
        {
        }

        public virtual DbSet<t_Supplier> t_Supplier { get; set; }
        public virtual DbSet<t_Supply> t_Supply { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<t_Supply>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supply>()
                .Property(e => e.FPOHighPrice)
                .HasPrecision(28, 10);
        }
    }
}
