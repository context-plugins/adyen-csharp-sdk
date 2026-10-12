using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ForceRebootDetails
{
    /// <summary>
    /// The type of terminal action. The value <b>ForceReboot</b> triggers an immediate reboot of the specified terminal(s).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type210? Type { get; init; } = Type210.ForceReboot;
}
