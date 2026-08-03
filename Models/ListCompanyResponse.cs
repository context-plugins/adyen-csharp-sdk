using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ListCompanyResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public PaginationLinks? Links { get; init; }

    /// <summary>
    /// The list of companies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<Company2>? Data { get; init; }

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
