using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the date when the transfer will be processed. The execution date must be within 30 days of the current date.
/// <para>
/// Until the execution date:
/// - The <c>status</c> of the transfer remains as <b>received</b>.
/// - The <c>reason</c> of the transfer remains as <b>pending</b>.
/// </para>
/// </summary>
public record ExecutionDate1
{
    /// <summary>
    /// The date when the transfer will be processed. This date must be:
    /// * Within 30 days of the current date.
    /// * In the <see href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO 8601 format</see> <b>YYYY-MM-DD</b>. For example: 2025-01-31
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date")]
    public DateTimeOffset? Date { get; init; }

    /// <summary>
    /// The timezone that applies to the execution date. Use a timezone identifier from the <see href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">tz database</see>.
    /// <para>
    /// Example: <b>America/Los_Angeles</b>.
    ///  Default value: <b>Europe/Amsterdam</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }
}
