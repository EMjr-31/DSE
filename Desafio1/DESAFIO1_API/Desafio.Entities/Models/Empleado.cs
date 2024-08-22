using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Entities.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }
        [Required(ErrorMessage="El Salario es requerido")]
        public decimal Salario { get; set; }
        public string Descripcion { get; set; }
        public int DepartamentoId { get; set; }
    }
}
