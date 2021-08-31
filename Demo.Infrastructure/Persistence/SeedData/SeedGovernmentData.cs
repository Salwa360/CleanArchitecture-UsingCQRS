using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infrastructure.Persistence.SeedData
{
    public static class SeedGovernmentData
    {
        public static void SeedGovernment(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Government>().HasData(
              new Government { Id= 1, GovName = "Cairo" },
              new Government { Id = 2, GovName = "Giza" },
              new Government { Id = 3, GovName = "Alexandria" },
              new Government { Id = 4, GovName = "Banha" },
              new Government { Id = 5, GovName = "Domiate" },
              new Government { Id = 6, GovName = "Matroh" },
              new Government { Id = 7, GovName = "Sohag" },
              new Government { Id = 8, GovName = "Qena" }
              
             );

        }
    }
}
