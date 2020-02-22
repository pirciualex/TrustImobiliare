using Microsoft.EntityFrameworkCore;
using TrustImobiliare.Domain.Entities;

namespace Persistance
{
    public class TrustImobiliareDbContext : DbContext
    {
        public TrustImobiliareDbContext(DbContextOptions<TrustImobiliareDbContext> options) : base(options)
        {

        }

        public DbSet<Household> Households { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Type> Types { get; set; }
    }
}