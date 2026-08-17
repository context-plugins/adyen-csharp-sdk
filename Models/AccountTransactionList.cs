using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AccountTransactionList
{
    /// <summary>
    /// The code of the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountCode")]
    public string? AccountCode { get; init; }

    /// <summary>
    /// Indicates whether there is a next page of transactions available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hasNextPage")]
    public bool? HasNextPage { get; init; }

    /// <summary>
    /// The list of transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions")]
    public IReadOnlyList<Transaction1>? Transactions { get; init; }
}
