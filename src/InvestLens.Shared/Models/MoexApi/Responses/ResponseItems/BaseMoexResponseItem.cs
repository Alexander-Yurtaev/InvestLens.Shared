using System.Text.Json.Serialization;

namespace InvestLens.Shared.Model.MoexApi.Responses.ResponseItems
{
    public abstract class BaseMoexResponseItem
    {
        [JsonPropertyName("Columns")]
        public string[] Columns { get; set; } = [];

        [JsonPropertyName("data")]
        public object[][] Data { get; set; } = [];
    }
}