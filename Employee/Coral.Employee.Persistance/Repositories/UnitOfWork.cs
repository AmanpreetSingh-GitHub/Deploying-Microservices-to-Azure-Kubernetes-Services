using Coral.Employee.Persistance.Context;
using Coral.Employee.Persistance.Interfaces;

namespace Coral.Employee.Persistance.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private EmployeeDBContext _dbContext;

        public EmployeeDBContext DbContext => _dbContext;
        
        public UnitOfWork(EmployeeDBContext dbContext) => _dbContext = dbContext;

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}
