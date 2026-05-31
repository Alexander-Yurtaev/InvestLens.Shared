using InvestLens.Shared.Models.Entities.Moex;

namespace InvestLens.Shared.DataAccess.Repositories;

public interface IHistoryRepository : IBaseRepository
{
    Task<Dictionary<string, History>> GetAllLastHistory();
    Task<Dictionary<string, History>> GetHistory(DateTime dateTime);
}
