using System.Text.Json.Serialization;

namespace Adyen.Models;

public record StandalonePaymentCancelResponse
{
    /// <summary>
    /// The merchant account that is used to process the payment.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_reference"><c>reference</c></see> of the payment to cancel.
    /// </summary>
    [JsonPropertyName("paymentReference")]
    public required string PaymentReference { get; init; }

    /// <summary>
    /// Adyen's 16-character reference associated with the cancel request.
    /// </summary>
    [JsonPropertyName("pspReference")]
    public required string PspReference { get; init; }

    /// <summary>
    /// Your reference for the cancel request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// The status of your request. This will always have the value <b>received</b>.
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; } = "received";
}
