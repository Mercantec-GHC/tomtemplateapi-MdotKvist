using System.Text.Json.Serialization;

namespace BlazorApp
{
    public class Data
    {
        [JsonPropertyName("Date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("Price")]
        public string Price { get; set; } = string.Empty;

        // Property used for charting
        [JsonIgnore]
        public decimal PriceDecimal { get; set; }
    }
}
