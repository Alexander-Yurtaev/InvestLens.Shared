namespace InvestLens.Shared.Models.NavigationTree;

public class DownloaderNavigationTreeModel : BaseNavigationTreeModel
{
    public DownloaderNavigationTreeModel() : base("⬇️", "Менеджер закачек")
    {
        Description = "Управление загрузкой данных";
    }
}