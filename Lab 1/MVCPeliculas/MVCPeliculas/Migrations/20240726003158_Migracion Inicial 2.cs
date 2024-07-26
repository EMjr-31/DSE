using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCPeliculas.Migrations
{
    public partial class MigracionInicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Comedia" },
                    { 2, "Romance" },
                    { 3, "Aventura" },
                    { 4, "Accion" },
                    { 5, "Ficcion" },
                    { 6, "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "ID", "Director", "FechaLanzmiento", "Genero", "GeneroId", "Precio", "Titulo" },
                values: new object[] { 2, "Peter Jackson", new DateTime(2002, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 11.99m, "El senior de los anillos:Las dos torres" });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "ID", "Director", "FechaLanzmiento", "Genero", "GeneroId", "Precio", "Titulo" },
                values: new object[] { 1, "Hermanas Wachowski", new DateTime(2003, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 9.99m, "Matriz recargado" });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "ID", "Director", "FechaLanzmiento", "Genero", "GeneroId", "Precio", "Titulo" },
                values: new object[] { 3, "Chris Columbus", new DateTime(2002, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 9.99m, "Harry Potter y la camara secreta" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
