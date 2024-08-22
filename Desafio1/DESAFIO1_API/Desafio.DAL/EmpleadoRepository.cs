using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Desafio.DAL.Interfaces;
using Desafio.Entities.Models;

namespace Desafio.DAL
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly IDatabaseRepository databaseRepository;

        public EmpleadoRepository(IDatabaseRepository databaseRepository) {
            this.databaseRepository = databaseRepository;
        }
        public async Task<bool> DeleteEmpeladoAsync(int id)
        {
            string query = "DELETE FORM Autores WHERE id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            return await databaseRepository.Delete(query, parameters);
        }

        public async Task<List<Empleado>> GetEmpeladoAsync()
        {
            string query = "SELECT * from Autores";
            return await databaseRepository.GetDataByQueryAsync<Empleado>(query);
        }

        public async Task<Empleado> GetEmpeladoByIdAsync(int id)
        {
            string query = "SELECT * from Autores WHERE id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            return (await databaseRepository.GetDataByQueryAsync<Empleado>(query, parameters)).FirstOrDefault();
        }

        public async Task<int> InsertEmpeladoAsync(Empleado empleado)
        {
            string query = "INSER INTO Empleado (id,Nombre,FechaNacimiento,FechaContratacion,Salario,Descripcion,DepartamentoId) VALUES (@id,@Nombre,@FechaNacimiento,@FechaContratacion,@Salario,@Descripcion,@DepartamentoId); SELECT SCOPE_IDENTITY()";
            var parameters = new DynamicParameters();
            parameters.Add("@id", empleado.Id);
            parameters.Add("@id", empleado.Nombre);
            parameters.Add("@id", empleado.FechaNacimiento);
            parameters.Add("@id", empleado.FechaContratacion);
            parameters.Add("@id", empleado.Salario);
            parameters.Add("@id", empleado.Descripcion);
            parameters.Add("@id", empleado.DepartamentoId);
            return await databaseRepository.InsertAsync<Empleado>(query, parameters);
        }

        public async Task<Empleado> UpdateEmpeladoAsync(Empleado empleado)
        {
            string query = "UPDATE Empleado SET Salario=@Salario Where Id=@Id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", empleado.Id);
            parameters.Add("@id", empleado.Salario);
            return await databaseRepository.Update<Empleado>(query, parameters);
        }
    }
}
