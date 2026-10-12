using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The fraud result properties of the payment. Possible values:
/// * AMBER
/// * GREEN
/// * RED
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FraudResultType>))]
public sealed record FraudResultType : OpenStringEnum<FraudResultType>
{
    private FraudResultType(string value) : base(value)
    {
    }

    public static readonly FraudResultType Amber = new("AMBER");

    public static readonly FraudResultType Green = new("GREEN");

    public static readonly FraudResultType Red = new("RED");

    public TResult Match<TResult>(Func<TResult> onAmber,
        Func<TResult> onGreen,
        Func<TResult> onRed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Amber => onAmber(),
            _ when this == Green => onGreen(),
            _ when this == Red => onRed(),
            _ => otherwise(Value)
        };

    public void Match(Action onAmber, Action onGreen, Action onRed, Action<string> otherwise)
    {
        if (this == Amber) onAmber();
        else if (this == Green) onGreen();
        else if (this == Red) onRed();
        else otherwise(Value);
    }
}
