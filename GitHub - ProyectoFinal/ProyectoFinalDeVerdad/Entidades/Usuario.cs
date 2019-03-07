using System.Collections.Generic;

namespace ProyectoFinal.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Apellido { get; set; }
        public string Contrasena { get; set; } // TODO: Buscar manera de encriptar la contraseña(final)
        public string Email { get; set; }
        public decimal Saldo { get; set; }
        //public string Imagen { get; set; }
        public IList<UsuarioJuego> ListaJuegos { get; set; }
    }
}
