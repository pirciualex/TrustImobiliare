using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrustImobiliare.Domain.Entities;

namespace TrustImobiliare.Persistance.Configurations
{
    public class TypeConfiguration : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.Property(e => e.TypeId).HasColumnName("TypeID");
        }
    }
}