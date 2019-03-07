using System.Collections.Generic;

namespace ProyectoFinal.Entidades
{
    public class Desarrollador
    {
        public int DesarrolladorId { get; set; }
        public string NombreDesarrollador { get; set; }
        public IList<Juego> Juegos { get; set; }
    }
}