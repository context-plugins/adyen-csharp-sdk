using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PayoutScheduleResponse
{
    /// <summary>
    /// The date of the next scheduled payout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nextScheduledPayout")]
    public DateTimeOffset? NextScheduledPayout { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public PayoutSchedule? Schedule { get; init; }
}
