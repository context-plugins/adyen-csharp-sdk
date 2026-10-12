using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to <b>debit</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FundingSource>))]
public sealed record FundingSource : OpenStringEnum<FundingSource>
{
    private FundingSource(string value) : base(value)
    {
    }

    public static readonly FundingSource Credit = new("credit");

    public static readonly FundingSource Debit = new("debit");

    public static readonly FundingSource Prepaid = new("prepaid");

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
