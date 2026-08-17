using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// An object containing the details of the 30-day repayment threshold.
/// </summary>
public record ThresholdRepayment2
{
    /// <summary>
    /// The amount to be repaid on a 30-day basis.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }
}
