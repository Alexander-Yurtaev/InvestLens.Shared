using InvestLens.Shared.Model.Entities.Settings;

namespace InvestLens.Shared.DataAccess.Repositories;

public interface ISecurityGroupRepository : IBaseRepository
{
    List<SecurityGroup> GetAll();
}