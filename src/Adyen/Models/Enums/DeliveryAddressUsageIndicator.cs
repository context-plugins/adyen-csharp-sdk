using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicator for the length of time since this delivery address was first used.
/// Allowed values:
/// * thisTransaction
/// * lessThan30Days
/// * from30To60Days
/// * moreThan60Days
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DeliveryAddressUsageIndicator>))]
public sealed record DeliveryAddressUsageIndicator : OpenStringEnum<DeliveryAddressUsageIndicator>
{
    private DeliveryAddressUsageIndicator(string value) : base(value)
    {
    }

    public static readonly DeliveryAddressUsageIndicator ThisTransaction = new("thisTransaction");

    public static readonly DeliveryAddressUsageIndicator LessThan30Days = new("lessThan30Days");

    public static readonly DeliveryAddressUsageIndicator From30To60Days = new("from30To60Days");

    public static readonly DeliveryAddressUsageIndicator MoreThan60Days = new("moreThan60Days");

    public TResult Match<TResult>(Func<TResult> onThisTransaction,
        Func<TResult> onLessThan30Days,
        Func<TResult> onFrom30To60Days,
        Func<TResult> onMoreThan60Days,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ThisTransaction => onThisTransaction(),
            _ when this == LessThan30Days => onLessThan30Days(),
            _ when this == From30To60Days => onFrom30To60Days(),
            _ when this == MoreThan60Days => onMoreThan60Days(),
            _ => otherwise(Value)
        };

    public void Match(Action onThisTransaction,
        Action onLessThan30Days,
        Action onFrom30To60Days,
        Action onMoreThan60Days,
        Action<string> otherwise)
    {
        if (this == ThisTransaction) onThisTransaction();
        else if (this == LessThan30Days) onLessThan30Days();
        else if (this == From30To60Days) onFrom30To60Days();
        else if (this == MoreThan60Days) onMoreThan60Days();
        else otherwise(Value);
    }
}
