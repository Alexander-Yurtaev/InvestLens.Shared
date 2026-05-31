using AutoMapper;
using InvestLens.Shared.DataAccess.Services;
using InvestLens.Shared.Model;
using InvestLens.Shared.Model.MoexApi.Settings;

namespace InvestLens.Shared.DataAccess.Resolvers;

public class SecurityTypeResolver : IMemberValueResolver<Model.MoexApi.Responses.Security, SecurityModel, string, SecurityTypeModel?>
{
    private readonly IMoexService _moexService;

    public SecurityTypeResolver(IMoexService moexService)
    {
        _moexService = moexService;
    }

    public SecurityTypeModel? Resolve(Model.MoexApi.Responses.Security source, SecurityModel destination, string sourceMember, SecurityTypeModel? destMember, ResolutionContext context)
    {
        return _moexService.MoexDictionaries.SecurityTypes
            .FirstOrDefault(s => s.SecurityTypeName == sourceMember);
    }
}