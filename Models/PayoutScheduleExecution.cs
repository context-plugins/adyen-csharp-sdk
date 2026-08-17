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

    /// <summary>
    /// The status of the payout execution.
    /// <para>
    /// Possible values:
    /// - <b>succeeded</b>: The payout was sent successfully.
    /// - <b>failed</b>: The payout could not be sent because an error occurred.
    /// - <b>skipped</b>: The payout was not triggered as expected.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public ExecutionResult1? Result { get; init; }

    /// <summary>
    /// Contains information about the result of the payout execution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultDetails")]
    public PayoutScheduleExecutionDetails2? ResultDetails { get; init; }

    /// <summary>
    /// The date and time when the payout execution was initiated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("triggeredAt")]
    public DateTimeOffset? TriggeredAt { get; init; }
}
