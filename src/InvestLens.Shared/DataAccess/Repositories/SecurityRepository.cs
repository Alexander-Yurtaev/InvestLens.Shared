using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Model.Entities;
using InvestLens.Shared.Model.Services;
using Microsoft.EntityFrameworkCore;

namespace InvestLens.Shared.DataAccess.Repositories;

public class SecurityRepository : BaseRepository, ISecurityRepository
{
    public SecurityRepository(IDatabaseService databaseService, 
        IAuthManager authManager) : base(databaseService, authManager)
    {
    }

    public async Task AddRangeAsync(IEnumerable<Security> newSecurityList, CancellationToken ct)
    {
        await DatabaseService.DataContext.Securities.AddRangeAsync(newSecurityList, ct);
    }

    public async Task<List<string>> GetSecIdListAsync(CancellationToken ct)
    {
        var result = await DatabaseService.DataContext.Securities
            .Select(s => s.SecId)
            .ToListAsync(ct);

        return result;
    }

    public async Task<List<Security>> GetLoadedSecurityListAsync(CancellationToken ct)
    {
        var result = await DatabaseService.DataContext.Securities
            .Where(s => s.IsLoaded)
            .ToListAsync(ct);

        return result;
    }

    public async Task<List<Security>> GetUnloadedSecurityListAsync(CancellationToken ct)
    {
        var result = await DatabaseService.DataContext.Securities
            .Where(s => !s.IsLoaded)
            .ToListAsync(ct);

        return result;
    }
}