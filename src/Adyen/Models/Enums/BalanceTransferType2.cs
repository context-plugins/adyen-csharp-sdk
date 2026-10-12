using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of balance transfer. Possible values: <b>tax</b>, <b>fee</b>, <b>terminalSale</b>, <b>credit</b>, <b>debit</b>, and <b>adjustment</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BalanceTransferType2>))]
public sealed record BalanceTransferType2 : OpenStringEnum<BalanceTransferType2>
{
    private BalanceTransferType2(string value) : base(value)
    {
    }

    public static readonly BalanceTransferType2 Tax = new("tax");

    public static readonly BalanceTransferType2 Fee = new("fee");

    public static readonly BalanceTransferType2 TerminalSale = new("terminalSale");

    public static readonly BalanceTransferType2 Credit = new("credit");

    public static readonly BalanceTransferType2 Debit = new("debit");

    public static readonly BalanceTransferType2 Adjustment = new("adjustment");

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
