using System.Text.Json.Serialization;

namespace InvestLens.Shared.Models.Entities;

public abstract class BaseEntity
{
    protected BaseEntity()
    {
        
    }

    protected BaseEntity(int id)
    {
        Id = id;
    }

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
