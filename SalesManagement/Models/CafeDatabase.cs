namespace SalesManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CafeDatabase : DbContext
    {
        public CafeDatabase()
            : base("name=CafeDatabase")
        {
        }

        public virtual DbSet<AuditTransactionView> AuditTransactionViews { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditTransactionView>()
                .Property(e => e.Price)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductPrice)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.ReceiptNumber)
                .IsUnicode(false);
        }
    }
}
