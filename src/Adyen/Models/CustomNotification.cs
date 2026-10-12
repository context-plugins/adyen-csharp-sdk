using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CustomNotification
{
    /// <summary>
    /// The amount of the payment that the notification is about. Set the value in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount? Amount { get; init; }

    /// <summary>
    /// The event that caused the notification to be sent.Currently supported values:
    /// * <b>AUTHORISATION</b>
    /// * <b>CANCELLATION</b>
    /// * <b>REFUND</b>
    /// * <b>CAPTURE</b>
    /// * <b>REPORT_AVAILABLE</b>
    /// * <b>CHARGEBACK</b>
    /// * <b>REQUEST_FOR_INFORMATION</b>
    /// * <b>NOTIFICATION_OF_CHARGEBACK</b>
    /// * <b>NOTIFICATIONTEST</b>
    /// * <b>ORDER_OPENED</b>
    /// * <b>ORDER_CLOSED</b>
    /// * <b>CHARGEBACK_REVERSED</b>
    /// * <b>REFUNDED_REVERSED</b>
    /// * <b>REFUND_WITH_DATA</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventCode")]
    public string? EventCode { get; init; }

    /// <summary>
    /// The time of the event. Format: <see href="http://www.w3.org/TR/NOTE-datetime">ISO 8601</see>, YYYY-MM-DDThh:mm:ssTZD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventDate")]
    public DateTimeOffset? EventDate { get; init; }

    /// <summary>
    /// Your reference for the custom test notification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantReference")]
    public string? MerchantReference { get; init; }

    /// <summary>
    /// The payment method for the payment that the notification is about. Possible values:
    /// * <b>amex</b>
    /// * <b>visa</b>
    /// * <b>mc</b>
    /// * <b>maestro</b>
    /// * <b>bcmc</b>
    /// * <b>paypal</b>
    ///  * <b>sms</b>
    ///  * <b>bankTransfer_NL</b>
    /// * <b>bankTransfer_DE</b>
    /// * <b>bankTransfer_BE</b>
    /// * <b>ideal</b>
    /// * <b>elv</b>
    /// * <b>sepadirectdebit</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    public string? PaymentMethod { get; init; }

    /// <summary>
    /// A description of what caused the notification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// The outcome of the event which the notification is about. Set to either <b>true</b> or <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public bool? Success { get; init; }
}
