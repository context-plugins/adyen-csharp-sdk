using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The first page.
/// </summary>
public record LinksElement9
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
