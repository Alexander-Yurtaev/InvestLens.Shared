using AutoMapper;
using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Models.MoexApi.Settings;

namespace InvestLens.Shared.DataAccess.Resolvers;

public class MarketResolver : IMemberValueResolver<Models.Entities.Settings.Board, BoardModel, int, MarketModel?>
{
    private readonly IMoexService _moexService;

    public MarketResolver(IMoexService moexService)
    {
        _moexService = moexService;
    }

    public MarketModel? Resolve(Models.Entities.Settings.Board source, BoardModel destination, int marketId, MarketModel? destMember, ResolutionContext context)
    {
        return _moexService.MoexDictionaries.Markets
            .FirstOrDefault(s => s.Id == marketId);
    }
}