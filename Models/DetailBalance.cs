using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DetailBalance
{
    /// <summary>
    /// The list of balances held by the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balance")]
    public IReadOnlyList<Amount2>? Balance { get; init; }

    /// <summary>
    /// The list of on hold balances held by the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("onHoldBalance")]
    public IReadOnlyList<Amount2>? OnHoldBalance { get; init; }

    /// <summary>
    /// The list of pending balances held by the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pendingBalance")]
    public IReadOnlyList<Amount2>? PendingBalance { get; init; }
}
