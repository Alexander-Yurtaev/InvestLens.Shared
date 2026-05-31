using InvestLens.Shared.Model.Enums;

namespace InvestLens.Shared.Model.NavigationTree;

public class PortfolioNavigationTreeModel(int id, string icon, string title,  PortfolioType portfolioType) 
    : BaseNavigationTreeModel(icon, title)
{
    public int Id { get; } = id;
    public PortfolioType PortfolioType { get; set; } = portfolioType;
}