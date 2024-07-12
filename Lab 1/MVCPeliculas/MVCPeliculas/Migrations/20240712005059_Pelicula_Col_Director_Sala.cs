using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCPeliculas.Migrations
{
    public partial class Pelicula_Col_Director_Sala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sala",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Director",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "Sala",
                table: "Peliculas");
        }
    }
}
