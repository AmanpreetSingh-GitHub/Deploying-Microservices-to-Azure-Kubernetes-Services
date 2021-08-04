using Coral.Employee.Persistance.Context;
using Coral.Employee.Persistance.Entities;
using Coral.Employee.Persistance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Coral.Employee.Persistance.Repositories
{
    public class EmployeeBasicInfoRepository : IEmployeeBasicInfoRepository
    {
        private EmployeeDBContext _dbContext;
        private IGenericRepository<EmployeeBasicInfo> _genericEmployeeBasicInfoRepository;

        public EmployeeBasicInfoRepository(IUnitOfWork unitOfWork, IGenericRepository<EmployeeBasicInfo> genericEmployeeBasicInfoRepository)
        {
            _dbContext = unitOfWork.DbContext;
            _genericEmployeeBasicInfoRepository = genericEmployeeBasicInfoRepository;
        }

        public void Add(EmployeeBasicInfo entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EmployeeBasicInfo>> GetAll()
        {
            return await _genericEmployeeBasicInfoRepository.GetAll();
        }

        public Task<List<EmployeeBasicInfo>> GetAllPaged(int pageNo, int recordsPerPage)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeBasicInfo> GetItem(Expression<Func<EmployeeBasicInfo, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeBasicInfo> GetItemWithChildren(Expression<Func<EmployeeBasicInfo, bool>> filter, params Expression<Func<EmployeeBasicInfo, object>>[] children)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeeBasicInfo>> GetList(Expression<Func<EmployeeBasicInfo, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeeBasicInfo>> GetListWithChildren(Expression<Func<EmployeeBasicInfo, bool>> filter, params Expression<Func<EmployeeBasicInfo, object>>[] children)
        {
            throw new NotImplementedException();
        }
    }
}
