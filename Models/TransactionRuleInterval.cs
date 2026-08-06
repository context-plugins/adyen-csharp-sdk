using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TransactionRuleInterval
{
    /// <summary>
    /// The day of month, used when the <c>duration.unit</c> is <b>months</b>. If not provided, by default, this is set to <b>1</b>, the first day of the month.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dayOfMonth")]
    public int? DayOfMonth { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dayOfWeek")]
    public DayOfWeekEnum? DayOfWeek { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration")]
    public Duration? Duration { get; init; }

    /// <summary>
    /// The time of day, in <b>hh:mm:ss</b> format, used when the <c>duration.unit</c> is <b>hours</b>. If not provided, by default, this is set to <b>00:00:00</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">time zone</see>. For example, <b>Europe/Amsterdam</b>. By default, this is set to <b>UTC</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; init; }

    [JsonPropertyName("type")]
    public required Type13 Type { get; init; }
}
