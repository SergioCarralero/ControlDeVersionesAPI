using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoFinal.Entidades;


namespace ProyectoFinal.Configuration
{
    public class UsuarioJuegoConfiguration : IEntityTypeConfiguration<UsuarioJuego>
    {
        public void Configure(EntityTypeBuilder<UsuarioJuego> builder)
        {
            builder.ToTable("UsuariosJuegos");

            builder.HasKey(uj => new { uj.JuegoId, uj.UsuarioId});
        }
    }
}
