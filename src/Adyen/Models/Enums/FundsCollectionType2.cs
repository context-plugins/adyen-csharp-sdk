using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of funds collection.
/// <para>
/// Possible values: <b>UnscheduledRepayment</b>, <b>Revocation</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FundsCollectionType2>))]
public sealed record FundsCollectionType2 : OpenStringEnum<FundsCollectionType2>
{
    private FundsCollectionType2(string value) : base(value)
    {
    }

    public static readonly FundsCollectionType2 UnscheduledRepayment = new("UnscheduledRepayment");

    public static readonly FundsCollectionType2 Revocation = new("Revocation");

    public TResult Match<TResult>(Func<TResult> onUnscheduledRepayment,
        Func<TResult> onRevocation,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UnscheduledRepayment => onUnscheduledRepayment(),
            _ when this == Revocation => onRevocation(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnscheduledRepayment, Action onRevocation, Action<string> otherwise)
    {
        if (this == UnscheduledRepayment) onUnscheduledRepayment();
        else if (this == Revocation) onRevocation();
        else otherwise(Value);
    }
}
