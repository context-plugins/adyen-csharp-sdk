using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record BacsAccountIdentifier
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
