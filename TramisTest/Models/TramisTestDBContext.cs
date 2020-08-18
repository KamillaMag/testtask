using Microsoft.EntityFrameworkCore;

namespace TramisTest.Models
{
    public class TramisTestDBContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Declaration> Declarations { get; set; }
        public DbSet<OrderDeclaration> OrderDeclarations { get; set; }
        public DbSet<Customs> Customs { get; set; }
        public DbSet<Receiving> Receiving { get; set; }
        public DbSet<Shipment> Shipment { get; set; }
        public DbSet<Documents> Documents { get; set; }

        public TramisTestDBContext(DbContextOptions<TramisTestDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //sets primary key
            modelBuilder.Entity<Declaration>().HasKey(p => p.DeclarationNumber);
            // configures one-to-many relationship with foreign key
            modelBuilder.Entity<OrderDeclaration>()
            .HasOne(s => s.Declaration)
            .WithMany(g => g.Orders)
            .HasForeignKey(s => s.DeclarationNumber);

            modelBuilder.Entity<Customs>().HasKey(p => p.OrderId);
            modelBuilder.Entity<Order>()
            .HasOne(s => s.Customs)
            .WithOne(g => g.Order)
            .HasForeignKey<Customs>(s => s.OrderId);

            modelBuilder.Entity<Documents>().HasKey(p => p.OrderId);
            modelBuilder.Entity<Order>()
            .HasOne(s => s.Documents)
            .WithOne(g => g.Order)
            .HasForeignKey<Documents>(s => s.OrderId);

            modelBuilder.Entity<Receiving>().HasKey(p => p.OrderId);
            modelBuilder.Entity<Order>()
            .HasOne(s => s.Receiving)
            .WithOne(g => g.Order)
            .HasForeignKey<Receiving>(s => s.OrderId);

            modelBuilder.Entity<Shipment>().HasKey(p => p.OrderId);
            modelBuilder.Entity<Order>()
            .HasOne(s => s.Shipment)
            .WithOne(g => g.Order)
            .HasForeignKey<Shipment>(s => s.OrderId);
        }
    }
}