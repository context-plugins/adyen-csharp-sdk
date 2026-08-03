using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// List of allowed origins.
/// </summary>
public record Href2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
