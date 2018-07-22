namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PhonesDB : DbContext
    {
        public PhonesDB()
            : base("name=dbConnection")
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Order>()
                .Property(e => e.Customer)
                .IsFixedLength();

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Phones)
                .WithMany(e => e.Orders)
                .Map(m => m.ToTable("PhoneOrder").MapLeftKey("OrderId").MapRightKey("PhoneId"));

            modelBuilder.Entity<Phone>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Phone>()
                .Property(e => e.Manufacturer)
                .IsFixedLength();
        }
    }
}
