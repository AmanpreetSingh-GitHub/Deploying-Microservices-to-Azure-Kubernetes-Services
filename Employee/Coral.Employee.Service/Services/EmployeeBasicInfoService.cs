using MediatR;
using Coral.Employee.Broker.Queries;
using Coral.Employee.Domain;
using Coral.Employee.Service.Interfaces;
using Coral.Infrastructure.CrossCutting.Constants;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coral.Employee.Service.Services
{
    public class EmployeeBasicInfoService : IEmployeeBasicInfoService
    {
        private readonly IMediator _mediator;

        public EmployeeBasicInfoService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<List<EmployeeCompositeInfo>> GetAllEmployeeBasicInfo()
        {
            var employeeCompositeInfoList = new List<EmployeeCompositeInfo>();

            var employeeList = await _mediator.Send(new GetEmployeeBasicInfoQuery { QueryName = Constants.QueryAll });

            foreach (var employee in employeeList)
            {
                var employeeCompositeInfo = new EmployeeCompositeInfo
                {
                    EmployeeId = employee.EmployeeId,
                    EmployeeNumber = employee.EmployeeNumber,
                    Address = employee.Address,
                    ContactNumber = employee.ContactNumber,
                    DateOfBirth = employee.DateOfBirth,
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    LastName = employee.LastName,
                    FatherName = employee.FatherName,
                    Gender = employee.Gender,
                    OfficeEmail = employee.OfficeEmail,
                    SpouseName = employee.SpouseName,
                    StatusId = employee.StatusId,
                    StatusName = string.Empty,
                    MaritalStatusId = employee.MaritalStatusId,
                    CreatedBy = employee.CreatedBy,
                    CreatedDate = employee.CreatedDate,
                    UpdatedBy = employee.UpdatedBy,
                    UpdatedDate = employee.UpdatedDate
                };

                employeeCompositeInfoList.Add(employeeCompositeInfo);
            }

            return employeeCompositeInfoList;
        }
    }
}
