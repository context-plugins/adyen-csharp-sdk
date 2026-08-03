using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The unit of time. You can only use <b>minutes</b> and <b>hours</b> if the <c>interval.type</c> is <b>sliding</b>.
/// <para>
/// Possible values: <b>minutes</b>, <b>hours</b>, <b>days</b>, <b>weeks</b>, or <b>months</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Unit>))]
public sealed record Unit : StringEnum<Unit>
{
    private Unit(string value) : base(value)
    {
    }

    public static readonly Unit Days = new("days");

    public static readonly Unit Hours = new("hours");

    public static readonly Unit Minutes = new("minutes");

    public static readonly Unit Months = new("months");

    public static readonly Unit Weeks = new("weeks");

    public static Unit FromValue(string value) => FromValueCore(value);
}
