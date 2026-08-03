using System.Text.Json.Serialization;
using Adyen.Models.AnyOf;

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
    public Schedule16? Schedule { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threshold")]
    public Threshold3? Threshold { get; init; }
}
