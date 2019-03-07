using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoFinal.Entidades;

namespace ProyectoFinal.Configuration
{
    public class JuegoConfiguration : IEntityTypeConfiguration<Juego>
    {
        public void Configure(EntityTypeBuilder<Juego> builder)
        {
            builder.ToTable("Juegos");

            builder.HasKey(j => j.JuegoId);

            builder.Property(j => j.JuegoId).ForSqlServerUseSequenceHiLo().UseSqlServerIdentityColumn();
            builder.Property(j => j.NombreJuego)
                .IsRequired();
            builder.Property(j => j.UnidadesStock)
                .IsRequired();
            builder.Property(j => j.Precio)
                .IsRequired();
            builder.Property(j => j.FechaLanzamiento)
                .HasColumnType("date")
                .IsRequired();

            builder.HasOne<Categoria>(j => j.Categoria)
                .WithMany(c => c.Juegos)
                .HasForeignKey(j => j.CategoriaId);

            builder.HasOne<Desarrollador>(j => j.Desarrollador)
                .WithMany(d => d.Juegos)
                .HasForeignKey(j => j.DesarrolladorId);
        }

    }
}
