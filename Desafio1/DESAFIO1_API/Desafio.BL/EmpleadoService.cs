using Desafio.BL.Interfaces;
using Desafio.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio.DAL.Interfaces;
using Desafio.Entities.DTO;
using Desafio.Entities.Models;
using AutoMapper;


namespace Desafio.BL
{
    public class EmpleadoService : IAutorService
    {
        private readonly IEmpleadoRepository repository;
        private readonly IMapper mapper;

        public EmpleadoService(IEmpleadoRepository repository, IMapper mapper) {
            this.repository = repository;
            this.mapper = mapper;
        }
       
        public async Task<bool> DeleteEmpleadoAsync(int id)
        {
            try
            {
                return await repository.DeleteEmpeladoAsync(id);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<EmpleadoDto>> GetEmpleadosAsync()
        {
            try
            {
                var result = await repository.GetEmpeladoAsync();
                return mapper.Map<List<Empleado>, List<EmpleadoDto>>(result);
            }
            catch (Exception ex)
            {
                return new List<EmpleadoDto>();
            }
        }

        public async Task<EmpleadoDto> GetEmpleadosByIdAsync(int id)
        {
            try
            {
                var result = await repository.GetEmpeladoByIdAsync(id);
                return mapper.Map<Empleado, EmpleadoDto>(result);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<int> InsertEmpleadoAsync(EmpleadoDto model)
        {
            try
            {
                var entity = mapper.Map<EmpleadoDto, Empleado>(model);
                return await repository.InsertEmpeladoAsync(entity);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public async Task<EmpleadoDto> UpdateEmpleadoAsync(EmpleadoDto model)
        {
            try
            {
                var entity = mapper.Map<EmpleadoDto, Empleado>(model);
                var result = await repository.UpdateEmpeladoAsync(entity);
                return mapper.Map<Empleado, EmpleadoDto>(result);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
