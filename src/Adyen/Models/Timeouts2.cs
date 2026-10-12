using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for device <see href="https://docs.adyen.com/point-of-sale/pos-timeouts#device-time-out">time-outs</see>.
/// </summary>
public record Timeouts2
{
    /// <summary>
    /// Indicates the number of seconds of inactivity after which the terminal display goes into sleep mode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fromActiveToSleep")]
    public int? FromActiveToSleep { get; init; }
}
