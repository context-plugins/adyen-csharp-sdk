using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CloseStoresRequest
{
    /// <summary>
    /// The code of the account holder.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// List of stores to be closed.
    /// </summary>
    [JsonPropertyName("stores")]
    public required IReadOnlyList<string> Stores { get; init; }
}
