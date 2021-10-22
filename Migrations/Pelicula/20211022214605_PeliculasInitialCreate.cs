using Microsoft.EntityFrameworkCore.Migrations;

namespace RetoAlk.Migrations.Pelicula
{
    public partial class PeliculasInitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pelicula",
                columns: table => new
                {
                    Titulo = table.Column<string>(type: "TEXT", nullable: false),
                    Imagen = table.Column<string>(type: "TEXT", nullable: true),
                    FechaCreacion = table.Column<string>(type: "TEXT", nullable: true),
                    Calificacion = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pelicula", x => x.Titulo);
                });

            migrationBuilder.CreateTable(
                name: "Personaje",
                columns: table => new
                {
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Imagen = table.Column<string>(type: "TEXT", nullable: true),
                    Edad = table.Column<int>(type: "INTEGER", nullable: false),
                    Peso = table.Column<float>(type: "REAL", nullable: false),
                    Historia = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personaje", x => x.Nombre);
                });

            migrationBuilder.CreateTable(
                name: "PeliculaPersonaje",
                columns: table => new
                {
                    PelSeriQueApareceTitulo = table.Column<string>(type: "TEXT", nullable: false),
                    PersonajesAsociadosNombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculaPersonaje", x => new { x.PelSeriQueApareceTitulo, x.PersonajesAsociadosNombre });
                    table.ForeignKey(
                        name: "FK_PeliculaPersonaje_Pelicula_PelSeriQueApareceTitulo",
                        column: x => x.PelSeriQueApareceTitulo,
                        principalTable: "Pelicula",
                        principalColumn: "Titulo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeliculaPersonaje_Personaje_PersonajesAsociadosNombre",
                        column: x => x.PersonajesAsociadosNombre,
                        principalTable: "Personaje",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeliculaPersonaje_PersonajesAsociadosNombre",
                table: "PeliculaPersonaje",
                column: "PersonajesAsociadosNombre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeliculaPersonaje");

            migrationBuilder.DropTable(
                name: "Pelicula");

            migrationBuilder.DropTable(
                name: "Personaje");
        }
    }
}
