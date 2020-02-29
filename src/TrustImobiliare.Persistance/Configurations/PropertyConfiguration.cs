using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrustImobiliare.Domain.Entities;

namespace TrustImobiliare.Persistance.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.Property(e => e.PropertyId).HasColumnName("PropertyID");
            builder.Property(e => e.AgentId).HasColumnName("AgentID");
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
            builder.HasOne(d=>d.Address)
                .WithOne(p=>p.Property)
                .HasForeignKey<Address>(d=>d.PropertyId)
                .HasConstraintName("FK_Properties_Addresses");
            builder.HasOne(d => d.Agent)
                .WithMany(p => p.Properties)
                .HasForeignKey(d => d.AgentId)
                .HasConstraintName("FK_Properties_Agents");
            builder.HasOne(d => d.Type)
                .WithOne(p => p.Property)
                .HasForeignKey<Type>(d => d.PropertyId)
                .HasConstraintName("FK_Properties_Types");
        }
    }
}