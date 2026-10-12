using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Magnetic track or magnetic ink characters line.
/// Possible values:
/// * <b>ISO</b>
/// * <b>JIS-I</b>
/// * <b>JIS-II</b>
/// * <b>AAMVA</b>
/// * <b>CMC-7</b>
/// * <b>E-13B</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TrackFormat>))]
public sealed record TrackFormat : OpenStringEnum<TrackFormat>
{
    private TrackFormat(string value) : base(value)
    {
    }

    public static readonly TrackFormat Iso = new("ISO");

    public static readonly TrackFormat JisI = new("JIS-I");

    public static readonly TrackFormat JisIi = new("JIS-II");

    public static readonly TrackFormat Aamva = new("AAMVA");

    public static readonly TrackFormat Cmc7 = new("CMC-7");

    public static readonly TrackFormat E13B = new("E-13B");

    public TResult Match<TResult>(Func<TResult> onIso,
        Func<TResult> onJisI,
        Func<TResult> onJisIi,
        Func<TResult> onAamva,
        Func<TResult> onCmc7,
        Func<TResult> onE13B,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Iso => onIso(),
            _ when this == JisI => onJisI(),
            _ when this == JisIi => onJisIi(),
            _ when this == Aamva => onAamva(),
            _ when this == Cmc7 => onCmc7(),
            _ when this == E13B => onE13B(),
            _ => otherwise(Value)
        };

    public void Match(Action onIso,
        Action onJisI,
        Action onJisIi,
        Action onAamva,
        Action onCmc7,
        Action onE13B,
        Action<string> otherwise)
    {
        if (this == Iso) onIso();
        else if (this == JisI) onJisI();
        else if (this == JisIi) onJisIi();
        else if (this == Aamva) onAamva();
        else if (this == Cmc7) onCmc7();
        else if (this == E13B) onE13B();
        else otherwise(Value);
    }
}
