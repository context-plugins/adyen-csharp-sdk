using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The risk level of the transaction as classified by the <see href="https://docs.adyen.com/risk-management/configure-your-risk-profile/machine-learning-rules/">machine learning</see> fraud risk rule. The risk level indicates the likelihood that a transaction will result in a fraudulent dispute. Possible values:
/// * veryLow
/// * low
/// * medium
/// * high
/// * veryHigh
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FraudRiskLevel>))]
public sealed record FraudRiskLevel : OpenStringEnum<FraudRiskLevel>
{
    private FraudRiskLevel(string value) : base(value)
    {
    }

    public static readonly FraudRiskLevel VeryLow = new("veryLow");

    public static readonly FraudRiskLevel Low = new("low");

    public static readonly FraudRiskLevel Medium = new("medium");

    public static readonly FraudRiskLevel High = new("high");

    public static readonly FraudRiskLevel VeryHigh = new("veryHigh");

    public TResult Match<TResult>(Func<TResult> onVeryLow,
        Func<TResult> onLow,
        Func<TResult> onMedium,
        Func<TResult> onHigh,
        Func<TResult> onVeryHigh,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == VeryLow => onVeryLow(),
            _ when this == Low => onLow(),
            _ when this == Medium => onMedium(),
            _ when this == High => onHigh(),
            _ when this == VeryHigh => onVeryHigh(),
            _ => otherwise(Value)
        };

    public void Match(Action onVeryLow,
        Action onLow,
        Action onMedium,
        Action onHigh,
        Action onVeryHigh,
        Action<string> otherwise)
    {
        if (this == VeryLow) onVeryLow();
        else if (this == Low) onLow();
        else if (this == Medium) onMedium();
        else if (this == High) onHigh();
        else if (this == VeryHigh) onVeryHigh();
        else otherwise(Value);
    }
}
