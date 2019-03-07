using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinalDeVerdad.Migrations
{
    public partial class CambiodenombredelascolumnasNombre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Usuarios",
                newName: "NombreUsuario");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Juegos",
                newName: "NombreJuego");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Desarrolladores",
                newName: "NombreDesarrollador");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Categorias",
                newName: "NombreCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreUsuario",
                table: "Usuarios",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "NombreJuego",
                table: "Juegos",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "NombreDesarrollador",
                table: "Desarrolladores",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "NombreCategoria",
                table: "Categorias",
                newName: "Nombre");
        }
    }
}
