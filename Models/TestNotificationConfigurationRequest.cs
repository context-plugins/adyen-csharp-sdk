using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TestNotificationConfigurationRequest
{
    /// <summary>
    /// The event types to test.  If left blank, then all of the configured event types will be tested.
    /// &gt;Permitted values: <c>ACCOUNT_HOLDER_CREATED</c>, <c>ACCOUNT_CREATED</c>, <c>ACCOUNT_UPDATED</c>, <c>ACCOUNT_HOLDER_UPDATED</c>, <c>ACCOUNT_HOLDER_STATUS_CHANGE</c>, <c>ACCOUNT_HOLDER_STORE_STATUS_CHANGE</c> <c>ACCOUNT_HOLDER_VERIFICATION</c>, <c>ACCOUNT_HOLDER_LIMIT_REACHED</c>, <c>ACCOUNT_HOLDER_PAYOUT</c>, <c>PAYMENT_FAILURE</c>, <c>SCHEDULED_REFUNDS</c>, <c>REPORT_AVAILABLE</c>, <c>TRANSFER_FUNDS</c>, <c>BENEFICIARY_SETUP</c>, <c>COMPENSATE_NEGATIVE_BALANCE</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventTypes")]
    public IReadOnlyList<EventType1>? EventTypes { get; init; }

    /// <summary>
    /// The ID of the notification subscription configuration to be tested.
    /// </summary>
    [JsonPropertyName("notificationId")]
    public required long NotificationId { get; init; }
}
