using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

/// <summary>
/// Data related to the result of a processed loyalty transaction.
/// In the Message Response, the result of each loyalty brand transaction.
/// </summary>
public record LoyaltyResult
{
    [JsonPropertyName("LoyaltyAccount")]
    public required LoyaltyAccount12 LoyaltyAccount { get; init; }

    /// <summary>
    /// Balance of an account.
    /// If known (provided by the card or an external host).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CurrentBalance")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? CurrentBalance { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyAcquirerData")]
    public LoyaltyAcquirerData? LoyaltyAcquirerData { get; init; }
}
