using InvestLens.Shared.Models.Enums;

namespace InvestLens.Shared.Models.NavigationTree;

public class DictionariesDohodBondNavigationTreeModel(string icon, string title, PeriodType periodType) 
    : BaseNavigationTreeModel(icon, title)
{
    public PeriodType PeriodType { get; } = periodType;
}