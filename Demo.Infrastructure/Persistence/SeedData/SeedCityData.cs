using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Demo.Infrastructure.Persistence.SeedData
{
    public static class SeedCityData
    {
        public static void SeedCity(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<City>().HasData(
             new City { Id=1, CityName = "Helioplies", GovernmentId = 1 },
             new City { Id = 2, CityName = "Obor"     , GovernmentId = 1  },
             new City { Id = 3, CityName = "Nasr City", GovernmentId = 1 },
             new City { Id = 4, CityName = "Tagmoaa"  , GovernmentId = 1 },
              new City {Id = 5, CityName = "Maadi"   , GovernmentId = 1 },
             new City { Id = 6, CityName = "Abassia"  , GovernmentId = 1 },
             new City { Id = 7, CityName = "Shobra"   , GovernmentId = 1 },
             new City { Id = 8, CityName = "6 Octobar", GovernmentId = 2 },
             new City { Id = 9, CityName = "Haram"    , GovernmentId = 2 },
             new City { Id = 10, CityName = "Fiasel"   , GovernmentId = 2 },
             new City { Id = 11, CityName = "EL shekhzaid", GovernmentId = 2 }
            
             );

        }
    }
}
