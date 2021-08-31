using Demo.Domain.Entities;
using Demo.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;

namespace Demo.Infrastructure.Persistence.SeedData
{
    public static class SeedUserData
    {
        public static void SeedUser(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasData(
             new User
             {
                 Id = 1,
                 FirstName = "Ahmed",
                 MiddleName = "Ali",
                 LastName = "Ibrahim",
                 BirthDate = new DateTime(1998, 12, 05),
                 Email = "Ahmed@gmail.com",
                 Gender = Gender.Male,
                 MobileNo = "01007095896"

             },
             new User
             {
                 Id = 2,
                 FirstName = "Salma",
                 MiddleName = "Amr",
                 LastName = "Ibrahim",
                 BirthDate = new DateTime(1992, 01, 01),
                 Email = "Salma@gmail.com",
                 Gender = Gender.Female,
                 MobileNo = "01006958968"
             },

             new User
             {
                 Id = 3,
                 FirstName = "Lila",
                 MiddleName = "Omar",
                 LastName = "Hassan",
                 BirthDate = new DateTime(1995, 12, 31),
                 Email = "Lila@gmail.com",
                 Gender = Gender.Female,
                 MobileNo = "01009085896"
             },
             new User
             {
                 Id = 4,
                 FirstName = "yousef",
                 MiddleName = "mohamed",
                 LastName = "Ibrahim",
                 BirthDate = new DateTime(1990, 04, 20),
                 Email = "yousef@gmail.com",
                 Gender = Gender.Male,
                 MobileNo = "01007096066"
             });

        }
    }
}
