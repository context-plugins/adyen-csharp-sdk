using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record PatchableTrigger
{
    /// <summary>
    /// Contains the details about the schedule that determines when the top up is executed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule")]
    public PatchableSchedule? Schedule { get; init; }

    /// <summary>
    /// The balance threshold that triggers the top-up. If the balance falls below this amount, a top-up is initiated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threshold")]
    public PatchableAmountDto1? Threshold { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
