using Coral.MasterData.Persistance.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coral.MasterData.Service.Interfaces
{
    public interface IEmployeeStatusService
    {
        Task<List<EmployeeStatus>> GetAll();
    }
}
