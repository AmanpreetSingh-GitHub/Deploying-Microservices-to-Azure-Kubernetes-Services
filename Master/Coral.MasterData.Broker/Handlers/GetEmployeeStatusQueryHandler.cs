using MediatR;
using Coral.Infrastructure.CrossCutting.Constants;
using Coral.MasterData.Broker.Queries;
using Coral.MasterData.Persistance.Entities;
using Coral.MasterData.Persistance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Coral.MasterData.Broker.Handlers
{
    public class GetEmployeeStatusQueryHandler : IRequestHandler<GetEmployeeStatusQuery, List<EmployeeStatus>>
    {
        private IUnitOfWork _unitOfWork;
        private IEmployeeStatusRepository _employeeStatusRepository;

        public GetEmployeeStatusQueryHandler(IEmployeeStatusRepository employeeStatusRepository)
        {
            _employeeStatusRepository = employeeStatusRepository;
        }

        public async Task<List<EmployeeStatus>> Handle(GetEmployeeStatusQuery request, CancellationToken cancellationToken)
        {
            switch (request.QueryName)
            {
                case Constants.QueryAll:
                    return await _employeeStatusRepository.GetAll();
            }
            return null;
        }
    }
}
