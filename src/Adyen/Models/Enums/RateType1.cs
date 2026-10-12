using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RateType1>))]
public sealed record RateType1 : OpenStringEnum<RateType1>
{
    private RateType1(string value) : base(value)
    {
    }

    public static readonly RateType1 SplitPayment = new("splitPayment");

    public static readonly RateType1 BalanceConversion = new("balanceConversion");

    public static readonly RateType1 Transfer = new("transfer");

    public static readonly RateType1 SplitRefund = new("splitRefund");

    public TResult Match<TResult>(Func<TResult> onSplitPayment,
        Func<TResult> onBalanceConversion,
        Func<TResult> onTransfer,
        Func<TResult> onSplitRefund,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SplitPayment => onSplitPayment(),
            _ when this == BalanceConversion => onBalanceConversion(),
            _ when this == Transfer => onTransfer(),
            _ when this == SplitRefund => onSplitRefund(),
            _ => otherwise(Value)
        };

    public void Match(Action onSplitPayment,
        Action onBalanceConversion,
        Action onTransfer,
        Action onSplitRefund,
        Action<string> otherwise)
    {
        if (this == SplitPayment) onSplitPayment();
        else if (this == BalanceConversion) onBalanceConversion();
        else if (this == Transfer) onTransfer();
        else if (this == SplitRefund) onSplitRefund();
        else otherwise(Value);
    }
}
