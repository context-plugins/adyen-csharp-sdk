using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The condition that triggers the top-up. This can be a recurring schedule or a minimum balance threshold.
/// </summary>
public record PatchableTrigger2
{
    /// <summary>
    /// Contains the details about the schedule that determines when the top up is executed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public Schedule1? Schedule { get; init; }

    /// <summary>
    /// The balance threshold that triggers the top-up. If the balance falls below this amount, a top-up is initiated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threshold")]
    public PatchableAmountDto1? Threshold { get; init; }
}
