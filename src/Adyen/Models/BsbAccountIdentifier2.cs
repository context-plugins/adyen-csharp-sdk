using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Identifiers relevant for Australian banking, specifically for BSB (Bank-State-Branch) numbers.
/// </summary>
public record BsbAccountIdentifier2
{
    /// <summary>
    /// The account number of the bank account.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The BSB (Bank-State-Branch) code.
    /// </summary>
    [JsonPropertyName("bsbCode")]
    public required string BsbCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
