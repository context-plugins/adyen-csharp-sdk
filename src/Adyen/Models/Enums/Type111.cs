using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of payment instrument.
/// <para>
/// Possible values: <b>card</b>, <b>bankAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type111>))]
public sealed record Type111 : OpenStringEnum<Type111>
{
    private Type111(string value) : base(value)
    {
    }

    public static readonly Type111 BankAccount = new("bankAccount");

    public static readonly Type111 Card = new("card");

    public TResult Match<TResult>(Func<TResult> onBankAccount, Func<TResult> onCard, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BankAccount => onBankAccount(),
            _ when this == Card => onCard(),
            _ => otherwise(Value)
        };

    public void Match(Action onBankAccount, Action onCard, Action<string> otherwise)
    {
        if (this == BankAccount) onBankAccount();
        else if (this == Card) onCard();
        else otherwise(Value);
    }
}
