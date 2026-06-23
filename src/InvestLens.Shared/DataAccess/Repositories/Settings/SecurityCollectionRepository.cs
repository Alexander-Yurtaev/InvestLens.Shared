using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Models.Services;

namespace InvestLens.Shared.DataAccess.Repositories.Settings;

public class SecurityCollectionRepository : BaseRepository, ISecurityCollectionRepository
{
    public SecurityCollectionRepository(IDatabaseService databaseService, IAuthManager authManager) 
        : base(databaseService, authManager)
    {
    }
}