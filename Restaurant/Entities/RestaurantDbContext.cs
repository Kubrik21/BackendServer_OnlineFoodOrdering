using Microsoft.EntityFrameworkCore;

namespace Restaurant.Entities
{
    public class RestaurantDbContext : DbContext 
    {
        private string _connectionString = "Server=LAPTOP-GLO9H9DO;Database=DbRestaurant;Trusted_Connection=True;";
        
        public DbSet<Restaurantt> Restaurants { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderElement> OrderElements { get; set; }
        public DbSet<Auth> Auths { get; set; }



       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurantt>()
                .Property(e => e.RestaurantName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(50);



            modelBuilder.Entity<OrderElement>()
                .HasKey(e => new { e.OrderId, e.ProductId });
                
              
            modelBuilder.Entity<OrderElement>()
                .HasOne(pt => pt.Order)
                .WithMany(p => p.OrdersElements)
                .HasForeignKey(pt => pt.OrderId);

            modelBuilder.Entity<OrderElement>()
                .HasOne(pt => pt.Product)
                .WithMany(t => t.OrdersElements)
                .HasForeignKey(pt => pt.ProductId);
        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
