using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the bank account. Possible values are <b>CURRENT</b>, <b>SAVINGS</b>, <b>BUSINESS</b>, <b>CREDIT_CARD</b>, <b>LOAN</b>, <b>UNKNOWN</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType11>))]
public sealed record AccountType11 : OpenStringEnum<AccountType11>
{
    private AccountType11(string value) : base(value)
    {
    }

    public static readonly AccountType11 Current = new("CURRENT");

    public static readonly AccountType11 Savings = new("SAVINGS");

    public static readonly AccountType11 Business = new("BUSINESS");

    public static readonly AccountType11 CreditCard = new("CREDIT_CARD");

    public static readonly AccountType11 Loan = new("LOAN");

    public static readonly AccountType11 Unknown = new("UNKNOWN");

    public TResult Match<TResult>(Func<TResult> onCurrent,
        Func<TResult> onSavings,
        Func<TResult> onBusiness,
        Func<TResult> onCreditCard,
        Func<TResult> onLoan,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Current => onCurrent(),
            _ when this == Savings => onSavings(),
            _ when this == Business => onBusiness(),
            _ when this == CreditCard => onCreditCard(),
            _ when this == Loan => onLoan(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onCurrent,
        Action onSavings,
        Action onBusiness,
        Action onCreditCard,
        Action onLoan,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == Current) onCurrent();
        else if (this == Savings) onSavings();
        else if (this == Business) onBusiness();
        else if (this == CreditCard) onCreditCard();
        else if (this == Loan) onLoan();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
