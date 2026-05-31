using InvestLens.Shared.Model.Enums;

namespace InvestLens.Shared.Model.Crud.Portfolio;

public class LookupModel : BaseModel
{
    public LookupModel(int id, string name, PortfolioType portfolioType) : base(id, name, portfolioType)
    {
    }

    public LookupModel(string name, PortfolioType portfolioType) : base(name, portfolioType)
    {
    }
}