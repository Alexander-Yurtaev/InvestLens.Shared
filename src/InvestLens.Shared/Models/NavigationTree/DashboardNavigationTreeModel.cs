namespace InvestLens.Shared.Models.NavigationTree;

public class DashboardNavigationTreeModel : BaseNavigationTreeModel
{
    public DashboardNavigationTreeModel() : base("🏠", "Главная")
    {
        Description = "Обзор инвестиционной активности";
    }
}