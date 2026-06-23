using InvestLens.Shared.Models.Enums;

namespace InvestLens.Shared.Models.NavigationTree;

public class PortfolioNavigationTreeModel(int id, string icon, string title,  PortfolioType portfolioType) 
    : BaseNavigationTreeModel(icon, title)
{
    public int Id { get; } = id;
    public PortfolioType PortfolioType { get; set; } = portfolioType;
}