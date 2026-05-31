using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Model.Entities.Settings;
using InvestLens.Shared.Model.Services;
using Microsoft.EntityFrameworkCore;

namespace InvestLens.Shared.DataAccess.Repositories;

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