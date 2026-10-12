using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

/// <summary>
/// Data related to the result of a processed loyalty transaction.
/// In the Message Response, the result of each loyalty brand transaction.
/// </summary>
public record LoyaltyResult
{
    /// <summary>
    /// Data related to a loyalty account processed in the transaction.
    /// </summary>
    [JsonPropertyName("LoyaltyAccount")]
    public required LoyaltyAccount1 LoyaltyAccount { get; init; }

    /// <summary>
    /// Balance of an account.
    /// If known (provided by the card or an external host).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CurrentBalance")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? CurrentBalance { get; init; }

    /// <summary>
    /// Data related to the loyalty Acquirer during a loyalty transaction.
    /// If content not empty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAcquirerData")]
    public LoyaltyAcquirerData1? LoyaltyAcquirerData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
