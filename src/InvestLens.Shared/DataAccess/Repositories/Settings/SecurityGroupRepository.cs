using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Models.Entities.Settings;
using InvestLens.Shared.Models.Services;

namespace InvestLens.Shared.DataAccess.Repositories.Settings;

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