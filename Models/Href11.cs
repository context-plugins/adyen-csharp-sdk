using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The link to the first page of the list.
/// </summary>
public record Href11
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
