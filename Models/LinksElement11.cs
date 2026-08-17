using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The next page. Only present if there is a next page.
/// </summary>
public record LinksElement11
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
