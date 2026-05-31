using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Model.Services;

namespace InvestLens.Shared.DataAccess.Repositories;

public class MarketRepository : BaseRepository, IMarketRepository
{
    public MarketRepository(IDatabaseService databaseService, IAuthManager authManager) 
        : base(databaseService, authManager)
    {
    }
}