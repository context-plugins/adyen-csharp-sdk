using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The namespace that corresponds to the reason code.
/// <para>
/// Possible values:
/// *  <b>ukFpsRejectionCode</b>
/// *  <b>ukFpsReturnReasonCode</b>
/// *  <b>usAchReturnReasonCode</b>
/// *  <b>iso8583ResponseCode</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Namespace>))]
public sealed record Namespace : OpenStringEnum<Namespace>
{
    private Namespace(string value) : base(value)
    {
    }

    public static readonly Namespace Iso8583ResponseCode = new("iso8583ResponseCode");

    public static readonly Namespace UkFpsRejectionCode = new("ukFpsRejectionCode");

    public static readonly Namespace UkFpsReturnReasonCode = new("ukFpsReturnReasonCode");

    public static readonly Namespace UsAchReturnReasonCode = new("usAchReturnReasonCode");

    public TResult Match<TResult>(Func<TResult> onIso8583ResponseCode,
        Func<TResult> onUkFpsRejectionCode,
        Func<TResult> onUkFpsReturnReasonCode,
        Func<TResult> onUsAchReturnReasonCode,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Iso8583ResponseCode => onIso8583ResponseCode(),
            _ when this == UkFpsRejectionCode => onUkFpsRejectionCode(),
            _ when this == UkFpsReturnReasonCode => onUkFpsReturnReasonCode(),
            _ when this == UsAchReturnReasonCode => onUsAchReturnReasonCode(),
            _ => otherwise(Value)
        };

    public void Match(Action onIso8583ResponseCode,
        Action onUkFpsRejectionCode,
        Action onUkFpsReturnReasonCode,
        Action onUsAchReturnReasonCode,
        Action<string> otherwise)
    {
        if (this == Iso8583ResponseCode) onIso8583ResponseCode();
        else if (this == UkFpsRejectionCode) onUkFpsRejectionCode();
        else if (this == UkFpsReturnReasonCode) onUkFpsReturnReasonCode();
        else if (this == UsAchReturnReasonCode) onUsAchReturnReasonCode();
        else otherwise(Value);
    }
}
