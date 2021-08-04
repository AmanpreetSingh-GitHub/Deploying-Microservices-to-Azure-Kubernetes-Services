using System.Collections.Generic;
using MediatR;
using Coral.Employee.Persistance.Entities;

namespace Coral.Employee.Broker.Queries
{
    public class GetEmployeeBasicInfoQuery : IRequest<List<EmployeeBasicInfo>>
    {
        public string QueryName { get; set; }
    }
}
