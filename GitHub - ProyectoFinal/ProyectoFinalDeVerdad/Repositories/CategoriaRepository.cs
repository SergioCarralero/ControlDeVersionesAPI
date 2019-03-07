using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Entidades;
using ProyectoFinal.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(Context context) : base(context) { }

        public async Task<IList<Categoria>> GetCategoriasYPropiedadesNavegacion()
        {
            var categorias = await Context.Categorias
                                    .Include(c => c.Juegos)
                                    .ToListAsync();

            return categorias;
                                        
        }

        public Context Context
        {
            get { return Context as Context; }
        }

       
    }
}
