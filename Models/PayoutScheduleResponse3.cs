using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The details of the payout schedule to which the account is updated.
/// </summary>
public record PayoutScheduleResponse3
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
