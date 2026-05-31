using InvestLens.Shared.Model.Enums;

namespace InvestLens.Shared.Model.Crud.Portfolio;

public class UpdateModel : InvestLens.Shared.Model.Crud.Portfolio.BaseModel
{
    public UpdateModel() : base("", PortfolioType.Invest)
    {
        
    }

    public UpdateModel(int id, string name, PortfolioType portfolioType) : base(id, name, portfolioType)
    {
    }
}