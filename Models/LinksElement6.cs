using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Link to the resource itself.
/// </summary>
public record LinksElement6
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
