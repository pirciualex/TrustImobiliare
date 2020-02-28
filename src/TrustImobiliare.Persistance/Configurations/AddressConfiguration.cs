using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrustImobiliare.Domain.Entities;

namespace TrustImobiliare.Persistance.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(e => e.Country).HasMaxLength(15);
            builder.Property(e => e.Region)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(e => e.AddressDetail)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
}