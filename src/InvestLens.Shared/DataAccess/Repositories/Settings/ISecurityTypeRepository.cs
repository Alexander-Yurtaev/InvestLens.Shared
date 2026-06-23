using InvestLens.Shared.Models.Entities.Settings;

namespace InvestLens.Shared.DataAccess.Repositories.Settings;

public interface ISecurityTypeRepository : IBaseRepository
{
    Task<List<SecurityType>> GetAllAsync();
}