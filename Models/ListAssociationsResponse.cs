using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ListAssociationsResponse
{
    [JsonPropertyName("_links")]
    public required Link Links { get; init; }

    /// <summary>
    /// Contains a list of associations and their corresponding details.
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<AssociationListing> Data { get; init; }

    /// <summary>
    /// The total number of items available.
    /// </summary>
    [JsonPropertyName("itemsTotal")]
    public required int ItemsTotal { get; init; }

    /// <summary>
    /// The total number of pages available.
    /// </summary>
    [JsonPropertyName("pagesTotal")]
    public required int PagesTotal { get; init; }
}
