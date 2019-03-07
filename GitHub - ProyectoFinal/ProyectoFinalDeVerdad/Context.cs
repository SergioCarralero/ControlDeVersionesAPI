using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Configuration;
using ProyectoFinal.Entidades;

namespace ProyectoFinal
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options, IConfiguration configuration) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Juego> Juegos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Desarrollador> Desarrolladores { get; set; }
        public DbSet<UsuarioJuego> UsuariosJuegos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new JuegoConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new DesarrolladorConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioJuegoConfiguration());
        }
    }
}
