using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PayoutScheduleExecutions
{
    /// <summary>
    /// Contains a list of executions of the payout schedule.
    /// </summary>
    [JsonPropertyName("payoutScheduleExecutions")]
    public required IReadOnlyList<PayoutScheduleExecution> PayoutScheduleExecutionsValue { get; init; }
}
