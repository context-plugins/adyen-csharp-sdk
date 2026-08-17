using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The previous page. Only present if there is a previous page.
/// </summary>
public record LinksElement12
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
