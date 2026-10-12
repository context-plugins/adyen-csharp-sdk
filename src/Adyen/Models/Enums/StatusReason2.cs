using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason for updating the status of the payment instrument.
/// <para>
/// Possible values: <b>lost</b>, <b>stolen</b>, <b>damaged</b>, <b>suspectedFraud</b>, <b>expired</b>, <b>endOfLife</b>, <b>accountClosure</b>, <b>other</b>.
/// If the reason is <b>other</b>, you must also send the <c>statusComment</c> parameter describing the status change.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StatusReason2>))]
public sealed record StatusReason2 : OpenStringEnum<StatusReason2>
{
    private StatusReason2(string value) : base(value)
    {
    }

    public static readonly StatusReason2 AccountClosure = new("accountClosure");

    public static readonly StatusReason2 Damaged = new("damaged");

    public static readonly StatusReason2 EndOfLife = new("endOfLife");

    public static readonly StatusReason2 Expired = new("expired");

    public static readonly StatusReason2 Lost = new("lost");

    public static readonly StatusReason2 Other = new("other");

    public static readonly StatusReason2 Stolen = new("stolen");

    public static readonly StatusReason2 SuspectedFraud = new("suspectedFraud");

    public static readonly StatusReason2 TransactionRule = new("transactionRule");

    public TResult Match<TResult>(Func<TResult> onAccountClosure,
        Func<TResult> onDamaged,
        Func<TResult> onEndOfLife,
        Func<TResult> onExpired,
        Func<TResult> onLost,
        Func<TResult> onOther,
        Func<TResult> onStolen,
        Func<TResult> onSuspectedFraud,
        Func<TResult> onTransactionRule,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountClosure => onAccountClosure(),
            _ when this == Damaged => onDamaged(),
            _ when this == EndOfLife => onEndOfLife(),
            _ when this == Expired => onExpired(),
            _ when this == Lost => onLost(),
            _ when this == Other => onOther(),
            _ when this == Stolen => onStolen(),
            _ when this == SuspectedFraud => onSuspectedFraud(),
            _ when this == TransactionRule => onTransactionRule(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountClosure,
        Action onDamaged,
        Action onEndOfLife,
        Action onExpired,
        Action onLost,
        Action onOther,
        Action onStolen,
        Action onSuspectedFraud,
        Action onTransactionRule,
        Action<string> otherwise)
    {
        if (this == AccountClosure) onAccountClosure();
        else if (this == Damaged) onDamaged();
        else if (this == EndOfLife) onEndOfLife();
        else if (this == Expired) onExpired();
        else if (this == Lost) onLost();
        else if (this == Other) onOther();
        else if (this == Stolen) onStolen();
        else if (this == SuspectedFraud) onSuspectedFraud();
        else if (this == TransactionRule) onTransactionRule();
        else otherwise(Value);
    }
}
