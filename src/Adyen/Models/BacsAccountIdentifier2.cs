using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Identifiers relevant for Bankers' Automated Clearing Services (BACS) payments, primarily used in the United Kingdom.
/// </summary>
public record BacsAccountIdentifier2
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
