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

    /// <summary>
    /// The currency of the amount you converted (the source amount).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceAmount")]
    public Amount22? SourceAmount { get; init; }

    /// <summary>
    /// An object specifying the currency and value to which you want to convert the source amount (the target amount).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetAmount")]
    public Amount34? TargetAmount { get; init; }

    /// <summary>
    /// The type of transaction. Possible values:
    /// * <b>splitPayment</b>: for payments
    /// * <b>splitRefund</b>: for refunds
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
