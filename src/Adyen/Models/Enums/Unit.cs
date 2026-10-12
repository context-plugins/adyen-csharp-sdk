using System;
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
public sealed record Unit : OpenStringEnum<Unit>
{
    private Unit(string value) : base(value)
    {
    }

    public static readonly Unit Days = new("days");

    public static readonly Unit Hours = new("hours");

    public static readonly Unit Minutes = new("minutes");

    public static readonly Unit Months = new("months");

    public static readonly Unit Weeks = new("weeks");

    public TResult Match<TResult>(Func<TResult> onDays,
        Func<TResult> onHours,
        Func<TResult> onMinutes,
        Func<TResult> onMonths,
        Func<TResult> onWeeks,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Days => onDays(),
            _ when this == Hours => onHours(),
            _ when this == Minutes => onMinutes(),
            _ when this == Months => onMonths(),
            _ when this == Weeks => onWeeks(),
            _ => otherwise(Value)
        };

    public void Match(Action onDays,
        Action onHours,
        Action onMinutes,
        Action onMonths,
        Action onWeeks,
        Action<string> otherwise)
    {
        if (this == Days) onDays();
        else if (this == Hours) onHours();
        else if (this == Minutes) onMinutes();
        else if (this == Months) onMonths();
        else if (this == Weeks) onWeeks();
        else otherwise(Value);
    }
}
