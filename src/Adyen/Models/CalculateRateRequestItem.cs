using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The request parameters required to calculate an amount in a different currency.
/// </summary>
public record CalculateRateRequestItem
{
    /// <summary>
    /// The operation performed on the source amount. Possible values:
    /// * <b>buy</b>
    /// * <b>sell</b>
    /// </summary>
    [JsonPropertyName("exchangeSide")]
    public required ExchangeSide2 ExchangeSide { get; init; }

    /// <summary>
    /// An object specifying the currency and value for which you want to perform an exchange calculation.
    /// </summary>
    [JsonPropertyName("sourceAmount")]
    public required Amount19 SourceAmount { get; init; }

    /// <summary>
    /// The currency to which you want to convert the source amount.
    /// </summary>
    [JsonPropertyName("targetCurrency")]
    public required string TargetCurrency { get; init; }

    /// <summary>
    /// The type of transaction. Possible values:
    /// * <b>splitPayment</b>: for payments
    /// * <b>splitRefund</b>: for refunds
    /// </summary>
    [JsonPropertyName("type")]
    public required RateType2 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
