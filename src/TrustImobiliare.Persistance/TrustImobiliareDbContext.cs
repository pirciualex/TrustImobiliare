using Microsoft.EntityFrameworkCore;
using TrustImobiliare.Domain.Entities;

namespace TrustImobiliare.Persistance
{
    public class TrustImobiliareDbContext : DbContext
    {
        public TrustImobiliareDbContext(DbContextOptions<TrustImobiliareDbContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TrustImobiliareDbContext).Assembly);
        }
    }
}