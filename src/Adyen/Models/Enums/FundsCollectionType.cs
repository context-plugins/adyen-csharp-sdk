using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FundsCollectionType>))]
public sealed record FundsCollectionType : OpenStringEnum<FundsCollectionType>
{
    private FundsCollectionType(string value) : base(value)
    {
    }

    public static readonly FundsCollectionType UnscheduledRepayment = new("UnscheduledRepayment");

    public static readonly FundsCollectionType Revocation = new("Revocation");

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
