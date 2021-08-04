using Coral.Employee.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coral.Employee.Service.Interfaces
{
    public interface IEmployeeBasicInfoService
    {
        Task<List<EmployeeCompositeInfo>> GetAllEmployeeBasicInfo();
    }
}
