using System;
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
public sealed record DayOfWeekEnum : OpenStringEnum<DayOfWeekEnum>
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

    public TResult Match<TResult>(Func<TResult> onFriday,
        Func<TResult> onMonday,
        Func<TResult> onSaturday,
        Func<TResult> onSunday,
        Func<TResult> onThursday,
        Func<TResult> onTuesday,
        Func<TResult> onWednesday,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Friday => onFriday(),
            _ when this == Monday => onMonday(),
            _ when this == Saturday => onSaturday(),
            _ when this == Sunday => onSunday(),
            _ when this == Thursday => onThursday(),
            _ when this == Tuesday => onTuesday(),
            _ when this == Wednesday => onWednesday(),
            _ => otherwise(Value)
        };

    public void Match(Action onFriday,
        Action onMonday,
        Action onSaturday,
        Action onSunday,
        Action onThursday,
        Action onTuesday,
        Action onWednesday,
        Action<string> otherwise)
    {
        if (this == Friday) onFriday();
        else if (this == Monday) onMonday();
        else if (this == Saturday) onSaturday();
        else if (this == Sunday) onSunday();
        else if (this == Thursday) onThursday();
        else if (this == Tuesday) onTuesday();
        else if (this == Wednesday) onWednesday();
        else otherwise(Value);
    }
}
