using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Threading.Tasks;
using Demo.Infrastructure.Persistence.SeedData;
using Demo.Application.Common.Contracts;

namespace Demo.Infrastructure.Persistence.Context
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
        }
        public DbSet<User> Users { get ; set ; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Government> Govermantes { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.SeedUser();
            modelBuilder.SeedGovernment();
            modelBuilder.SeedCity();
            modelBuilder.SeedAddress();
        }
    }
}
