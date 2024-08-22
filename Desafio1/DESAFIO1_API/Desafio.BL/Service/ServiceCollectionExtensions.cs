using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio.BL.AutoMapper;
using Desafio.BL.Interfaces;
using Desafio.DAL.Services;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;


namespace Desafio.BL.Service
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceConnector(this IServiceCollection services) {
            services.AddAutoMapper(typeof(AutomapperProfile).Assembly);
            services.AddTransient<IAutorService, EmpleadoService>();
            services.AddRepositoryConnector();
            return services;
        }
    }
}
