
namespace ProyectoFinal.Entidades
{
    public class UsuarioJuego
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int JuegoId { get; set; }
        public Juego Juego { get; set; }
    }
}
