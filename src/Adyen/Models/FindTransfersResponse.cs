using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record FindTransfersResponse
{
    /// <summary>
    /// Contains links to the next and previous page whenever applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public Links21? Links { get; init; }

    /// <summary>
    /// Contains the transfers that match the query parameters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<TransferData>? Data { get; init; }
}
