using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The link to the list page you are currently viewing.
/// </summary>
public record Href51
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
