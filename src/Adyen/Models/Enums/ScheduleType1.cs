using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of schedule at which the top up is executed.
/// * <b>weekdays</b>: pull in funds Monday-Friday at 07:00 AM in the local timezone of the balance account.
/// <list type="bullet">
///   <item><description><b>weekly</b>: pull in funds every Monday at 07:00 AM in the local timezone of the balance account.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>monthly</b>: pull in funds every first of the month at 07:00 AM in the local timezone of the balance account.</description></item>
///   <item><description><b>null</b> (default): continuous monitoring.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScheduleType1>))]
public sealed record ScheduleType1 : OpenStringEnum<ScheduleType1>
{
    private ScheduleType1(string value) : base(value)
    {
    }

    public static readonly ScheduleType1 Weekdays = new("weekdays");

    public static readonly ScheduleType1 Weekly = new("weekly");

    public static readonly ScheduleType1 Monthly = new("monthly");

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
