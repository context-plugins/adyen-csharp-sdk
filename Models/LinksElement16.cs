using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Generate an HMAC key.
/// </summary>
public record LinksElement16
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
