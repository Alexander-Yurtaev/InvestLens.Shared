using InvestLens.Shared.Models.Enums;

namespace InvestLens.Shared.Models.Crud.Portfolio;

public class LookupModel : Models.Crud.Portfolio.BaseModel
{
    public LookupModel(int id, string name, PortfolioType portfolioType) : base(id, name, portfolioType)
    {
    }

    public LookupModel(string name, PortfolioType portfolioType) : base(name, portfolioType)
    {
    }
}