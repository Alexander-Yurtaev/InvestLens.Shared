using AutoMapper;
using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Models;

namespace InvestLens.Shared.DataAccess.Resolvers;

public class SecurityGroupIdResolver : IMemberValueResolver<Models.MoexApi.Responses.Security, SecurityModel, string, int?>
{
    private readonly IMoexService _moexService;

    public SecurityGroupIdResolver(IMoexService moexService)
    {
        _moexService = moexService;
    }

    public int? Resolve(Models.MoexApi.Responses.Security source, SecurityModel destination, string sourceMember, int? destMember, ResolutionContext context)
    {
        var group = _moexService.MoexDictionaries.SecurityGroups
            .FirstOrDefault(s => s.Name == sourceMember);
        return group?.Id;
    }
}