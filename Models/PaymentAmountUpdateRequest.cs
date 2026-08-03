using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentAmountUpdateRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustAuthType")]
    public AdjustAuthType? AdjustAuthType { get; init; }

    /// <summary>
    /// The required data to make a <see href="https://docs.adyen.com/online-payments/adjust-authorisation">synchronous authorization adjustment</see>. Pass the corresponding value from the <c>/payments</c> response or webhook message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustAuthorisationData")]
    public string? AdjustAuthorisationData { get; init; }

    [JsonPropertyName("amount")]
    public required Amount16 Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationInfo")]
    public ApplicationInfo1? ApplicationInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("industryUsage")]
    public IndustryUsage1? IndustryUsage { get; init; }

    /// <summary>
    /// Price and product information of the refunded items, required for <see href="https://docs.adyen.com/online-payments/refund#refund-a-payment">partial refunds</see>.
    /// &gt; This field is required for partial refunds with 3x 4x Oney, Affirm, Afterpay, Atome, Clearpay, Klarna, Ratepay, Walley, and Zip.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lineItems")]
    public IReadOnlyList<LineItem>? LineItems { get; init; }

    /// <summary>
    /// The merchant account that is used to process the payment.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mpiData")]
    public MpiData? MpiData { get; init; }

    /// <summary>
    /// Your reference for the amount update request. Maximum length: 80 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For more information, see how to process payments for <see href="https://docs.adyen.com/marketplaces/process-payments">marketplaces</see> or <see href="https://docs.adyen.com/platforms/process-payments">platforms</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splits")]
    public IReadOnlyList<Split>? Splits { get; init; }
}
