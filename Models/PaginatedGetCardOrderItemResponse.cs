using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaginatedGetCardOrderItemResponse
{
    /// <summary>
    /// List of card order items in the card order batch.
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<CardOrderItem> Data { get; init; }

    /// <summary>
    /// Indicates whether there are more items on the next page.
    /// </summary>
    [JsonPropertyName("hasNext")]
    public required bool HasNext { get; init; }

    /// <summary>
    /// Indicates whether there are more items on the previous page.
    /// </summary>
    [JsonPropertyName("hasPrevious")]
    public required bool HasPrevious { get; init; }
}
