using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransactionSearchResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public Links3? Links { get; init; }

    /// <summary>
    /// Contains the transactions that match the query parameters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<Transaction1>? Data { get; init; }
}
