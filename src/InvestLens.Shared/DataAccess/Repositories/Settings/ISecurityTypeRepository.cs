using InvestLens.Shared.Model.Entities.Settings;

namespace InvestLens.Shared.DataAccess.Repositories;

public interface ISecurityTypeRepository : IBaseRepository
{
    Task<List<SecurityType>> GetAllAsync();
}