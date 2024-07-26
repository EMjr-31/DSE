using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCPeliculas.Migrations
{
    public partial class MigracionInicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Peliculas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
