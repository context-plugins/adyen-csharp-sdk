using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value>))]
public sealed record Value : OpenStringEnum<Value>
{
    private Value(string value) : base(value)
    {
    }

    public static readonly Value BalanceAccount = new("balanceAccount");

    public static readonly Value BankAccount = new("bankAccount");

    public static readonly Value Card = new("card");

    public static readonly Value TransferInstrument = new("transferInstrument");

    public TResult Match<TResult>(Func<TResult> onBalanceAccount,
        Func<TResult> onBankAccount,
        Func<TResult> onCard,
        Func<TResult> onTransferInstrument,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BalanceAccount => onBalanceAccount(),
            _ when this == BankAccount => onBankAccount(),
            _ when this == Card => onCard(),
            _ when this == TransferInstrument => onTransferInstrument(),
            _ => otherwise(Value)
        };

    public void Match(Action onBalanceAccount,
        Action onBankAccount,
        Action onCard,
        Action onTransferInstrument,
        Action<string> otherwise)
    {
        if (this == BalanceAccount) onBalanceAccount();
        else if (this == BankAccount) onBankAccount();
        else if (this == Card) onCard();
        else if (this == TransferInstrument) onTransferInstrument();
        else otherwise(Value);
    }
}
