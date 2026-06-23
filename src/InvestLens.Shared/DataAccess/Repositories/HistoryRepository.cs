using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Models.Services;
using InvestLens.Shared.Models.Entities.Moex;
using Microsoft.EntityFrameworkCore;

namespace InvestLens.Shared.DataAccess.Repositories;

public class HistoryRepository : BaseRepository, IHistoryRepository
{
    public HistoryRepository(IDatabaseService databaseService, IAuthManager authManager) : base(databaseService, authManager)
    {
    }

    public async Task<Dictionary<string, History>> GetAllLastHistory()
    {
        var result = await DatabaseService.DataContext.History
            .GroupBy(h => h.SecId)
            .ToDictionaryAsync(g => g.Key, g => g.OrderByDescending(v => v.Date).First());
        return result;
    }

    public async Task<Dictionary<string, History>> GetHistory(DateTime dateTime)
    {
        var result = await DatabaseService.DataContext.History
            .Where(h => h.Date < dateTime)
            .GroupBy(h => h.SecId)
            .ToDictionaryAsync(g => g.Key, g => g.OrderByDescending(v => v.Date).First());
        return result;
    }
}