using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestAPIFurb.Models;

namespace RestAPIFurb.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.ProdutoId);

            builder.Property(p => p.Nome).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Preco).IsRequired();

            //builder.HasOne(p => p.Comanda).WithMany(p => p.Produtos)
            //    .HasForeignKey(p => p.ComandaId).IsRequired();

            builder.ToTable("Produtos");
        }
    }
}
