using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UsInternationalAchPriorityRequirement
{
    /// <summary>
    /// Specifies that transactions deemed to be International ACH (IAT) per OFAC/NACHA rules cannot have fast priority.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// <b>usInternationalAchPriorityRequirement</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "usInternationalAchPriorityRequirement";
}
