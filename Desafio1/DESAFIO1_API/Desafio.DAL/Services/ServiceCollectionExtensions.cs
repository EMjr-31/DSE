using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio.DAL.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Desafio.DAL.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositoryConnector(this IServiceCollection services) {
            services.AddTransient<IDatabaseRepository, DatabaseRepository>();
            services.AddTransient<IEmpleadoRepository, EmpleadoRepository>();
            return services;
        }
    }
}
