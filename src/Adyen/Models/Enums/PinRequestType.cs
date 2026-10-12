using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of PIN Service.
/// Possible values:
/// * <b>PINVerify</b>
/// * <b>PINVerifyOnly</b>
/// * <b>PINEnter</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PinRequestType>))]
public sealed record PinRequestType : OpenStringEnum<PinRequestType>
{
    private PinRequestType(string value) : base(value)
    {
    }

    public static readonly PinRequestType PinVerify = new("PINVerify");

    public static readonly PinRequestType PinVerifyOnly = new("PINVerifyOnly");

    public static readonly PinRequestType PinEnter = new("PINEnter");

    public TResult Match<TResult>(Func<TResult> onPinVerify,
        Func<TResult> onPinVerifyOnly,
        Func<TResult> onPinEnter,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PinVerify => onPinVerify(),
            _ when this == PinVerifyOnly => onPinVerifyOnly(),
            _ when this == PinEnter => onPinEnter(),
            _ => otherwise(Value)
        };

    public void Match(Action onPinVerify, Action onPinVerifyOnly, Action onPinEnter, Action<string> otherwise)
    {
        if (this == PinVerify) onPinVerify();
        else if (this == PinVerifyOnly) onPinVerifyOnly();
        else if (this == PinEnter) onPinEnter();
        else otherwise(Value);
    }
}
