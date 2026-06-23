namespace InvestLens.Shared.Models.NavigationTree;

public class PortfoliosNavigationTreeModel : BaseNavigationTreeModel
{
    public PortfoliosNavigationTreeModel() : base("📁", "Портфели")
    {
        Description = "Управление инвестиционными портфелями";
    }
}