using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BacsaccountIdentifier
{
    /// <summary>
    /// The account number of the bank account.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// A number that identifies the specific bank and branch where a UK bank account is held.
    /// </summary>
    [JsonPropertyName("sortCode")]
    public required string SortCode { get; init; }
}
