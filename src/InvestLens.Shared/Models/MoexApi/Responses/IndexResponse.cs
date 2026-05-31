using InvestLens.Shared.Model.Entities.Settings;
using InvestLens.Shared.Model.Enums;
using InvestLens.Shared.Model.MoexApi.Responses.ResponseItems;
using System.Text.Json.Serialization;

namespace InvestLens.Shared.Model.MoexApi.Responses;

public class IndexResponse
{
    [JsonPropertyName("engines")]
    public Engines? Engines { get; set; }

    [JsonPropertyName("markets")]
    public Markets? Markets { get; set; }

    [JsonPropertyName("boards")]
    public Boards? Boards { get; set; }

    [JsonPropertyName("boardgroups")]
    public BoardGroups? BoardGroups { get; set; }

    [JsonPropertyName("durations")]
    public Durations? Durations { get; set; }

    [JsonPropertyName("securitytypes")]
    public SecurityTypes? SecurityTypes { get; set; }

    [JsonPropertyName("securitygroups")]
    public SecurityGroups? SecurityGroups { get; set; }

    [JsonPropertyName("securitycollections")]
    public SecurityCollections? SecurityCollections { get; set; }
}