using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Generates a new client key, used to authenticate client-side requests. When you generate a new one, the existing key remains valid for 24 hours.
/// </summary>
public record LinksElement4
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
