using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio.Entities.Models;

namespace Desafio.DAL.Interfaces
{
    public interface IEmpleadoRepository
    {
        public Task<List<Empleado>> GetEmpeladoAsync();
        public Task<Empleado> GetEmpeladoByIdAsync( int id);
        public Task<int> InsertEmpeladoAsync(Empleado empleado);
        public Task<Empleado> UpdateEmpeladoAsync(Empleado empleado);
        public Task<bool> DeleteEmpeladoAsync(int id);



    }
}
