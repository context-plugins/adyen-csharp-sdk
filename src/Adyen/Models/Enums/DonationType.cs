using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DonationType>))]
public sealed record DonationType : OpenStringEnum<DonationType>
{
    private DonationType(string value) : base(value)
    {
    }

    public static readonly DonationType Roundup = new("roundup");

    public static readonly DonationType FixedAmounts = new("fixedAmounts");

    public static readonly DonationType FixedAmountsRoundup = new("fixedAmountsRoundup");

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
