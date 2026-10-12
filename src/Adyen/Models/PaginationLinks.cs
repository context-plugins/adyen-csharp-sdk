using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record PaginationLinks
{
    /// <summary>
    /// The first page.
    /// </summary>
    [JsonPropertyName("first")]
    public required LinksElement9 First { get; init; }

    /// <summary>
    /// The last page.
    /// </summary>
    [JsonPropertyName("last")]
    public required LinksElement10 Last { get; init; }

    /// <summary>
    /// The next page. Only present if there is a next page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next")]
    public LinksElement11? Next { get; init; }

    /// <summary>
    /// The previous page. Only present if there is a previous page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prev")]
    public LinksElement12? Prev { get; init; }

    /// <summary>
    /// The current page.
    /// </summary>
    [JsonPropertyName("self")]
    public required LinksElement13 Self { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
