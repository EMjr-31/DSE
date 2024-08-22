using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Desafio.Entities.DTO
{
    public class EmpleadoDto
    {
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public DateTime FechaNacimientoEmpleado { get; set; }
        public DateTime FechaContratacionEmpleado { get; set; }
        [Required(ErrorMessage = "El Salario es requerido")]
        public decimal SalarioEmpleado { get; set; }
        public string DescripcionEmpleado { get; set; }
        public int DepartamentoIdEmpleado { get; set; }
    }
}
