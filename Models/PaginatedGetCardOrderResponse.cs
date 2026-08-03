using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaginatedGetCardOrderResponse
{
    /// <summary>
    /// Contains objects with information about card orders.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardOrders")]
    public IReadOnlyList<CardOrder>? CardOrders { get; init; }

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
