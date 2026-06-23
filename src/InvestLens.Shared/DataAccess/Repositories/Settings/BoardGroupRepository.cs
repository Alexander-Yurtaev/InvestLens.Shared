using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Models.Services;

namespace InvestLens.Shared.DataAccess.Repositories.Settings;

public class BoardGroupRepository : BaseRepository, IBoardGroupRepository
{
    public BoardGroupRepository(IDatabaseService databaseService, IAuthManager authManager) 
        : base(databaseService, authManager)
    {
    }
}