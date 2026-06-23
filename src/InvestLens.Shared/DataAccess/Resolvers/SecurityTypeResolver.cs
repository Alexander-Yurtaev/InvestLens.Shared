using AutoMapper;
using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Models;
using InvestLens.Shared.Models.MoexApi.Settings;

namespace InvestLens.Shared.DataAccess.Resolvers;

public class SecurityTypeResolver : IMemberValueResolver<Models.MoexApi.Responses.Security, SecurityModel, string, SecurityTypeModel?>
{
    private readonly IMoexService _moexService;

    public SecurityTypeResolver(IMoexService moexService)
    {
        _moexService = moexService;
    }

    public SecurityTypeModel? Resolve(Models.MoexApi.Responses.Security source, SecurityModel destination, string sourceMember, SecurityTypeModel? destMember, ResolutionContext context)
    {
        return _moexService.MoexDictionaries.SecurityTypes
            .FirstOrDefault(s => s.SecurityTypeName == sourceMember);
    }
}