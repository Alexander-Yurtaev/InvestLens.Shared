using InvestLens.Shared.Models.Enums;

namespace InvestLens.Shared.Models.Crud.Portfolio;

public class CreateModel : BaseModel
{
    public CreateModel(int ownerId) : base("Новый портфель", PortfolioType.Invest)
    {
        OwnerId = ownerId;
    }

    public int OwnerId { get; }
}