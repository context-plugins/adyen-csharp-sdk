using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Company4
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
