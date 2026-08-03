using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The day of week, used when the <c>duration.unit</c> is <b>weeks</b>. If not provided, by default, this is set to <b>monday</b>.
/// <para>
/// Possible values: <b>sunday</b>, <b>monday</b>, <b>tuesday</b>, <b>wednesday</b>, <b>thursday</b>, <b>friday</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DayOfWeek>))]
public sealed record DayOfWeek : StringEnum<DayOfWeek>
{
    private DayOfWeek(string value) : base(value)
    {
    }

    public static readonly DayOfWeek Friday = new("friday");

    public static readonly DayOfWeek Monday = new("monday");

    public static readonly DayOfWeek Saturday = new("saturday");

    public static readonly DayOfWeek Sunday = new("sunday");

    public static readonly DayOfWeek Thursday = new("thursday");

    public static readonly DayOfWeek Tuesday = new("tuesday");

    public static readonly DayOfWeek Wednesday = new("wednesday");

    public static DayOfWeek FromValue(string value) => FromValueCore(value);
}
