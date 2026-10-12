using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Duration
{
    /// <summary>
    /// The unit of time. You can only use <b>minutes</b> and <b>hours</b> if the <c>interval.type</c> is <b>sliding</b>.
    /// <para>
    /// Possible values: <b>minutes</b>, <b>hours</b>, <b>days</b>, <b>weeks</b>, or <b>months</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unit")]
    public Unit? Unit { get; init; }

    /// <summary>
    /// The length of time by the unit. For example, 5 days.
    /// <para>
    /// The maximum duration is 90 days or an equivalent in other units. For example, 3 months.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public int? Value { get; init; }
}
