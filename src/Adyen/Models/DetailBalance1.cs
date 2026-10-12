using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The total balance of the account holder.
/// </summary>
public record DetailBalance1
{
    /// <summary>
    /// The list of balances held by the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balance")]
    public IReadOnlyList<Amount>? Balance { get; init; }

    /// <summary>
    /// The list of on hold balances held by the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("onHoldBalance")]
    public IReadOnlyList<Amount>? OnHoldBalance { get; init; }

    /// <summary>
    /// The list of pending balances held by the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pendingBalance")]
    public IReadOnlyList<Amount>? PendingBalance { get; init; }
}
