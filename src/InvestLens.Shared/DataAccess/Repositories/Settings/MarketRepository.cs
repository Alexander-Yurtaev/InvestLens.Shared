using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Models.Services;

namespace InvestLens.Shared.DataAccess.Repositories.Settings;

public class MarketRepository : BaseRepository, IMarketRepository
{
    public MarketRepository(IDatabaseService databaseService, IAuthManager authManager) 
        : base(databaseService, authManager)
    {
    }
}