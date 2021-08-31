using Demo.Domain.Entities;
using Demo.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Infrastructure.Persistence.Configurations
{
  public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User").HasKey (x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.FirstName).HasColumnType("NVARCHAR").HasMaxLength(20).IsRequired();
            builder.Property(x => x.MiddleName).HasColumnType("NVARCHAR").HasMaxLength(40).IsRequired(false);
            builder.Property(x => x.LastName).HasColumnType("NVARCHAR").HasMaxLength(20).IsRequired();
            builder.Property(x => x.BirthDate).HasColumnType("DATE").IsRequired();
            builder.Property(x => x.Email).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Gender).HasMaxLength(6).HasDefaultValue(Gender.Male);
            builder.Property(x => x.MobileNo).HasMaxLength(15).IsRequired();
           
        }

    }
}
