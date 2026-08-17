using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RixAccountIdentifier
{
    /// <summary>
    /// The account number of the bank account.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The 4- to 5-digit clearing number, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("clearingNumber")]
    public required string ClearingNumber { get; init; }
}
