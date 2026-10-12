using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SessionResultResponse
{
    /// <summary>
    /// Contains additional information about the payment. Some fields are included only if you enable them. To enable these fields in your Customer Area, go to <b>Developers</b> &gt; <b>Additional data</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// A unique identifier of the session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// A list of all authorised payments done for this session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payments")]
    public IReadOnlyList<Payment>? Payments { get; init; }

    /// <summary>
    /// The unique reference that you provided in the original <c>/sessions</c> request. This identifies the payment and is used in all communication with you about the payment status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// The status of the session. The status included in the response doesn't get updated. Don't make the request again to check for payment status updates.
    /// <para>
    /// Possible values:
    /// * <b>completed</b>: the shopper completed the payment, and the payment was authorized.
    /// * <b>paymentPending</b>: the shopper is in the process of making the payment. This applies to payment methods with an asynchronous flow, like voucher payments where the shopper completes the payment in a physical shop.
    /// * <b>refused</b>: the session has been refused, because of too many refused payment attempts. The shopper can no longer complete the payment with this session.
    /// * <b>canceled</b>: the shopper canceled the payment.
    /// * <b>expired</b>: the session expired. The shopper can no longer complete the payment with this session. By default, the session expires one hour after it is created.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status5? Status { get; init; }
}
