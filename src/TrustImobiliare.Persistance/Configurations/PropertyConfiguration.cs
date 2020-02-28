using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrustImobiliare.Domain.Entities;

namespace TrustImobiliare.Persistance.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(40);
            builder.Property(e => e.Description).HasColumnType("ntext");
            builder.Property(e => e.Price)
                .IsRequired()
                .HasColumnType("money");
            builder.Property(e => e.Status)
                .IsRequired()
                .HasMaxLength(13);
            builder.Property(e => e.Surface).IsRequired();
            builder.Property(e => e.PrimaryPhotoLink)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}