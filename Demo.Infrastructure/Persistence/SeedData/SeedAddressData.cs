using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infrastructure.Persistence.SeedData
{
    public static class SeedAddressData
    {
        public static void SeedAddress(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Address>().HasData(
             new Address { Id = 1, CityId = 1, UserId = 1, FlatNumber = 11, BuildingNumber = 1, Street = " Abbsia Street" },
             new Address { Id = 2, CityId = 2, UserId = 2, FlatNumber = 51, BuildingNumber = 11, Street = "Giza Street" },
             new Address { Id = 3, CityId = 1,  UserId =3, FlatNumber = 44, BuildingNumber = 12, Street = " Agoza Street" },
             new Address { Id = 4, CityId = 1, UserId = 2, FlatNumber = 30, BuildingNumber = 6, Street = " Nasr City Street" },
             new Address { Id = 5, CityId = 2, UserId = 3, FlatNumber = 1, BuildingNumber = 10, Street = "Haram Street" },
             new Address { Id = 6, CityId = 2, UserId = 4, FlatNumber = 10, BuildingNumber = 4, Street = "6 Octobar Street" }

             );

        }
    }
}
