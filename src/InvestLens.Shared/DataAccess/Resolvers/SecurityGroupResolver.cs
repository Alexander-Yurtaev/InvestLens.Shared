using AutoMapper;
using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Model;
using InvestLens.Shared.Model.MoexApi.Settings;

namespace InvestLens.Shared.DataAccess.Resolvers;

public class SecurityGroupResolver : IMemberValueResolver<Model.MoexApi.Responses.Security, SecurityModel, string, SecurityGroupModel?>
{
    private readonly IMoexService _moexService;

    public SecurityGroupResolver(IMoexService moexService)
    {
        _moexService = moexService;
    }

    public SecurityGroupModel? Resolve(Model.MoexApi.Responses.Security source, SecurityModel destination, string sourceMember, SecurityGroupModel? destMember, ResolutionContext context)
    {
        return _moexService.MoexDictionaries.SecurityGroups
            .FirstOrDefault(s => s.Name == sourceMember);
    }
}