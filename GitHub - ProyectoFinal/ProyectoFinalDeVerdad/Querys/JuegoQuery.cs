using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalDeVerdad.Querys
{
    public class JuegoQuery
    {
        public int JuegoId { get; set; }
        public string NombreJuego { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public decimal Precio { get; set; }
        public int UnidadesStock { get; set; }
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }
        public int DesarrolladorId { get; set; }
        public string NombreDesarrollador { get; set; }
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
    }
}
