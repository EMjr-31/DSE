using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPeliculas.Models
{
    public class Peliculas
    {
        public int ID { get; set; }
        [StringLength(250)]
        [Required]

        public string Titulo { get; set; }

        public DateTime FechaLanzmiento { get; set; }
        //Propiedades para la llave foranea
        [Required]
        [ForeignKey("Genero")]
        public int? GeneroId { get; set;  }
        public string Genero { get; set; }

        public decimal Precio { get; set; }

        [StringLength(250)]
        [Required]
        public string Director { get; set; }

    }
}
