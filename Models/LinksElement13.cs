using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The current page.
/// </summary>
public record LinksElement13
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
