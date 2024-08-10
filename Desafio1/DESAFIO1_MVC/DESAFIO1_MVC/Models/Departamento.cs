using System.ComponentModel.DataAnnotations;

namespace DESAFIO1_MVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}
