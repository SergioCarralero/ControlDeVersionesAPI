using ProyectoFinal.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.IRepositories
{
    public interface IJuegoRepository : IRepository<Juego>
    {
        Task<IList<Juego>> GetJuegosYPropiedadesNavegacion();
    }
}
