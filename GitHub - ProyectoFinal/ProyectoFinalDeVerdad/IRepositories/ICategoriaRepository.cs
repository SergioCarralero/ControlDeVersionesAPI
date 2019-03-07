using ProyectoFinal.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.IRepositories
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        Task<IList<Categoria>> GetCategoriasYPropiedadesNavegacion();
    }
}
