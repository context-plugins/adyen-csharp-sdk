using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Next
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
