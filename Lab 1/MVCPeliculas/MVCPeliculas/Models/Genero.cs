using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPeliculas.Models
{
    public class Genero
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        //Propidad de navegacion 
        public ICollection<Peliculas> Peliculas { get; set; }
    }
}
