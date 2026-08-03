using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The response parameters returned when you calculate an amount in a different currency.
/// </summary>
public record CalculateRateResponseItem
{
    /// <summary>
    /// The exchange rate to convert the source currency to the target currency. This includes Adyen's markup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appliedExchangeRate")]
    public double? AppliedExchangeRate { get; init; }

    /// <summary>
    /// The operation performed on the source amount. Possible values:
    /// * <b>buy</b>
    /// * <b>sell</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exchangeSide")]
    public string? ExchangeSide { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceAmount")]
    public SourceAmount? SourceAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetAmount")]
    public TargetAmount? TargetAmount { get; init; }

    /// <summary>
    /// The type of transaction. Possible values:
    /// * <b>splitPayment</b>: for payments
    /// * <b>splitRefund</b>: for refunds
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
