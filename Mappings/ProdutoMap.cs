using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestAPIFurb.Models;

namespace RestAPIFurb.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Preco).IsRequired();

            builder.HasOne(p => p.Comanda).WithMany(p => p.Produtos).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Produtos");
        }
    }
}
