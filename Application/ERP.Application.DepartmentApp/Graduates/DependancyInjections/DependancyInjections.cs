using ERP.Application.DepartmentApp.Graduates.Interfaces;
using ERP.Application.DepartmentApp.Graduates.UseCases;
using ERP.Application.DepartmentApp.Labs.Interfaces;
using ERP.Application.DepartmentApp.Labs.UseCases;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Graduates.DependancyInjections
{
    public static class DependancyInjections
    {
        public static IServiceCollection GraduateServices(
             this IServiceCollection services)
        {
            services.AddScoped<IGetLabEquipmentListUseCase, GetLabEquipmentlistUseCase>();
            services.AddScoped<IAddGraduateInterface , AddGraduateUseCase>();

            return services;
        }
    }
}
