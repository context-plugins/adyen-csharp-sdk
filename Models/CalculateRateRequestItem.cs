using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The request parameters required to calculate an amount in a different currency.
/// </summary>
public record CalculateRateRequestItem
{
    [JsonPropertyName("exchangeSide")]
    public required ExchangeSide2 ExchangeSide { get; init; }

    [JsonPropertyName("sourceAmount")]
    public required SourceAmount SourceAmount { get; init; }

    /// <summary>
    /// The currency to which you want to convert the source amount.
    /// </summary>
    [JsonPropertyName("targetCurrency")]
    public required string TargetCurrency { get; init; }

    [JsonPropertyName("type")]
    public required RateType2 Type { get; init; }
}
