using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrustImobiliare.Domain.Entities;

namespace TrustImobiliare.Persistance.Configurations
{
    public class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.Property(e => e.AgentId).HasColumnName("AgentId");
            builder.Property(e => e.PropertyId).HasColumnName("PropertyID");
            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(15);
            builder.Property(e => e.PhotoLink).IsRequired();
        }
    }
}