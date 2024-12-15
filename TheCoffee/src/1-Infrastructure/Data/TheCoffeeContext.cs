using TheCoffee.src.Domain.Model.Person;
using TheCoffee.src.Domain.Model.Property;
using LinqToDB;
using Microsoft.EntityFrameworkCore;
using TheCoffee.src.Domain.Model.Order;
using TheCoffee.src.Domain.Model.Products;
using TheCoffee.src.Domain.Model.Store;
using TheCoffee.src.Auth;
using TheCoffee.src._0_Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TheCoffee.src.Infrastructure.Data
{
    public class TheCoffeeContext(DbContextOptions<TheCoffeeContext> options) : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Store>().HasOne(t => t.Address)
                     .WithOne(t => t.Store)
                     .HasForeignKey<Address>(t => t.StoreId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreEquipment> StoreEquipments { get; set; }
        public DbSet<Address> Adresses { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }        
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TheCoffee;Persist Security Info=True;User ID=sa;Password=123;Pooling=False;TrustServerCertificate=true");
        }
    }
}
