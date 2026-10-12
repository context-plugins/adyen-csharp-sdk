using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the cashout transfer.
/// <para>
/// Possible values:
/// - <b>cashoutRepayment</b>: Corresponds to the transfer created to deduct the cashout amount after settlement.
/// - <b>cashoutFee</b>: Corresponds to the transfer created to debit the cashout fee form the user's balance account.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type121>))]
public sealed record Type121 : OpenStringEnum<Type121>
{
    private Type121(string value) : base(value)
    {
    }

    public static readonly Type121 CashoutRepayment = new("cashoutRepayment");

    public static readonly Type121 CashoutFee = new("cashoutFee");

    public TResult Match<TResult>(Func<TResult> onCashoutRepayment,
        Func<TResult> onCashoutFee,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CashoutRepayment => onCashoutRepayment(),
            _ when this == CashoutFee => onCashoutFee(),
            _ => otherwise(Value)
        };

    public void Match(Action onCashoutRepayment, Action onCashoutFee, Action<string> otherwise)
    {
        if (this == CashoutRepayment) onCashoutRepayment();
        else if (this == CashoutFee) onCashoutFee();
        else otherwise(Value);
    }
}
