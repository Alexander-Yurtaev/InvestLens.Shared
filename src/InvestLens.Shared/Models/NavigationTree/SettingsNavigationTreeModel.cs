namespace InvestLens.Shared.Models.NavigationTree;

public class SettingsNavigationTreeModel : BaseNavigationTreeModel
{
    public SettingsNavigationTreeModel() : base("⚙️", "Настройки")
    {
        Description = "Настройка приложения и управление плагинами";
    }
}