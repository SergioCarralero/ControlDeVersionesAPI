using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoFinal.Entidades;

namespace ProyectoFinal.Configuration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categorias");

            builder.HasKey(c => c.CategoriaId);

            builder.Property(c => c.CategoriaId).ForSqlServerUseSequenceHiLo().UseSqlServerIdentityColumn();
            builder.Property(c => c.NombreCategoria)
                .IsRequired();
        }
    }
}
