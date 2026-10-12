using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates the type of account. For example, for a multi-account card product.
/// Allowed values:
/// * notApplicable
/// * credit
/// * debit
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType>))]
public sealed record AccountType : OpenStringEnum<AccountType>
{
    private AccountType(string value) : base(value)
    {
    }

    public static readonly AccountType NotApplicable = new("notApplicable");

    public static readonly AccountType Credit = new("credit");

    public static readonly AccountType Debit = new("debit");

    public TResult Match<TResult>(Func<TResult> onNotApplicable,
        Func<TResult> onCredit,
        Func<TResult> onDebit,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotApplicable => onNotApplicable(),
            _ when this == Credit => onCredit(),
            _ when this == Debit => onDebit(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotApplicable, Action onCredit, Action onDebit, Action<string> otherwise)
    {
        if (this == NotApplicable) onNotApplicable();
        else if (this == Credit) onCredit();
        else if (this == Debit) onDebit();
        else otherwise(Value);
    }
}
