using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains links to the next and previous page whenever applicable.
/// </summary>
public record Links21
{
    /// <summary>
    /// Contains a link to the next page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next")]
    public LinksElement? Next { get; init; }

    /// <summary>
    /// Contains a link to the previous page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prev")]
    public LinksElement? Prev { get; init; }
}
