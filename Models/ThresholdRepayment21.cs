using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains the minimum threshold amount that your user must repay every 30-day period.
/// </summary>
public record ThresholdRepayment21
{
    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }
}
