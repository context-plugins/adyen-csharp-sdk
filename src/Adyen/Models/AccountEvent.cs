using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AccountEvent
{
    /// <summary>
    /// The event.
    /// &gt;Permitted values: <c>InactivateAccount</c>, <c>RefundNotPaidOutTransfers</c>.
    /// For more information, refer to <see href="https://docs.adyen.com/classic-platforms/verification-process">Verification checks</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event")]
    public Event? Event { get; init; }

    /// <summary>
    /// The date on which the event will take place.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("executionDate")]
    public DateTimeOffset? ExecutionDate { get; init; }

    /// <summary>
    /// The reason why this event has been created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }
}
