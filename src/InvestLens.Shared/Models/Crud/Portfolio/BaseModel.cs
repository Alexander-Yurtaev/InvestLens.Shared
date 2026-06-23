using InvestLens.Shared.Models.Enums;

namespace InvestLens.Shared.Models.Crud.Portfolio;

public abstract class BaseModel : Models.Crud.BaseModel
{
    protected BaseModel(int id, string name, PortfolioType portfolioType) : base(id)
    {
        Name = name;
        PortfolioType = portfolioType;
    }

    protected BaseModel(string name, PortfolioType portfolioType)
    {
        Name = name;
        PortfolioType = portfolioType;
    }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public virtual PortfolioType PortfolioType { get; set; }
    public List<int> Portfolios { get; set; } = [];
}