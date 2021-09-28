using Microsoft.EntityFrameworkCore.Migrations;

namespace TurismoArrieriasV2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Preferencia",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prioridad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferencia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ruta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    costo = table.Column<int>(type: "int", nullable: false),
                    distancia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preferencias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<int>(type: "int", nullable: false),
                    genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lugarResidencia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sitio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    posicionX = table.Column<int>(type: "int", nullable: false),
                    posicionY = table.Column<int>(type: "int", nullable: false),
                    caracteristicas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rutaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sitio", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sitio_Ruta_rutaid",
                        column: x => x.rutaid,
                        principalTable: "Ruta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImagenSitio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sitioid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenSitio", x => x.id);
                    table.ForeignKey(
                        name: "FK_ImagenSitio_Sitio_sitioid",
                        column: x => x.sitioid,
                        principalTable: "Sitio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImagenSitio_sitioid",
                table: "ImagenSitio",
                column: "sitioid");

            migrationBuilder.CreateIndex(
                name: "IX_Sitio_rutaid",
                table: "Sitio",
                column: "rutaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagenSitio");

            migrationBuilder.DropTable(
                name: "Preferencia");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Sitio");

            migrationBuilder.DropTable(
                name: "Ruta");
        }
    }
}
