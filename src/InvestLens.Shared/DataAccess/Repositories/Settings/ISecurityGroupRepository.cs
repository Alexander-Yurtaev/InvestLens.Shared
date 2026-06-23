using InvestLens.Shared.Models.Entities.Settings;

namespace InvestLens.Shared.DataAccess.Repositories.Settings;

public interface ISecurityGroupRepository : IBaseRepository
{
    List<SecurityGroup> GetAll();
}