using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestAPIFurb.Models;

namespace RestAPIFurb.Mappings
{
    public class ComandaMap : IEntityTypeConfiguration<Comanda>
    {
        public void Configure(EntityTypeBuilder<Comanda> builder)
        {
            builder.HasKey(c => c.ComandaId);

            builder.Property(c => c.IdUsuario).IsRequired();
            builder.Property(c => c.NomeUsuario).HasMaxLength(255).IsRequired();
            builder.Property(c => c.TelefoneUsuario).HasMaxLength(255).IsRequired();

            builder.HasMany(c => c.Produtos);

            builder.ToTable("Comandas");
        }
    }
}
