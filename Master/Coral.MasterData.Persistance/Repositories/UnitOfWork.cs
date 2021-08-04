using Coral.MasterData.Persistance.Context;
using Coral.MasterData.Persistance.Interfaces;
using System;

namespace Coral.MasterData.Persistance.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private MasterdataContext _dbContext;

        public MasterdataContext DbContext => _dbContext;

        public UnitOfWork(MasterdataContext dbContext) => _dbContext = dbContext;

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}
