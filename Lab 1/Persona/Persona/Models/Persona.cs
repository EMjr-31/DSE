using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persona.Models
{
    public class Persona
    {
        public string DUI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
    }
}
