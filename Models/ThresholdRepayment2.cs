using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// An object containing the details of the 30-day repayment threshold.
/// </summary>
public record ThresholdRepayment2
{
    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }
}
