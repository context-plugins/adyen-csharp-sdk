using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The funding source of the payment method.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FundingSource9>))]
public sealed record FundingSource9 : OpenStringEnum<FundingSource9>
{
    private FundingSource9(string value) : base(value)
    {
    }

    public static readonly FundingSource9 Credit = new("credit");

    public static readonly FundingSource9 Debit = new("debit");

    public static readonly FundingSource9 Prepaid = new("prepaid");

    public TResult Match<TResult>(Func<TResult> onCredit,
        Func<TResult> onDebit,
        Func<TResult> onPrepaid,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Credit => onCredit(),
            _ when this == Debit => onDebit(),
            _ when this == Prepaid => onPrepaid(),
            _ => otherwise(Value)
        };

    public void Match(Action onCredit, Action onDebit, Action onPrepaid, Action<string> otherwise)
    {
        if (this == Credit) onCredit();
        else if (this == Debit) onDebit();
        else if (this == Prepaid) onPrepaid();
        else otherwise(Value);
    }
}
