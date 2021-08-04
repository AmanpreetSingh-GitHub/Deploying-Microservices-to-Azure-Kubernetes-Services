using Microsoft.EntityFrameworkCore;
using Coral.MasterData.Persistance.Context;
using Coral.MasterData.Persistance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Coral.MasterData.Persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected MasterdataContext _context;

        public GenericRepository(IUnitOfWork unitOfWork) => _context = unitOfWork.DbContext;

        public async Task<List<T>> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();
            return await query.ToListAsync<T>();
        }

        public async Task<List<T>> GetAllPaged(int pageNo, int recordsPerPage)
        {
            IQueryable<T> query = _context.Set<T>().Skip((pageNo - 1) * recordsPerPage).Take(recordsPerPage);
            return await query.ToListAsync<T>();
        }

        public async Task<T> GetItem(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = _context.Set<T>();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<T> GetItemWithChildren(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] children)
        {
            IQueryable<T> query = _context.Set<T>();
            if (children.Length > 0)
            {
                query = children.Aggregate(query, (current, include) => current.Include(include));
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetList(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = _context.Set<T>();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync<T>();
        }

        public async Task<List<T>> GetListWithChildren(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] children)
        {
            IQueryable<T> query = _context.Set<T>();
            if (children.Length > 0)
            {
                query = children.Aggregate(query, (current, include) => current.Include(include));
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync<T>();
        }

        public async void Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }
    }
}
