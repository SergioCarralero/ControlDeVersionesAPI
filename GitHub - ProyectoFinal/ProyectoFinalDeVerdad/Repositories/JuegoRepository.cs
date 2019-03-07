using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Entidades;
using ProyectoFinal.IRepositories;
using ProyectoFinal.Resources;
using ProyectoFinalDeVerdad.Querys;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Repositories
{
    public class JuegoRepository : Repository<Juego>, IJuegoRepository
    {
        public JuegoRepository(Context context) : base(context) { }

        public async Task<IList<Juego>> GetJuegosYPropiedadesNavegacion()
        {
            var juegos = await Context.Juegos
                                .Include(j => j.Categoria)
                                .Include(j => j.CategoriaId)
                                .ToListAsync();

            return juegos;
        }

        public Context Context
        {
            get { return Context as Context; }
        }
    }
}
