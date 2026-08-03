using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PayoutScheduleExecutionDetails
{
    /// <summary>
    /// Human readable reason for why execution was not successful if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// Reason Code for why execution was not successful if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reasonCode")]
    public string? ReasonCode { get; init; }

    /// <summary>
    /// The id of the transfer from executing the payout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferId")]
    public string? TransferId { get; init; }
}
