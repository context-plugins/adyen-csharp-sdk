using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// List of allowed origins.
/// </summary>
public record LinksElement1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
