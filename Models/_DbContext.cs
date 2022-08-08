using Microsoft.EntityFrameworkCore;

namespace RestAPIFurb.Models
{
    public class _DbContext : DbContext
    {
        public _DbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Comanda> Comandas { get; set; }
    }
}
