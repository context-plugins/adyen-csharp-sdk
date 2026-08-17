using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Test the webhook setup.
/// </summary>
public record LinksElement19
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
