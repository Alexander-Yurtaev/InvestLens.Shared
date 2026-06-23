using InvestLens.Shared.Models.Enums;

namespace InvestLens.Shared.Models.Crud.Portfolio;

public class UpdateModel : Models.Crud.Portfolio.BaseModel
{
    public UpdateModel() : base("", PortfolioType.Invest)
    {
        
    }

    public UpdateModel(int id, string name, PortfolioType portfolioType) : base(id, name, portfolioType)
    {
    }
}