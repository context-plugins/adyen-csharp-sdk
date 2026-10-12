using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicator for the length of time since this payment method was added to this shopper's account.
/// Allowed values:
/// * notApplicable
/// * thisTransaction
/// * lessThan30Days
/// * from30To60Days
/// * moreThan60Days
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentAccountIndicator>))]
public sealed record PaymentAccountIndicator : OpenStringEnum<PaymentAccountIndicator>
{
    private PaymentAccountIndicator(string value) : base(value)
    {
    }

    public static readonly PaymentAccountIndicator NotApplicable = new("notApplicable");

    public static readonly PaymentAccountIndicator ThisTransaction = new("thisTransaction");

    public static readonly PaymentAccountIndicator LessThan30Days = new("lessThan30Days");

    public static readonly PaymentAccountIndicator From30To60Days = new("from30To60Days");

    public static readonly PaymentAccountIndicator MoreThan60Days = new("moreThan60Days");

    public TResult Match<TResult>(Func<TResult> onNotApplicable,
        Func<TResult> onThisTransaction,
        Func<TResult> onLessThan30Days,
        Func<TResult> onFrom30To60Days,
        Func<TResult> onMoreThan60Days,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotApplicable => onNotApplicable(),
            _ when this == ThisTransaction => onThisTransaction(),
            _ when this == LessThan30Days => onLessThan30Days(),
            _ when this == From30To60Days => onFrom30To60Days(),
            _ when this == MoreThan60Days => onMoreThan60Days(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotApplicable,
        Action onThisTransaction,
        Action onLessThan30Days,
        Action onFrom30To60Days,
        Action onMoreThan60Days,
        Action<string> otherwise)
    {
        if (this == NotApplicable) onNotApplicable();
        else if (this == ThisTransaction) onThisTransaction();
        else if (this == LessThan30Days) onLessThan30Days();
        else if (this == From30To60Days) onFrom30To60Days();
        else if (this == MoreThan60Days) onMoreThan60Days();
        else otherwise(Value);
    }
}
