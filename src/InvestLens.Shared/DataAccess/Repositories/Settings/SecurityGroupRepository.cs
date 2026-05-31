using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Model.Entities.Settings;
using InvestLens.Shared.Model.Services;

namespace InvestLens.Shared.DataAccess.Repositories;

public class SecurityGroupRepository : BaseRepository, ISecurityGroupRepository
{
    public SecurityGroupRepository(IDatabaseService databaseService, IAuthManager authManager) 
        : base(databaseService, authManager)
    {
    }

    public List<SecurityGroup> GetAll()
    {
        return DatabaseService.DataContext.SecurityGroups.ToList();
    }
}