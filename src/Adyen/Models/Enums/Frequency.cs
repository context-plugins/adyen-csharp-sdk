using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The frequency with which a shopper should be charged.
/// <para>
/// Possible values: <b>adhoc</b>, <b>daily</b>, <b>weekly</b>, <b>biWeekly</b>, <b>monthly</b>, <b>quarterly</b>, <b>halfYearly</b>, <b>yearly</b>., The frequency with which a shopper should be charged.
/// </para>
/// <para>
/// Possible values: <b>daily</b>, <b>weekly</b>, <b>biWeekly</b>, <b>monthly</b>, <b>quarterly</b>, <b>halfYearly</b>, <b>yearly</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Frequency>))]
public sealed record Frequency : OpenStringEnum<Frequency>
{
    private Frequency(string value) : base(value)
    {
    }

    public static readonly Frequency Adhoc = new("adhoc");

    public static readonly Frequency Daily = new("daily");

    public static readonly Frequency Weekly = new("weekly");

    public static readonly Frequency BiWeekly = new("biWeekly");

    public static readonly Frequency Monthly = new("monthly");

    public static readonly Frequency Quarterly = new("quarterly");

    public static readonly Frequency HalfYearly = new("halfYearly");

    public static readonly Frequency Yearly = new("yearly");

    public TResult Match<TResult>(Func<TResult> onAdhoc,
        Func<TResult> onDaily,
        Func<TResult> onWeekly,
        Func<TResult> onBiWeekly,
        Func<TResult> onMonthly,
        Func<TResult> onQuarterly,
        Func<TResult> onHalfYearly,
        Func<TResult> onYearly,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Adhoc => onAdhoc(),
            _ when this == Daily => onDaily(),
            _ when this == Weekly => onWeekly(),
            _ when this == BiWeekly => onBiWeekly(),
            _ when this == Monthly => onMonthly(),
            _ when this == Quarterly => onQuarterly(),
            _ when this == HalfYearly => onHalfYearly(),
            _ when this == Yearly => onYearly(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdhoc,
        Action onDaily,
        Action onWeekly,
        Action onBiWeekly,
        Action onMonthly,
        Action onQuarterly,
        Action onHalfYearly,
        Action onYearly,
        Action<string> otherwise)
    {
        if (this == Adhoc) onAdhoc();
        else if (this == Daily) onDaily();
        else if (this == Weekly) onWeekly();
        else if (this == BiWeekly) onBiWeekly();
        else if (this == Monthly) onMonthly();
        else if (this == Quarterly) onQuarterly();
        else if (this == HalfYearly) onHalfYearly();
        else if (this == Yearly) onYearly();
        else otherwise(Value);
    }
}
