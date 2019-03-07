using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinalDeVerdad.Migrations
{
    public partial class CreartablaintermediaentreUsuariosyJuegosUsuariosJuegos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Juegos_Juegos_JuegoId1",
                table: "Juegos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Usuarios_UsuarioId1",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_UsuarioId1",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Juegos_JuegoId1",
                table: "Juegos");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "JuegoId1",
                table: "Juegos");

            migrationBuilder.CreateTable(
                name: "UsuariosJuegos",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false),
                    JuegoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosJuegos", x => new { x.JuegoId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_UsuariosJuegos_Juegos_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "Juegos",
                        principalColumn: "JuegoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosJuegos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosJuegos_UsuarioId",
                table: "UsuariosJuegos",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuariosJuegos");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId1",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JuegoId1",
                table: "Juegos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioId1",
                table: "Usuarios",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_JuegoId1",
                table: "Juegos",
                column: "JuegoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Juegos_Juegos_JuegoId1",
                table: "Juegos",
                column: "JuegoId1",
                principalTable: "Juegos",
                principalColumn: "JuegoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Usuarios_UsuarioId1",
                table: "Usuarios",
                column: "UsuarioId1",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
