using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Model.Services;

namespace InvestLens.Shared.DataAccess.Repositories;

public class BoardRepository : BaseRepository, IBoardRepository
{
    public BoardRepository(IDatabaseService databaseService, IAuthManager authManager) 
        : base(databaseService, authManager)
    {
    }
}