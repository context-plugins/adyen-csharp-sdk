using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ThresholdRepayment
{
    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }
}
