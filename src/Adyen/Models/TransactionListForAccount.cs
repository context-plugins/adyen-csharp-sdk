using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransactionListForAccount
{
    /// <summary>
    /// The account for which to retrieve the transactions.
    /// </summary>
    [JsonPropertyName("accountCode")]
    public required string AccountCode { get; init; }

    /// <summary>
    /// The page of transactions to retrieve.
    /// Each page lists fifty (50) transactions.  The most recent transactions are included on page 1.
    /// </summary>
    [JsonPropertyName("page")]
    public required int Page { get; init; }
}
