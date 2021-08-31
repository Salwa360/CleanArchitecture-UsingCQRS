using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Infrastructure.Persistence.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City").HasKey(x => x.Id);
            builder.Property(x => x.CityName).HasMaxLength(30).IsRequired();
            builder.HasOne(x => x.Government).WithMany(x => x.Cities).HasForeignKey(x=>x.GovernmentId);
        }
       
    }
}
