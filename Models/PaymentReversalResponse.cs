using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentReversalResponse
{
    /// <summary>
    /// The merchant account that is used to process the payment.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference"><c>pspReference</c></see> of the payment to reverse.
    /// </summary>
    [JsonPropertyName("paymentPspReference")]
    public required string PaymentPspReference { get; init; }

    /// <summary>
    /// Adyen's 16-character reference associated with the reversal request.
    /// </summary>
    [JsonPropertyName("pspReference")]
    public required string PspReference { get; init; }

    /// <summary>
    /// Your reference for the reversal request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// The status of your request. This will always have the value <b>received</b>.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status20 Status { get; init; }
}
