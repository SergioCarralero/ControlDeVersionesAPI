using System;
using System.Collections.Generic;

namespace ProyectoFinal.Entidades
{
    public class Juego
    {
        public int JuegoId { get; set; }
        public string NombreJuego { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public decimal Precio { get; set; }
        public int UnidadesStock { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int DesarrolladorId { get; set; }
        public Desarrollador Desarrollador { get; set; }
        public IList<UsuarioJuego> ListaUsuarios { get; set; }
        //public DateTime FechaCompra { get; set; }
        //public string Imagen { get; set; }


    }
}