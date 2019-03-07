using ProyectoFinal.Entidades;
using System.Collections.Generic;

namespace ProyectoFinal.Resources
{
    public class CategoriaResource
    {
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }
        public IList<Juego> Juegos { get; set; }
    }
}
