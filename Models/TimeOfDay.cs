using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TimeOfDay
{
    /// <summary>
    /// The end time in a time-only ISO-8601 extended offset format. For example: <b>08:00:00+02:00</b>, <b>22:30:00-03:00</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endTime")]
    public string? EndTime { get; init; }

    /// <summary>
    /// The start time in a time-only ISO-8601 extended offset format. For example: <b>08:00:00+02:00</b>, <b>22:30:00-03:00</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startTime")]
    public string? StartTime { get; init; }
}
