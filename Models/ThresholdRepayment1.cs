using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ThresholdRepayment1
{
    /// <summary>
    /// The minimum threshold amount that your user must repay on every 30-day period.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }
}
