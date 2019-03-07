using System;
using System.Collections.Generic;

namespace ProyectoFinal.Resources
{
    public class JuegoResource
    {
        public int JuegoId { get; set; }
        public string NombreJuego { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public decimal Precio { get; set; }
        public int UnidadesStock { get; set; }
        public CategoriaResource Categoria { get; set; }
        public DesarrolladorResource Desarrollador { get; set; }
        public IList<UsuarioJuegoResource> ListaUsuarios { get; set; }
    }
}
