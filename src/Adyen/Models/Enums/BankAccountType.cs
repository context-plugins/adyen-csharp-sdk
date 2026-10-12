using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The bank account type (checking, savings...).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankAccountType>))]
public sealed record BankAccountType : OpenStringEnum<BankAccountType>
{
    private BankAccountType(string value) : base(value)
    {
    }

    public static readonly BankAccountType Balance = new("balance");

    public static readonly BankAccountType Checking = new("checking");

    public static readonly BankAccountType Deposit = new("deposit");

    public static readonly BankAccountType General = new("general");

    public static readonly BankAccountType Other = new("other");

    public static readonly BankAccountType Payment = new("payment");

    public static readonly BankAccountType Savings = new("savings");

    public TResult Match<TResult>(Func<TResult> onBalance,
        Func<TResult> onChecking,
        Func<TResult> onDeposit,
        Func<TResult> onGeneral,
        Func<TResult> onOther,
        Func<TResult> onPayment,
        Func<TResult> onSavings,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Balance => onBalance(),
            _ when this == Checking => onChecking(),
            _ when this == Deposit => onDeposit(),
            _ when this == General => onGeneral(),
            _ when this == Other => onOther(),
            _ when this == Payment => onPayment(),
            _ when this == Savings => onSavings(),
            _ => otherwise(Value)
        };

    public void Match(Action onBalance,
        Action onChecking,
        Action onDeposit,
        Action onGeneral,
        Action onOther,
        Action onPayment,
        Action onSavings,
        Action<string> otherwise)
    {
        if (this == Balance) onBalance();
        else if (this == Checking) onChecking();
        else if (this == Deposit) onDeposit();
        else if (this == General) onGeneral();
        else if (this == Other) onOther();
        else if (this == Payment) onPayment();
        else if (this == Savings) onSavings();
        else otherwise(Value);
    }
}
