using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transfer instrument.
/// <para>
/// Possible value: <b>bankAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type221>))]
public sealed record Type221 : OpenStringEnum<Type221>
{
    private Type221(string value) : base(value)
    {
    }

    public static readonly Type221 BankAccount = new("bankAccount");

    public static readonly Type221 RecurringDetail = new("recurringDetail");

    public TResult Match<TResult>(Func<TResult> onBankAccount,
        Func<TResult> onRecurringDetail,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BankAccount => onBankAccount(),
            _ when this == RecurringDetail => onRecurringDetail(),
            _ => otherwise(Value)
        };

    public void Match(Action onBankAccount, Action onRecurringDetail, Action<string> otherwise)
    {
        if (this == BankAccount) onBankAccount();
        else if (this == RecurringDetail) onRecurringDetail();
        else otherwise(Value);
    }
}
