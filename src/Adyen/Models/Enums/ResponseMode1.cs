using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Message response awaited by the initiator of the Request. Allows various types and synchronisation of requests for Print or Sound.
/// Possible values:
/// * <b>Immediate</b>
/// * <b>NotRequired</b>
/// * <b>PrintEnd</b>
/// * <b>SoundEnd</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResponseMode1>))]
public sealed record ResponseMode1 : OpenStringEnum<ResponseMode1>
{
    private ResponseMode1(string value) : base(value)
    {
    }

    public static readonly ResponseMode1 NotRequired = new("NotRequired");

    public static readonly ResponseMode1 Immediate = new("Immediate");

    public static readonly ResponseMode1 PrintEnd = new("PrintEnd");

    public static readonly ResponseMode1 SoundEnd = new("SoundEnd");

    public TResult Match<TResult>(Func<TResult> onNotRequired,
        Func<TResult> onImmediate,
        Func<TResult> onPrintEnd,
        Func<TResult> onSoundEnd,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotRequired => onNotRequired(),
            _ when this == Immediate => onImmediate(),
            _ when this == PrintEnd => onPrintEnd(),
            _ when this == SoundEnd => onSoundEnd(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotRequired,
        Action onImmediate,
        Action onPrintEnd,
        Action onSoundEnd,
        Action<string> otherwise)
    {
        if (this == NotRequired) onNotRequired();
        else if (this == Immediate) onImmediate();
        else if (this == PrintEnd) onPrintEnd();
        else if (this == SoundEnd) onSoundEnd();
        else otherwise(Value);
    }
}
