using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoFinal.Entidades;

namespace ProyectoFinal.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(u => u.UsuarioId);

            builder.Property(u => u.UsuarioId).ForSqlServerUseSequenceHiLo().UseSqlServerIdentityColumn();
            builder.Property(u => u.NombreUsuario)
                .IsRequired();
            builder.Property(u => u.Apellido)
                .IsRequired();
            builder.Property(u => u.Contrasena)
                .IsRequired();
            builder.Property(u => u.Email)
                .IsRequired();
            builder.Property(u => u.Saldo)
                .IsRequired();
        }
    }
}
