using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Models.Entities.Settings;
using InvestLens.Shared.Models.Services;
using Microsoft.EntityFrameworkCore;

namespace InvestLens.Shared.DataAccess.Repositories.Settings;

public class SecurityTypeRepository : BaseRepository, ISecurityTypeRepository
{
    public SecurityTypeRepository(IDatabaseService databaseService, IAuthManager authManager) 
        : base(databaseService, authManager)
    {
    }

    public async Task<List<SecurityType>> GetAllAsync()
    {
        return await DatabaseService.DataContext.SecurityTypes.ToListAsync();
    }
}