using System.Threading.Tasks;
using ProyectoFinal.IRepositories;
using ProyectoFinal.Repositories;

namespace ProyectoFinal
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        public UnitOfWork(Context context)
        {
            _context = context;
            Usuarios = new UsuarioRepository(_context);
            Juegos = new JuegoRepository(_context);
            Categorias = new CategoriaRepository(_context);
            Desarrolladores = new DesarrolladorRepository(_context);
            UsuariosJuegos = new UsuarioJuegoRepository(_context);

        }

        public IUsuarioRepository Usuarios { get; private set; }
        public IJuegoRepository Juegos{ get; private set; }
        public ICategoriaRepository Categorias { get; private set; }
        public IDesarrolladorRepository Desarrolladores { get; private set; }
        public IUsuarioJuegoRepository UsuariosJuegos { get; private set; }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
