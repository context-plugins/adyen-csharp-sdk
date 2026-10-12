using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Expiry month for the test card range.
/// <para>
/// Allowed values:
/// * JANUARY
/// * FEBRUARY
/// * MARCH
/// * APRIL
/// * MAY
/// * JUNE
/// * JULY
/// * AUGUST
/// * SEPTEMBER
/// * OCTOBER
/// * NOVEMBER
/// * DECEMBER
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ExpiryMonth>))]
public sealed record ExpiryMonth : OpenStringEnum<ExpiryMonth>
{
    private ExpiryMonth(string value) : base(value)
    {
    }

    public static readonly ExpiryMonth April = new("APRIL");

    public static readonly ExpiryMonth August = new("AUGUST");

    public static readonly ExpiryMonth December = new("DECEMBER");

    public static readonly ExpiryMonth February = new("FEBRUARY");

    public static readonly ExpiryMonth January = new("JANUARY");

    public static readonly ExpiryMonth July = new("JULY");

    public static readonly ExpiryMonth June = new("JUNE");

    public static readonly ExpiryMonth March = new("MARCH");

    public static readonly ExpiryMonth May = new("MAY");

    public static readonly ExpiryMonth November = new("NOVEMBER");

    public static readonly ExpiryMonth October = new("OCTOBER");

    public static readonly ExpiryMonth September = new("SEPTEMBER");

    public TResult Match<TResult>(Func<TResult> onApril,
        Func<TResult> onAugust,
        Func<TResult> onDecember,
        Func<TResult> onFebruary,
        Func<TResult> onJanuary,
        Func<TResult> onJuly,
        Func<TResult> onJune,
        Func<TResult> onMarch,
        Func<TResult> onMay,
        Func<TResult> onNovember,
        Func<TResult> onOctober,
        Func<TResult> onSeptember,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == April => onApril(),
            _ when this == August => onAugust(),
            _ when this == December => onDecember(),
            _ when this == February => onFebruary(),
            _ when this == January => onJanuary(),
            _ when this == July => onJuly(),
            _ when this == June => onJune(),
            _ when this == March => onMarch(),
            _ when this == May => onMay(),
            _ when this == November => onNovember(),
            _ when this == October => onOctober(),
            _ when this == September => onSeptember(),
            _ => otherwise(Value)
        };

    public void Match(Action onApril,
        Action onAugust,
        Action onDecember,
        Action onFebruary,
        Action onJanuary,
        Action onJuly,
        Action onJune,
        Action onMarch,
        Action onMay,
        Action onNovember,
        Action onOctober,
        Action onSeptember,
        Action<string> otherwise)
    {
        if (this == April) onApril();
        else if (this == August) onAugust();
        else if (this == December) onDecember();
        else if (this == February) onFebruary();
        else if (this == January) onJanuary();
        else if (this == July) onJuly();
        else if (this == June) onJune();
        else if (this == March) onMarch();
        else if (this == May) onMay();
        else if (this == November) onNovember();
        else if (this == October) onOctober();
        else if (this == September) onSeptember();
        else otherwise(Value);
    }
}
