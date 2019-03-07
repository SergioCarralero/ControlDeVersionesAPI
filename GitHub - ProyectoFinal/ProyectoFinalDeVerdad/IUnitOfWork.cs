using System;
using System.Threading.Tasks;
using ProyectoFinal.IRepositories;

namespace ProyectoFinal
{
    public interface IUnitOfWork : IDisposable
    {
        IUsuarioRepository Usuarios { get; }
        IJuegoRepository Juegos { get; }
        ICategoriaRepository Categorias { get; }
        IDesarrolladorRepository Desarrolladores { get; }
        IUsuarioJuegoRepository UsuariosJuegos { get; }

        Task<int> Complete();
    }
}
