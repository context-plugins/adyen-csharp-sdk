using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Identifiers relevant for Electronic Funds Transfer (EFT) payments, commonly used in Canada.
/// </summary>
public record EftAccountIdentifier2
{
    /// <summary>
    /// The account number of the bank account.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// Identifies the specific branch where the account is held within the Canadian banking system.
    /// </summary>
    [JsonPropertyName("branch")]
    public required string Branch { get; init; }

    /// <summary>
    /// The financial institution that identifies the bank in Canada.
    /// </summary>
    [JsonPropertyName("institution")]
    public required string Institution { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
