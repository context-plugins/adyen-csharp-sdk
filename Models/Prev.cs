using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Prev
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
