using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransactionSearchResponse
{
    /// <summary>
    /// Contains links to the next and previous page whenever applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public Links21? Links { get; init; }

    /// <summary>
    /// Contains the transactions that match the query parameters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<Transaction>? Data { get; init; }
}
