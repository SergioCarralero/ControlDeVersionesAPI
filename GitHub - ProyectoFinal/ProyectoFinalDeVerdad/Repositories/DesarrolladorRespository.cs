using ProyectoFinal.Entidades;
using ProyectoFinal.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Repositories
{
    public class DesarrolladorRepository : Repository<Desarrollador>, IDesarrolladorRepository
    {
        public DesarrolladorRepository(Context context) : base(context) { }

        public Context Context
        {
            get { return Context as Context; }
        }
    }
}
