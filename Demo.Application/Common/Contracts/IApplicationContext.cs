using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Demo.Application.Common.Contracts
{
    public interface IApplicationContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Government> Govermantes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Addresses { get; set; }
        Task<int> SaveChangesAsync();
    }
}
