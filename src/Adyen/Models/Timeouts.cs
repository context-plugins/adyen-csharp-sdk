using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Timeouts
{
    /// <summary>
    /// Indicates the number of seconds of inactivity after which the terminal display goes into sleep mode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fromActiveToSleep")]
    public int? FromActiveToSleep { get; init; }
}
