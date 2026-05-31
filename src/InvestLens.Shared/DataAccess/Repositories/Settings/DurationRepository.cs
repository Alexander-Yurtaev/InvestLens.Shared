using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Model.Services;

namespace InvestLens.Shared.DataAccess.Repositories;

public class DurationRepository : BaseRepository, IDurationRepository
{
    public DurationRepository(IDatabaseService databaseService, IAuthManager authManager) 
        : base(databaseService, authManager)
    {
    }
}