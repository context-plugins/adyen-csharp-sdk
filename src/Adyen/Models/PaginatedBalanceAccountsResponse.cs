using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaginatedBalanceAccountsResponse
{
    /// <summary>
    /// List of balance accounts.
    /// </summary>
    [JsonPropertyName("balanceAccounts")]
    public required IReadOnlyList<BalanceAccountBase> BalanceAccounts { get; init; }

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
