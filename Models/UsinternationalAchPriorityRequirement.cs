using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UsinternationalAchPriorityRequirement
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
    public required Type393 Type { get; init; }
}
