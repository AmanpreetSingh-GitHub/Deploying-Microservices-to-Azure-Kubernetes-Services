using MediatR;
using Coral.MasterData.Persistance.Entities;
using System.Collections.Generic;

namespace Coral.MasterData.Broker.Queries
{
    public class GetEmployeeStatusQuery : IRequest<List<EmployeeStatus>>
    {
        public string QueryName { get; set; }
    }
}
