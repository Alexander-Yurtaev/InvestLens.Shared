namespace InvestLens.Shared.Models.NavigationTree;

public class SchedulerNavigationTreeModel : BaseNavigationTreeModel
{
    public SchedulerNavigationTreeModel() : base("📅", "Планировщик")
    {
        Description = "Управление задачами и напоминаниями";
    }
}