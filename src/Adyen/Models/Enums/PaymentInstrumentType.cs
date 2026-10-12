using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the payment instrument. For example, "BankAccount" or "Card".
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentInstrumentType>))]
public sealed record PaymentInstrumentType : OpenStringEnum<PaymentInstrumentType>
{
    private PaymentInstrumentType(string value) : base(value)
    {
    }

    public static readonly PaymentInstrumentType BankAccount = new("BankAccount");

    public static readonly PaymentInstrumentType Card = new("Card");

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
