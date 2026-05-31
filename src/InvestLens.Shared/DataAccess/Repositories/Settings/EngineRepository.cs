using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Model.Services;

namespace InvestLens.Shared.DataAccess.Repositories.Settings;

public class EngineRepository : BaseRepository, IEngineRepository
{
    public EngineRepository(IDatabaseService databaseService, IAuthManager authManager) 
        : base(databaseService, authManager)
    {
    }
}