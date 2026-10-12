using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>NotRequired</b>
/// * <b>Immediate</b>
/// * <b>PrintEnd</b>
/// * <b>SoundEnd</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResponseMode>))]
public sealed record ResponseMode : OpenStringEnum<ResponseMode>
{
    private ResponseMode(string value) : base(value)
    {
    }

    public static readonly ResponseMode NotRequired = new("NotRequired");

    public static readonly ResponseMode Immediate = new("Immediate");

    public static readonly ResponseMode PrintEnd = new("PrintEnd");

    public static readonly ResponseMode SoundEnd = new("SoundEnd");

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
