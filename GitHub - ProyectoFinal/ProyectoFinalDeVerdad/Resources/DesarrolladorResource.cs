using ProyectoFinal.Entidades;
using System.Collections.Generic;

namespace ProyectoFinal.Resources
{
    public class DesarrolladorResource
    {
        public int DesarrolladorId { get; set; }
        public string NombreDesarrollador { get; set; }
        public IList<Juego> Juegos { get; set; }
    }
}
