using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record NotificationEventConfiguration
{
    /// <summary>
    /// The type of event.
    /// <para>
    /// Possible values: <b>ACCOUNT_CLOSED</b>, <b>ACCOUNT_CREATED</b>, <b>ACCOUNT_FUNDS_BELOW_THRESHOLD</b>, <b>ACCOUNT_HOLDER_CREATED</b>, <b>ACCOUNT_HOLDER_LIMIT_REACHED</b>, <b>ACCOUNT_HOLDER_PAYOUT</b>, <b>ACCOUNT_HOLDER_STATUS_CHANGE</b>, <b>ACCOUNT_HOLDER_STORE_STATUS_CHANGE</b>, <b>ACCOUNT_HOLDER_UPCOMING_DEADLINE</b>, <b>ACCOUNT_HOLDER_UPDATED</b>, <b>ACCOUNT_HOLDER_VERIFICATION</b>, <b>ACCOUNT_UPDATED</b>, <b>BENEFICIARY_SETUP</b>, <b>COMPENSATE_NEGATIVE_BALANCE</b>, <b>DIRECT_DEBIT_INITIATED</b>, <b>PAYMENT_FAILURE</b>, <b>REFUND_FUNDS_TRANSFER</b>, <b>REPORT_AVAILABLE</b>, <b>SCHEDULED_REFUNDS</b>, <b>TRANSFER_FUNDS</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("eventType")]
    public required EventType EventType { get; init; }

    /// <summary>
    /// Indicates whether the specified <c>eventType</c> is sent to your webhook endpoint.
    /// Possible values:
    /// * <b>INCLUDE</b>: Send the specified <c>eventType</c>.
    /// * <b>EXCLUDE</b>: Send all event types except the specified <c>eventType</c> and other event types with the <c>includeMode</c> set to <b>EXCLUDE</b>.
    /// </summary>
    [JsonPropertyName("includeMode")]
    public required IncludeMode IncludeMode { get; init; }
}
