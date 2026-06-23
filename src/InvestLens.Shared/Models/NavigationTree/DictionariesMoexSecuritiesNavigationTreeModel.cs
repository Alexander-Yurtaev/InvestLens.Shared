namespace InvestLens.Shared.Models.NavigationTree;

public class DictionariesMoexSecuritiesNavigationTreeModel : BaseNavigationTreeModel
{
    public DictionariesMoexSecuritiesNavigationTreeModel() : base("📈", "Ценные бумаги")
    {
        Description = "Акции, ETF и другие инструменты";
    }
}