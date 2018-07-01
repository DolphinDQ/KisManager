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
       
            modelBuilder.Entity<t_Supply>()
                .Property(e => e.FBrNo)
                .IsUnicode(false);

            modelBuilder.Entity<t_Supply>()
                .Property(e => e.FPOHighPrice)
                .HasPrecision(28, 10);
        }
    }
}
