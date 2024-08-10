using System.ComponentModel.DataAnnotations;

namespace DESAFIO1_MVC.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaContratacion { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "El salario debe ser mayor que cero.")]
        public decimal Salario { get; set; }

        public string Descripcion { get; set; }

        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
    }
}
