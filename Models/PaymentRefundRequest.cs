using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentRefundRequest
{
    [JsonPropertyName("amount")]
    public required Amount16 Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationInfo")]
    public ApplicationInfo1? ApplicationInfo { get; init; }

    /// <summary>
    /// This is only available for PayPal refunds. The <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference"><c>pspReference</c></see> of the specific capture to refund.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capturePspReference")]
    public string? CapturePspReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData")]
    public EnhancedSchemeData? EnhancedSchemeData { get; init; }

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
    [JsonPropertyName("merchantRefundReason")]
    public object? MerchantRefundReason { get; init; }

    /// <summary>
    /// Your reference for the refund request. Maximum length: 80 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For more information, see how to process payments for <see href="https://docs.adyen.com/marketplaces/split-payments">marketplaces</see> or <see href="https://docs.adyen.com/platforms/online-payments/split-payments/">platforms</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splits")]
    public IReadOnlyList<Split>? Splits { get; init; }

    /// <summary>
    /// The online store or <see href="https://docs.adyen.com/point-of-sale/design-your-integration/determine-account-structure/#create-stores">physical store</see> that is processing the refund. This must be the same as the store name configured in your Customer Area.  Otherwise, you get an error and the refund fails.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    public string? Store { get; init; }
}
