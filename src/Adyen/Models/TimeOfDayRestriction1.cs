using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// A start and end time in a time-only ISO-8601 extended offset format. Supported operations: <b>equals</b>, <b>notEquals</b>.
/// </summary>
public record TimeOfDayRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public TimeOfDay? Value { get; init; }
}
