using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ListDonationCampaignsResponse
{
    /// <summary>
    /// Pagination references.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public PaginationLinks1? Links { get; init; }

    /// <summary>
    /// The list of donation campaigns.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("campaigns")]
    public IReadOnlyList<DonationCampaign1>? Campaigns { get; init; }

    /// <summary>
    /// Total number of items.
    /// </summary>
    [JsonPropertyName("itemsTotal")]
    public required int ItemsTotal { get; init; }

    /// <summary>
    /// Total number of pages.
    /// </summary>
    [JsonPropertyName("pagesTotal")]
    public required int PagesTotal { get; init; }
}
