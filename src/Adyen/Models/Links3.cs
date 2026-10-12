using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Links3
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
