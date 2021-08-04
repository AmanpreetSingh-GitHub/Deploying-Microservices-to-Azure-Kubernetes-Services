using Coral.MasterData.Persistance.Context;

namespace Coral.MasterData.Persistance.Interfaces
{
    public interface IUnitOfWork
    {
        MasterdataContext DbContext { get; }

        int Save();
    }
}
