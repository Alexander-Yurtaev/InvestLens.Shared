using InvestLens.Shared.Models.Entities.Settings;

namespace InvestLens.Shared.Models.MoexApi.Settings;

public class SecurityCollectionModel : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int SecurityGroupId { get; set; }
    public virtual SecurityGroup? SecurityGroup { get; set; }
}