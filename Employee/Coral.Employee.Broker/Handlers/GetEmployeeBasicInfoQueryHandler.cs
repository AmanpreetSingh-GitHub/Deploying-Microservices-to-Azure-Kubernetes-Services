using MediatR;
using Coral.Employee.Broker.Queries;
using Coral.Employee.Persistance.Entities;
using Coral.Employee.Persistance.Interfaces;
using Coral.Infrastructure.CrossCutting.Constants;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Coral.Employee.Broker.Handlers
{
    public class GetEmployeeBasicInfoQueryHandler : IRequestHandler<GetEmployeeBasicInfoQuery, List<EmployeeBasicInfo>>
    {
        private IUnitOfWork _unitOfWork;
        private IEmployeeBasicInfoRepository _employeeBasicInfoRepository;

        public GetEmployeeBasicInfoQueryHandler(IEmployeeBasicInfoRepository employeeBasicInfoRepository)
        {
            _employeeBasicInfoRepository = employeeBasicInfoRepository;
        }

        public async Task<List<EmployeeBasicInfo>> Handle(GetEmployeeBasicInfoQuery request, CancellationToken cancellationToken)
        {
            switch (request.QueryName)
            {
                case Constants.QueryAll:
                    return await _employeeBasicInfoRepository.GetAll();
            }
            return null;
        }
    }
}
