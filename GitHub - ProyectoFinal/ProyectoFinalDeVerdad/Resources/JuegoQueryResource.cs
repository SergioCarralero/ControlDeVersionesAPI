using System;

namespace ProyectoFinalDeVerdad.Resources
{
    public class JuegoQueryResource
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
