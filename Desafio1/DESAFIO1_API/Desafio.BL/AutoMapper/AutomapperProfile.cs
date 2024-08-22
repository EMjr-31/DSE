using AutoMapper;
using Desafio.Entities.DTO;
using Desafio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.BL.AutoMapper
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile() {
            CreateMap<Empleado, EmpleadoDto>()
                .ForMember(destination => destination.IdEmpleado, option => option.MapFrom(source => source.Id))
                .ForMember(destination => destination.NombreEmpleado, option => option.MapFrom(source => source.Nombre))
                .ForMember(destination => destination.FechaNacimientoEmpleado, option => option.MapFrom(source => source.FechaNacimiento))
                .ForMember(destination => destination.FechaContratacionEmpleado, option => option.MapFrom(source => source.FechaContratacion))
                .ForMember(destination => destination.DescripcionEmpleado, option => option.MapFrom(source => source.Descripcion))
                .ForMember(destination => destination.DepartamentoIdEmpleado, option => option.MapFrom(source => source.DepartamentoId))
                .ReverseMap();
        }
    }
}
