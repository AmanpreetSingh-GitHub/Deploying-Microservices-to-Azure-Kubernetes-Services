using Coral.MasterData.Persistance.Context;
using Coral.MasterData.Persistance.Entities;
using Coral.MasterData.Persistance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Coral.MasterData.Persistance.Repositories
{
    public class EmployeeStatusRepository : IEmployeeStatusRepository
    {
        private MasterdataContext _dbContext;
        private IGenericRepository<EmployeeStatus> _genericEmployeeStatusRepository;

        public EmployeeStatusRepository(IUnitOfWork unitOfWork, IGenericRepository<EmployeeStatus> genericEmployeeStatusRepository)
        {
            _dbContext = unitOfWork.DbContext;
            _genericEmployeeStatusRepository = genericEmployeeStatusRepository;
        }

        public void Add(EmployeeStatus entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EmployeeStatus>> GetAll()
        {
            return await _genericEmployeeStatusRepository.GetAll();
        }

        public Task<List<EmployeeStatus>> GetAllPaged(int pageNo, int recordsPerPage)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeStatus> GetItem(Expression<Func<EmployeeStatus, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeStatus> GetItemWithChildren(Expression<Func<EmployeeStatus, bool>> filter, params Expression<Func<EmployeeStatus, object>>[] children)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeeStatus>> GetList(Expression<Func<EmployeeStatus, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeeStatus>> GetListWithChildren(Expression<Func<EmployeeStatus, bool>> filter, params Expression<Func<EmployeeStatus, object>>[] children)
        {
            throw new NotImplementedException();
        }
    }
}
