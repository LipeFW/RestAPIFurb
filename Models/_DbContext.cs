using Microsoft.EntityFrameworkCore;
using RestAPIFurb.Mappings;

namespace RestAPIFurb.Models
{
    public class _DbContext : DbContext
    {
        public _DbContext(DbContextOptions<_DbContext> options) : base(options)
        {
        }

        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProdutoMap());
            builder.ApplyConfiguration(new ComandaMap());
        }
    }
}
