using Coral.Employee.Persistance.Context;

namespace Coral.Employee.Persistance.Interfaces
{
    public interface IUnitOfWork
    {
        EmployeeDBContext DbContext { get; }

        int Save();
    }
}
