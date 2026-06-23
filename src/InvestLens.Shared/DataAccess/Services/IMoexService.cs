using InvestLens.Shared.Models;
using InvestLens.Shared.Models.Entities;

namespace InvestLens.Shared.DataAccess.Services;

public interface IMoexService
{
    MoexCache MoexDictionaries { get; }
    Task<List<SecurityModel>> GetSecurityList(IEnumerable<string> secIdNewList, CancellationToken ct);
    Task LoadHistory(Security security, CancellationToken ct);
    Task LoadMoexIndex(CancellationToken ct);
}