using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPeliculas.Models
{
    public class Peliculas
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaLanzmiento { get; set; }
        public string Genero { get; set; }
        public decimal Precio { get; set; }

    }
}
