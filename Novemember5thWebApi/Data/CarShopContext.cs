using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Novemember5thWebApi.Data
{
    public class CarShopContext : DbContext
    {
        public CarShopContext(DbContextOptions<CarShopContext> options) : base(options) {}

        public DbSet<Tool> Tools { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<RepairRequest> RepairRequest { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RepairRequest>(r =>
            {
                r.HasKey(k => k.Id);
            });

            modelBuilder.Entity<Tool>(t =>
            {
                t.HasKey(k => k.Id);
            });
            
            modelBuilder.Entity<Part>(p =>
            {
                p.HasKey(k => k.Id);
            });
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CarShopContext>
    {
        public CarShopContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CarShopContext>();

            builder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CarShop;Trusted_Connection=true;MultipleActiveResultSets=true");

            return new CarShopContext(builder.Options);
        }
    }
}
