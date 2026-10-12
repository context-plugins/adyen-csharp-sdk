using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of instalment transaction.
/// Possible values:
/// * <b>Annual</b>
/// * <b>Daily</b>
/// * <b>Monthly</b>
/// * <b>Weekly</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PeriodUnit1>))]
public sealed record PeriodUnit1 : OpenStringEnum<PeriodUnit1>
{
    private PeriodUnit1(string value) : base(value)
    {
    }

    public static readonly PeriodUnit1 Daily = new("Daily");

    public static readonly PeriodUnit1 Weekly = new("Weekly");

    public static readonly PeriodUnit1 Monthly = new("Monthly");

    public static readonly PeriodUnit1 Annual = new("Annual");

    public TResult Match<TResult>(Func<TResult> onDaily,
        Func<TResult> onWeekly,
        Func<TResult> onMonthly,
        Func<TResult> onAnnual,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Daily => onDaily(),
            _ when this == Weekly => onWeekly(),
            _ when this == Monthly => onMonthly(),
            _ when this == Annual => onAnnual(),
            _ => otherwise(Value)
        };

    public void Match(Action onDaily, Action onWeekly, Action onMonthly, Action onAnnual, Action<string> otherwise)
    {
        if (this == Daily) onDaily();
        else if (this == Weekly) onWeekly();
        else if (this == Monthly) onMonthly();
        else if (this == Annual) onAnnual();
        else otherwise(Value);
    }
}
