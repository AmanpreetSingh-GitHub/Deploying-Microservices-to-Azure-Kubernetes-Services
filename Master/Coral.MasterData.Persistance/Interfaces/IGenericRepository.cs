using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Coral.MasterData.Persistance.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetItem(Expression<Func<T, bool>> filter);
        Task<T> GetItemWithChildren(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] children);
        Task<List<T>> GetAll();
        Task<List<T>> GetAllPaged(int pageNo, int recordsPerPage);
        Task<List<T>> GetList(Expression<Func<T, bool>> filter);
        Task<List<T>> GetListWithChildren(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] children);
        void Add(T entity);
    }
}
