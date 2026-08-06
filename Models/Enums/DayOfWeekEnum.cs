using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The day of week, used when the <c>duration.unit</c> is <b>weeks</b>. If not provided, by default, this is set to <b>monday</b>.
/// <para>
/// Possible values: <b>sunday</b>, <b>monday</b>, <b>tuesday</b>, <b>wednesday</b>, <b>thursday</b>, <b>friday</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DayOfWeekEnum>))]
public sealed record DayOfWeekEnum : StringEnum<DayOfWeekEnum>
{
    private DayOfWeekEnum(string value) : base(value)
    {
    }

    public static readonly DayOfWeekEnum Friday = new("friday");

    public static readonly DayOfWeekEnum Monday = new("monday");

    public static readonly DayOfWeekEnum Saturday = new("saturday");

    public static readonly DayOfWeekEnum Sunday = new("sunday");

    public static readonly DayOfWeekEnum Thursday = new("thursday");

    public static readonly DayOfWeekEnum Tuesday = new("tuesday");

    public static readonly DayOfWeekEnum Wednesday = new("wednesday");

    public static DayOfWeekEnum FromValue(string value) => FromValueCore(value);
}
