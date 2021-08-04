using MediatR;
using Coral.Infrastructure.CrossCutting.Constants;
using Coral.MasterData.Broker.Queries;
using Coral.MasterData.Persistance.Entities;
using Coral.MasterData.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coral.MasterData.Service.Services
{
    public class EmployeeStatusService : IEmployeeStatusService
    {
        private readonly IMediator _mediator;

        public EmployeeStatusService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<List<EmployeeStatus>> GetAll()
        {
            return await _mediator.Send(new GetEmployeeStatusQuery { QueryName = Constants.QueryAll });
        }
    }
}
