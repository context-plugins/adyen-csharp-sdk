using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Identifiers relevant for the Rix (Russian Interbank eXchange) system, used for interbank payments within Russia.
/// </summary>
public record RixAccountIdentifier2
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
