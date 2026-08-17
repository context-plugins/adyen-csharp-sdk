using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains the minimum threshold amount that your user must repay every 30-day period.
/// </summary>
public record ThresholdRepayment21
{
    /// <summary>
    /// The minimum threshold amount that your user must repay on every 30-day period.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }
}
