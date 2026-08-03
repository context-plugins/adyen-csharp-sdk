using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PayoutScheduleExecution
{
    /// <summary>
    /// The unique identifier of the payout execution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public ExecutionResult1? Result { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultDetails")]
    public PayoutScheduleExecutionDetails? ResultDetails { get; init; }

    /// <summary>
    /// The date and time when the payout execution was initiated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggeredAt")]
    public DateTimeOffset? TriggeredAt { get; init; }
}
