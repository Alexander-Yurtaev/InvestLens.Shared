using AutoMapper;
using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Models;

namespace InvestLens.Shared.DataAccess.Resolvers;

public class SecurityTypeIdResolver : IMemberValueResolver<Models.MoexApi.Responses.Security, SecurityModel, string, int?>
{
    private readonly IMoexService _moexService;

    public SecurityTypeIdResolver(IMoexService moexService)
    {
        _moexService = moexService;
    }

    public int? Resolve(Models.MoexApi.Responses.Security source, SecurityModel destination, string sourceMember, int? destMember, ResolutionContext context)
    {
        var type = _moexService.MoexDictionaries.SecurityTypes
            .FirstOrDefault(s => s.SecurityTypeName == sourceMember);
        return type?.Id;
    }
}
