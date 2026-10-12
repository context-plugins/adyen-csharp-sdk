using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of donation to collect from the shopper. Possible values:
/// <list type="bullet">
///   <item><description><b>roundup</b>: Round up the transaction amount.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>fixedAmounts</b>: Choose a fixed amount.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>fixedAmountsRoundup</b>: Round up, or choose a fixed amount.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DonationType1>))]
public sealed record DonationType1 : OpenStringEnum<DonationType1>
{
    private DonationType1(string value) : base(value)
    {
    }

    public static readonly DonationType1 Roundup = new("roundup");

    public static readonly DonationType1 FixedAmounts = new("fixedAmounts");

    public static readonly DonationType1 FixedAmountsRoundup = new("fixedAmountsRoundup");

    public TResult Match<TResult>(Func<TResult> onRoundup,
        Func<TResult> onFixedAmounts,
        Func<TResult> onFixedAmountsRoundup,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Roundup => onRoundup(),
            _ when this == FixedAmounts => onFixedAmounts(),
            _ when this == FixedAmountsRoundup => onFixedAmountsRoundup(),
            _ => otherwise(Value)
        };

    public void Match(Action onRoundup, Action onFixedAmounts, Action onFixedAmountsRoundup, Action<string> otherwise)
    {
        if (this == Roundup) onRoundup();
        else if (this == FixedAmounts) onFixedAmounts();
        else if (this == FixedAmountsRoundup) onFixedAmountsRoundup();
        else otherwise(Value);
    }
}
