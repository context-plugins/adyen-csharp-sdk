using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SweepSchedule
{
    /// <summary>
    /// A <see href="https://en.wikipedia.org/wiki/Cron#CRON_expression">cron expression</see> that is used to set the sweep schedule. The schedule uses the time zone of the balance account.
    /// For example, <b>30 17 * * MON</b> schedules a sweep every Monday at 17:30.
    /// <para>
    /// The expression must have five values separated by a single space in the following order:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Minute: <b>0-59</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Hour: <b>0-23</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Day of the month: <b>1-31</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Month: <b>1-12</b> or <b>JAN-DEC</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Day of the week: <b>0-7</b> (0 and 7 are Sunday) or <b>MON-SUN</b>.</description></item>
    /// </list>
    /// <para>
    /// The following non-standard characters are supported: <b>&amp;ast;</b>, <b>L</b>, <b>#</b>, <b>W</b> and <b>/</b>. See <see href="https://crontab.guru/">crontab guru</see> for more examples.
    /// </para>
    /// <para>
    /// Required when <c>type</c> is <b>cron</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; init; }

    [JsonPropertyName("type")]
    public required Type6 Type { get; init; }
}
