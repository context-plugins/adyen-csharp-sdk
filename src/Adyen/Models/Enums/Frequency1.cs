using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The frequency of payouts initiated by this payout schedule.
/// <para>
/// Possible values:
/// * daily
/// * weekdays
/// * weekly
/// * monthly
/// </para>
/// <para>
/// Default value: The <c>defaultFrequency</c> from the balance platform schedule that you are applying.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Frequency1>))]
public sealed record Frequency1 : OpenStringEnum<Frequency1>
{
    private Frequency1(string value) : base(value)
    {
    }

    public static readonly Frequency1 Daily = new("daily");

    public static readonly Frequency1 Weekly = new("weekly");

    public static readonly Frequency1 Weekdays = new("weekdays");

    public static readonly Frequency1 Monthly = new("monthly");

    public TResult Match<TResult>(Func<TResult> onDaily,
        Func<TResult> onWeekly,
        Func<TResult> onWeekdays,
        Func<TResult> onMonthly,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Daily => onDaily(),
            _ when this == Weekly => onWeekly(),
            _ when this == Weekdays => onWeekdays(),
            _ when this == Monthly => onMonthly(),
            _ => otherwise(Value)
        };

    public void Match(Action onDaily, Action onWeekly, Action onWeekdays, Action onMonthly, Action<string> otherwise)
    {
        if (this == Daily) onDaily();
        else if (this == Weekly) onWeekly();
        else if (this == Weekdays) onWeekdays();
        else if (this == Monthly) onMonthly();
        else otherwise(Value);
    }
}
