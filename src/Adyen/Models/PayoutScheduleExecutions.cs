using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record PayoutScheduleExecutions
{
    /// <summary>
    /// Contains a list of executions of the payout schedule.
    /// </summary>
    [JsonPropertyName("payoutScheduleExecutions")]
    public required IReadOnlyList<PayoutScheduleExecution> PayoutScheduleExecutionsValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
