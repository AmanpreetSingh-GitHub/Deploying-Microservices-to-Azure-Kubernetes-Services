using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Coral.MasterData.Broker.Handlers;
using Coral.MasterData.Persistance.Interfaces;
using Coral.MasterData.Persistance.Repositories;
using Coral.MasterData.Service.Interfaces;
using Coral.MasterData.Service.Services;
using System.Reflection;

namespace Coral.MasterData.Api
{
    public static class StartupExtensions
    {
        public static void AddLayeredDependencies(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeStatusService, EmployeeStatusService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IEmployeeStatusRepository, EmployeeStatusRepository>();
        }

        public static void AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetEmployeeStatusQueryHandler).Assembly);
        }
    }
}
