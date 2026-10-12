using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transaction. Possible values:
/// * <b>splitPayment</b>: for payments
/// * <b>splitRefund</b>: for refunds
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RateType2>))]
public sealed record RateType2 : OpenStringEnum<RateType2>
{
    private RateType2(string value) : base(value)
    {
    }

    public static readonly RateType2 SplitPayment = new("splitPayment");

    public static readonly RateType2 BalanceConversion = new("balanceConversion");

    public static readonly RateType2 Transfer = new("transfer");

    public static readonly RateType2 SplitRefund = new("splitRefund");

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
