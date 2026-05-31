using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Model.Services;

namespace InvestLens.Shared.DataAccess.Repositories;

public class SecurityCollectionRepository : BaseRepository, ISecurityCollectionRepository
{
    public SecurityCollectionRepository(IDatabaseService databaseService, IAuthManager authManager) 
        : base(databaseService, authManager)
    {
    }
}