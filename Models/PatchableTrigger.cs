using System.Text.Json.Serialization;
using Adyen.Models.AnyOf;

namespace Adyen.Models;

public record PatchableTrigger
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
