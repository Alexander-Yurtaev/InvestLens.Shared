using AutoMapper;
using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Models.MoexApi.Settings;

namespace InvestLens.Shared.DataAccess.Resolvers;

public class EngineResolver : IMemberValueResolver<Models.Entities.Settings.Board, BoardModel, int, EngineModel?>
{
    private readonly IMoexService _moexService;

    public EngineResolver(IMoexService moexService)
    {
        _moexService = moexService;
    }

    public EngineModel? Resolve(Models.Entities.Settings.Board source, BoardModel destination, int engineId, EngineModel? destMember, ResolutionContext context)
    {
        return _moexService.MoexDictionaries.Engines
            .FirstOrDefault(s => s.Id == engineId);
    }
}