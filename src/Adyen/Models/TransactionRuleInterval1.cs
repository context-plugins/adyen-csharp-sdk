using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The <see href="https://docs.adyen.com/issuing/transaction-rules#time-intervals">time interval</see> when the rule conditions apply.
/// </summary>
public record TransactionRuleInterval1
{
    /// <summary>
    /// The day of month, used when the <c>duration.unit</c> is <b>months</b>. If not provided, by default, this is set to <b>1</b>, the first day of the month.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dayOfMonth")]
    public int? DayOfMonth { get; init; }

    /// <summary>
    /// The day of week, used when the <c>duration.unit</c> is <b>weeks</b>. If not provided, by default, this is set to <b>monday</b>.
    /// <para>
    /// Possible values: <b>sunday</b>, <b>monday</b>, <b>tuesday</b>, <b>wednesday</b>, <b>thursday</b>, <b>friday</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dayOfWeek")]
    public DayOfWeekEnum? DayOfWeek { get; init; }

    /// <summary>
    /// The duration, which you can specify in hours, days, weeks, or months. The maximum duration is 90 days or an equivalent in other units. Required when the <c>type</c> is <b>rolling</b> or <b>sliding</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration")]
    public Duration1? Duration { get; init; }

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

    /// <summary>
    /// The <see href="https://docs.adyen.com/issuing/transaction-rules#time-intervals">type of interval</see> during which the rule conditions and limits apply, and how often counters are reset.
    /// <para>
    /// Possible values:
    ///   * <b>perTransaction</b>: conditions are evaluated and the counters are reset for every transaction.
    ///  * <b>daily</b>: the counters are reset daily at 00:00:00 CET.
    ///  * <b>weekly</b>: the counters are reset every Monday at 00:00:00 CET.
    ///  * <b>monthly</b>: the counters reset every first day of the month at 00:00:00 CET.
    ///  * <b>lifetime</b>: conditions are applied to the lifetime of the payment instrument.
    ///  * <b>rolling</b>: conditions are applied and the counters are reset based on a <c>duration</c>. If the reset date and time are not provided, Adyen applies the default reset time similar to fixed intervals. For example, if the duration is every two weeks, the counter resets every third Monday at 00:00:00 CET.
    ///  * <b>sliding</b>: conditions are applied and the counters are reset based on the current time and a <c>duration</c> that you specify.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type131 Type { get; init; }
}
