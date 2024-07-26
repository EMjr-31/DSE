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
        [StringLength(60, MinimumLength =3)]
        [Required(ErrorMessage ="El campo titutlo es requerido")]
        [Display(Name ="Titulo")]
        public string Titulo { get; set; }
        [Display(Name = "Fecha de Lanzamiento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo fecha de lanzamiento es requerido")]
        public DateTime FechaLanzmiento { get; set; }
        //Propiedades para la llave foranea
        [Required]
        [ForeignKey("Genero")]
        [Display(Name = "Genero")]
        public int? GeneroId { get; set;  }
        public Genero Genero { get; set; }
        [Column(TypeName="decimal(18,2)")]
        [Required]
        public decimal Precio { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "El campo director es requerido")]
        public string Director { get; set; }

    }
}
