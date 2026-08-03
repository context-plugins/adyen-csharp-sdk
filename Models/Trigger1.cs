using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The condition that triggers the top-up. This can be a recurring schedule or a minimum balance threshold.
/// </summary>
public record Trigger1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public Schedule2? Schedule { get; init; }

    [JsonPropertyName("threshold")]
    public required Threshold2 Threshold { get; init; }
}
