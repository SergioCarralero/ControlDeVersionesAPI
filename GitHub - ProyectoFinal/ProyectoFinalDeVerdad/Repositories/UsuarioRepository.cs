using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Entidades;
using ProyectoFinal.IRepositories;
using System.Collections.Generic;

namespace ProyectoFinal.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Context context) : base(context) { }


        public Context Context
        {
            get { return Context as Context; }
        }
    }
}
