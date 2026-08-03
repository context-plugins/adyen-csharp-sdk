using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record DayOfWeekRestriction
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    /// <summary>
    /// List of days of the week.
    /// <para>
    /// Possible values: <b>monday</b>, <b>tuesday</b>, <b>wednesday</b>, <b>thursday</b>, <b>friday</b>, <b>saturday</b>, <b>sunday</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public IReadOnlyList<Value1>? Value { get; init; }
}
