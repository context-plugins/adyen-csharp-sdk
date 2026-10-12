using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BalanceTransferType>))]
public sealed record BalanceTransferType : OpenStringEnum<BalanceTransferType>
{
    private BalanceTransferType(string value) : base(value)
    {
    }

    public static readonly BalanceTransferType Tax = new("tax");

    public static readonly BalanceTransferType Fee = new("fee");

    public static readonly BalanceTransferType TerminalSale = new("terminalSale");

    public static readonly BalanceTransferType Credit = new("credit");

    public static readonly BalanceTransferType Debit = new("debit");

    public static readonly BalanceTransferType Adjustment = new("adjustment");

    public TResult Match<TResult>(Func<TResult> onTax,
        Func<TResult> onFee,
        Func<TResult> onTerminalSale,
        Func<TResult> onCredit,
        Func<TResult> onDebit,
        Func<TResult> onAdjustment,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Tax => onTax(),
            _ when this == Fee => onFee(),
            _ when this == TerminalSale => onTerminalSale(),
            _ when this == Credit => onCredit(),
            _ when this == Debit => onDebit(),
            _ when this == Adjustment => onAdjustment(),
            _ => otherwise(Value)
        };

    public void Match(Action onTax,
        Action onFee,
        Action onTerminalSale,
        Action onCredit,
        Action onDebit,
        Action onAdjustment,
        Action<string> otherwise)
    {
        if (this == Tax) onTax();
        else if (this == Fee) onFee();
        else if (this == TerminalSale) onTerminalSale();
        else if (this == Credit) onCredit();
        else if (this == Debit) onDebit();
        else if (this == Adjustment) onAdjustment();
        else otherwise(Value);
    }
}
