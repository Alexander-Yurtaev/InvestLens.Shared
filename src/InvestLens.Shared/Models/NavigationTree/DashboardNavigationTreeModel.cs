namespace InvestLens.Shared.Model.NavigationTree;

public class DashboardNavigationTreeModel : BaseNavigationTreeModel
{
    public DashboardNavigationTreeModel() : base("🏠", "Главная")
    {
        Description = "Обзор инвестиционной активности";
    }
}