using System.Collections.Generic;

namespace ProyectoFinal.Entidades
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }
        public IList<Juego> Juegos { get; set; }
    }
}