using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The condition that triggers the top-up. This can be a recurring schedule or a minimum balance threshold.
/// </summary>
public record Trigger1
{
    /// <summary>
    /// Contains the details about the schedule that determines when the top up is executed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public Schedule21? Schedule { get; init; }

    /// <summary>
    /// The balance threshold that triggers the top-up. If the balance falls below this amount, a top-up is initiated.
    /// </summary>
    [JsonPropertyName("threshold")]
    public required Amount17 Threshold { get; init; }
}
