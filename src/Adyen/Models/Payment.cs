using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Payment
{
    /// <summary>
    /// Authorised amount in the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount26? Amount { get; init; }

    /// <summary>
    /// Only returned for <c>resultCode</c>: <b>Authorised</b>.
    /// Details about the payment method used in the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    public PaymentResponse3? PaymentMethod { get; init; }

    /// <summary>
    /// Adyen's 16-character reference associated with the transaction/request. This value is globally unique. Use this reference when you communicate with us about this request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    /// <summary>
    /// The result of the payment. For more information, see <see href="https://docs.adyen.com/online-payments/payment-result-codes">Result codes</see>.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>Authorised</b> – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state.</description></item>
    ///   <item><description><b>Received</b> – Indicates the payment request was successfully received by Adyen, and will be processed. This is the initial state for all payments.</description></item>
    ///   <item><description><b>Pending</b> – The payment order was successfully received but the final status of the payment is not available yet. This is common for payment methods with an asynchronous flow.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public ResultCode2? ResultCode { get; init; }
}
