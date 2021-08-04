using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Coral.Employee.Broker.Handlers;
using Coral.Employee.Persistance.Interfaces;
using Coral.Employee.Persistance.Repositories;
using Coral.Employee.Service.Interfaces;
using Coral.Employee.Service.Services;

namespace Coral.Employee.Api
{
    public static class StartupExtensions
    {
        public static void AddLayeredDependencies(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeBasicInfoService, EmployeeBasicInfoService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IEmployeeBasicInfoRepository, EmployeeBasicInfoRepository>();
        }

        public static void AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetEmployeeBasicInfoQueryHandler).Assembly);
        }
    }
}
