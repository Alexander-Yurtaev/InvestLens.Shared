using InvestLens.Shared.Model.Enums;

namespace InvestLens.Shared.Model.NavigationTree;

public class DictionariesDohodBondNavigationTreeModel(string icon, string title, PeriodType periodType) 
    : BaseNavigationTreeModel(icon, title)
{
    public PeriodType PeriodType { get; } = periodType;
}