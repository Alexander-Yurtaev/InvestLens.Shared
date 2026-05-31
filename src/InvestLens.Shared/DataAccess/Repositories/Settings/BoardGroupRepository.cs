using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Model.Services;

namespace InvestLens.Shared.DataAccess.Repositories;

public class BoardGroupRepository : BaseRepository, IBoardGroupRepository
{
    public BoardGroupRepository(IDatabaseService databaseService, IAuthManager authManager) 
        : base(databaseService, authManager)
    {
    }
}