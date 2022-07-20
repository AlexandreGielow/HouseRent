using HouseRent.Model;
using LinqToDB;
using Microsoft.EntityFrameworkCore;

namespace HouseRent.Data
{
    public class HouseRentContext : DbContext
    {
        public HouseRentContext(DbContextOptions<HouseRentContext> options) : base( options)
        {
            
        }
        public DbSet<Property> Properties { get; set;  }
        public DbSet<PropertyHighlights> PropertyHighlights { get; set; }
        public DbSet<PropertyRulesAcessibility> PropertyRulesAcessibility { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=HouseRent;Persist Security Info=True;User ID=sa;Password=123;Pooling=False");
        }
    }
}
