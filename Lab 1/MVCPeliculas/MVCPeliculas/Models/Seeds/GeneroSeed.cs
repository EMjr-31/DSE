using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVCPeliculas.Models.Seeds
{
    public class GeneroSeed : IEntityTypeConfiguration<Genero>
    {
        void IEntityTypeConfiguration<Genero>.Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.HasData(
                new Genero { id = 1, Nombre = "Comedia" },
                new Genero { id = 2, Nombre = "Romance" },
                new Genero { id = 3, Nombre = "Aventura" },
                new Genero { id = 4, Nombre = "Accion" },
                new Genero { id = 5, Nombre = "Ficcion" },
                new Genero { id = 6, Nombre = "Drama" });
        }
    }

}
