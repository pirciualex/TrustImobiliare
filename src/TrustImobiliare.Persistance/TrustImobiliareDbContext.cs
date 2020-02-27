using Microsoft.EntityFrameworkCore;
using TrustImobiliare.Domain.Entities;

namespace TrustImobiliare.Persistance
{
    public class TrustImobiliareDbContext : DbContext
    {
        public TrustImobiliareDbContext(DbContextOptions<TrustImobiliareDbContext> options) : base(options)
        {

        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Type> Types { get; set; }
    }
}