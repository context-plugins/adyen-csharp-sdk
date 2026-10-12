using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TestNotificationConfigurationResponse
{
    /// <summary>
    /// Any error messages encountered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorMessages")]
    public IReadOnlyList<string>? ErrorMessages { get; init; }

    /// <summary>
    /// The event types that were tested.
    /// &gt;Permitted values: <c>ACCOUNT_HOLDER_CREATED</c>, <c>ACCOUNT_CREATED</c>, <c>ACCOUNT_UPDATED</c>, <c>ACCOUNT_HOLDER_UPDATED</c>, <c>ACCOUNT_HOLDER_STATUS_CHANGE</c>, <c>ACCOUNT_HOLDER_STORE_STATUS_CHANGE</c> <c>ACCOUNT_HOLDER_VERIFICATION</c>, <c>ACCOUNT_HOLDER_LIMIT_REACHED</c>, <c>ACCOUNT_HOLDER_PAYOUT</c>, <c>PAYMENT_FAILURE</c>, <c>SCHEDULED_REFUNDS</c>, <c>REPORT_AVAILABLE</c>, <c>TRANSFER_FUNDS</c>, <c>BENEFICIARY_SETUP</c>, <c>COMPENSATE_NEGATIVE_BALANCE</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventTypes")]
    public IReadOnlyList<EventType1>? EventTypes { get; init; }

    /// <summary>
    /// The notification message and related response messages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exchangeMessages")]
    public IReadOnlyList<ExchangeMessage>? ExchangeMessages { get; init; }

    /// <summary>
    /// Contains field validation errors that would prevent requests from being processed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invalidFields")]
    public IReadOnlyList<ErrorFieldType>? InvalidFields { get; init; }

    /// <summary>
    /// The ID of the notification subscription configuration.
    /// </summary>
    [JsonPropertyName("notificationId")]
    public required long NotificationId { get; init; }

    /// <summary>
    /// A list of messages describing the testing steps.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("okMessages")]
    public IReadOnlyList<string>? OkMessages { get; init; }

    /// <summary>
    /// The reference of a request. Can be used to uniquely identify the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    /// <summary>
    /// The result code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public string? ResultCode { get; init; }
}
