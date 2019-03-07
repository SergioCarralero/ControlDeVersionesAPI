using ProyectoFinal.Entidades;
using System.Collections.Generic;

namespace ProyectoFinal.Resources
{
    public class UsuarioResource
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Apellido { get; set; }
        public string Contrasena { get; set; }
        public string Email { get; set; }
        public decimal Saldo { get; set; }
        //public string Imagen { get; set; }
        public IList<UsuarioJuegoResource> ListaJuegos { get; set; }
    }
}
