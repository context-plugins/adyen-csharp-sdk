using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains links to the next and previous page whenever applicable.
/// </summary>
public record Link2
{
    /// <summary>
    /// The link to the first page of the list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("first")]
    public LinksElement? First { get; init; }

    /// <summary>
    /// The link to the last page of the list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last")]
    public LinksElement? Last { get; init; }

    /// <summary>
    /// The link to the next page of the list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next")]
    public LinksElement? Next { get; init; }

    /// <summary>
    /// The link to the previous page of the list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("previous")]
    public LinksElement? Previous { get; init; }

    /// <summary>
    /// The link to the list page you are currently viewing.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("self")]
    public LinksElement? Self { get; init; }
}
