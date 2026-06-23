using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Models.Services;

namespace InvestLens.Shared.DataAccess.Repositories.Settings;

public class BoardRepository : BaseRepository, IBoardRepository
{
    public BoardRepository(IDatabaseService databaseService, IAuthManager authManager) 
        : base(databaseService, authManager)
    {
    }
}