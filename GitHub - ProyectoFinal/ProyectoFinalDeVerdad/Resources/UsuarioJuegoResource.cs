using ProyectoFinal.Entidades;

namespace ProyectoFinal.Resources
{
    public class UsuarioJuegoResource
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int JuegoId { get; set; }
        public Juego Juego { get; set; }
    }
}
