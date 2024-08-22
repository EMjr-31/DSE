using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio.Entities.DTO;

namespace Desafio.BL.Interfaces
{
    public interface IAutorService
    {
        public Task<List<EmpleadoDto>> GetEmpleadosAsync();
        public Task<EmpleadoDto> GetEmpleadosByIdAsync (int id);
        public Task<int> InsertEmpleadoAsync(EmpleadoDto empleado);
        public Task<EmpleadoDto> UpdateEmpleadoAsync(EmpleadoDto empleado);
        public Task<bool> DeleteEmpleadoAsync(int id);

    }
}
