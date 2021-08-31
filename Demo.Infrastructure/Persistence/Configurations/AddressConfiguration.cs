using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Infrastructure.Persistence.Configurations
{
    class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address").HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Street).HasMaxLength(200).IsRequired();
            builder.HasOne(x => x.City).WithMany(x => x.Addresses).HasForeignKey(x => x.CityId);
            builder.HasOne(x => x.Users).WithMany(x => x.Addresses).HasForeignKey(x => x.UserId);
        }

    }
}
