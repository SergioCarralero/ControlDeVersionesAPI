using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoFinal.Entidades;

namespace ProyectoFinal.Configuration
{
    public class DesarrolladorConfiguration : IEntityTypeConfiguration<Desarrollador>
    {
        public void Configure(EntityTypeBuilder<Desarrollador> builder)
        {
            builder.ToTable("Desarrolladores");

            builder.HasKey(d => d.DesarrolladorId);

            builder.Property(d => d.DesarrolladorId).ForSqlServerUseSequenceHiLo().UseSqlServerIdentityColumn();
            builder.Property(d => d.NombreDesarrollador).
                IsRequired();
        }
    }
}
