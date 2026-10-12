using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for terminal hardware features.
/// </summary>
public record Hardware1
{
    /// <summary>
    /// The brightness of the display when the terminal is being used, expressed as a percentage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("displayMaximumBackLight")]
    public int? DisplayMaximumBackLight { get; init; }

    /// <summary>
    /// The hour of the day when the terminal is set to reset the Totals report. By default, the reset hour is at 6:00 AM in the timezone of the terminal. Minimum value: 0, maximum value: 23.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resetTotalsHour")]
    public int? ResetTotalsHour { get; init; }

    /// <summary>
    /// The hour of the day when the terminal is set to reboot to apply the configuration and software updates. By default, the restart hour is at 6:00 AM in the timezone of the terminal. Minimum value: 0, maximum value: 23.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("restartHour")]
    public int? RestartHour { get; init; }
}
