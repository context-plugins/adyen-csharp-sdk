using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record BsbAccountIdentifier
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
