using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ScheduleType>))]
public sealed record ScheduleType : OpenStringEnum<ScheduleType>
{
    private ScheduleType(string value) : base(value)
    {
    }

    public static readonly ScheduleType Weekdays = new("weekdays");

    public static readonly ScheduleType Weekly = new("weekly");

    public static readonly ScheduleType Monthly = new("monthly");

    public TResult Match<TResult>(Func<TResult> onWeekdays,
        Func<TResult> onWeekly,
        Func<TResult> onMonthly,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Weekdays => onWeekdays(),
            _ when this == Weekly => onWeekly(),
            _ when this == Monthly => onMonthly(),
            _ => otherwise(Value)
        };

    public void Match(Action onWeekdays, Action onWeekly, Action onMonthly, Action<string> otherwise)
    {
        if (this == Weekdays) onWeekdays();
        else if (this == Weekly) onWeekly();
        else if (this == Monthly) onMonthly();
        else otherwise(Value);
    }
}
