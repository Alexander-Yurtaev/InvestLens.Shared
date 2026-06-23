using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Models.Services;

namespace InvestLens.Shared.DataAccess.Repositories.Settings;

public class DurationRepository : BaseRepository, IDurationRepository
{
    public DurationRepository(IDatabaseService databaseService, IAuthManager authManager) 
        : base(databaseService, authManager)
    {
    }
}