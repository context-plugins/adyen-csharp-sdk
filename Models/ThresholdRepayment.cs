using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ThresholdRepayment
{
    /// <summary>
    /// The amount to be repaid on a 30-day basis.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }
}
