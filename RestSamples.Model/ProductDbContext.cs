using Microsoft.EntityFrameworkCore;

namespace RestSamples.Model
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Persist Security Info=False;User ID=sa;Initial Catalog=RESTDb ;Data Source=.; Password=12; MultipleActiveResultSets=true; Encrypt=False");
        }
    }
}
