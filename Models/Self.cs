using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Self
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
