using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrustImobiliare.Domain.Entities;

namespace TrustImobiliare.Persistance.Configurations
{
    public class FeatureConfiguration:IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder.HasOne(d => d.Property)
                .WithMany(p => p.Features)
                .HasForeignKey(d => d.PropertyId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_Features_Properties");
        }
    }
}