using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Infrastructure.Persistence.Configurations
{
    class GovermanteConfiguration : IEntityTypeConfiguration<Government>
    {
        public void Configure(EntityTypeBuilder<Government> builder)
        {
            builder.ToTable("Government").HasKey(x=>x.Id);
            builder.Property(x => x.GovName).HasMaxLength(30).IsRequired();
     

        }

    }
}
