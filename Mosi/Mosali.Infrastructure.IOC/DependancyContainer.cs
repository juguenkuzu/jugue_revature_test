using Microsoft.Extensions.DependencyInjection;
using Mosali.Application.AutoMapper;
using Mosali.Application.Interface;
using Mosali.Application.Validators;
using Mosali.Domaine.Interfaces.Repositories;
using Mosali.Domaine.Interfaces.Services;
using Mosali.Domaine.Services;
using Mosali.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mosali.Infrastructure.IOC
{
    public static class DependancyContainer
    {
        public static IServiceCollection AddInsfranstructure(this IServiceCollection services)
        {



            services.AddTransient<IEmployeeAppService, EmployeeAppService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IAutoMapperConfig, AutoMapperConfig>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();

            return services;
        }
    }
}
