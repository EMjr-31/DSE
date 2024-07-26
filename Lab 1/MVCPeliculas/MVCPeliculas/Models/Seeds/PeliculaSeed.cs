using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVCPeliculas.Models.Seeds
{
    public class PeliculaSeed : IEntityTypeConfiguration<Peliculas>
    {
        void IEntityTypeConfiguration<Peliculas>.Configure(EntityTypeBuilder<Peliculas> builder)
        {
            builder.HasData(
                new Peliculas
                {
                    // Asigna valores a las propiedades de la entidad Peliculas.
                    ID = 1,
                    Titulo = "Matriz recargado",
                    FechaLanzmiento = DateTime.Parse("2003-11-13"),
                    GeneroId= 4,
                    Precio = 9.99M,
                    Director="Hermanas Wachowski"
                },
                new Peliculas
                {
                    // Asigna valores a las propiedades de la entidad Peliculas.
                    ID = 2,
                    Titulo = "El senior de los anillos:Las dos torres",
                    FechaLanzmiento = DateTime.Parse("2002-12-18"),
                    GeneroId = 3,
                    Precio = 11.99M,
                    Director = "Peter Jackson"
                },
                new Peliculas
                {
                    // Asigna valores a las propiedades de la entidad Peliculas.
                    ID = 3,
                    Titulo = "Harry Potter y la camara secreta",
                    FechaLanzmiento = DateTime.Parse("2002-11-15"),
                    GeneroId = 5,
                    Precio = 9.99M,
                    Director = "Chris Columbus"
                }
            );
        }
    }
}
