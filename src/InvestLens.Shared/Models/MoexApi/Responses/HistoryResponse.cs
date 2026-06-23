using System.Text.Json.Serialization;

namespace InvestLens.Shared.Models.MoexApi.Responses
{
    public class HistoryResponse
    {
        [JsonPropertyName("history")]
        public ResponseItems.History? History { get; set; }

        [JsonPropertyName("history.cursor")]
        public ResponseItems.HistoryCursor? HistoryCursor { get; set; }
    }
}
