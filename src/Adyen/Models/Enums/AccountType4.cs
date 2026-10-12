using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of cardholder account used for the transaction. Allows a cardholder to select the type of account used for the transaction.
/// Possible values:
/// * <b>Default</b>
/// * <b>Savings</b>
/// * <b>Checking</b>
/// * <b>CreditCard</b>
/// * <b>Universal</b>
/// * <b>Investment</b>
/// * <b>CardTotals</b>
/// * <b>EpurseCard</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType4>))]
public sealed record AccountType4 : OpenStringEnum<AccountType4>
{
    private AccountType4(string value) : base(value)
    {
    }

    public static readonly AccountType4 Default = new("Default");

    public static readonly AccountType4 Savings = new("Savings");

    public static readonly AccountType4 Checking = new("Checking");

    public static readonly AccountType4 CreditCard = new("CreditCard");

    public static readonly AccountType4 Universal = new("Universal");

    public static readonly AccountType4 Investment = new("Investment");

    public static readonly AccountType4 CardTotals = new("CardTotals");

    public static readonly AccountType4 EpurseCard = new("EpurseCard");

    public TResult Match<TResult>(Func<TResult> onDefault,
        Func<TResult> onSavings,
        Func<TResult> onChecking,
        Func<TResult> onCreditCard,
        Func<TResult> onUniversal,
        Func<TResult> onInvestment,
        Func<TResult> onCardTotals,
        Func<TResult> onEpurseCard,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Default => onDefault(),
            _ when this == Savings => onSavings(),
            _ when this == Checking => onChecking(),
            _ when this == CreditCard => onCreditCard(),
            _ when this == Universal => onUniversal(),
            _ when this == Investment => onInvestment(),
            _ when this == CardTotals => onCardTotals(),
            _ when this == EpurseCard => onEpurseCard(),
            _ => otherwise(Value)
        };

    public void Match(Action onDefault,
        Action onSavings,
        Action onChecking,
        Action onCreditCard,
        Action onUniversal,
        Action onInvestment,
        Action onCardTotals,
        Action onEpurseCard,
        Action<string> otherwise)
    {
        if (this == Default) onDefault();
        else if (this == Savings) onSavings();
        else if (this == Checking) onChecking();
        else if (this == CreditCard) onCreditCard();
        else if (this == Universal) onUniversal();
        else if (this == Investment) onInvestment();
        else if (this == CardTotals) onCardTotals();
        else if (this == EpurseCard) onEpurseCard();
        else otherwise(Value);
    }
}
