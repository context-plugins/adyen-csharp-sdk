using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Transaction outcomes that you want the terminal to print a merchant receipt or a shopper receipt for.
/// </summary>
public record ReceiptPrinting1
{
    /// <summary>
    /// Print a merchant receipt when the payment is approved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantApproved")]
    public bool? MerchantApproved { get; init; }

    /// <summary>
    /// Print a merchant receipt when the transaction is cancelled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantCancelled")]
    public bool? MerchantCancelled { get; init; }

    /// <summary>
    /// Print a merchant receipt when capturing the payment is approved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantCaptureApproved")]
    public bool? MerchantCaptureApproved { get; init; }

    /// <summary>
    /// Print a merchant receipt when capturing the payment is refused.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantCaptureRefused")]
    public bool? MerchantCaptureRefused { get; init; }

    /// <summary>
    /// Print a merchant receipt when the refund is approved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantRefundApproved")]
    public bool? MerchantRefundApproved { get; init; }

    /// <summary>
    /// Print a merchant receipt when the refund is refused.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantRefundRefused")]
    public bool? MerchantRefundRefused { get; init; }

    /// <summary>
    /// Print a merchant receipt when the payment is refused.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantRefused")]
    public bool? MerchantRefused { get; init; }

    /// <summary>
    /// Print a merchant receipt when a previous transaction is voided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantVoid")]
    public bool? MerchantVoid { get; init; }

    /// <summary>
    /// Print a shopper receipt when the payment is approved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperApproved")]
    public bool? ShopperApproved { get; init; }

    /// <summary>
    /// Print a shopper receipt when the transaction is cancelled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperCancelled")]
    public bool? ShopperCancelled { get; init; }

    /// <summary>
    /// Print a shopper receipt when capturing the payment is approved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperCaptureApproved")]
    public bool? ShopperCaptureApproved { get; init; }

    /// <summary>
    /// Print a shopper receipt when capturing the payment is refused.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperCaptureRefused")]
    public bool? ShopperCaptureRefused { get; init; }

    /// <summary>
    /// Print a shopper receipt when the refund is approved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperRefundApproved")]
    public bool? ShopperRefundApproved { get; init; }

    /// <summary>
    /// Print a shopper receipt when the refund is refused.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperRefundRefused")]
    public bool? ShopperRefundRefused { get; init; }

    /// <summary>
    /// Print a shopper receipt when the payment is refused.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperRefused")]
    public bool? ShopperRefused { get; init; }

    /// <summary>
    /// Print a shopper receipt when a previous transaction is voided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperVoid")]
    public bool? ShopperVoid { get; init; }
}
