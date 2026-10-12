using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>MessageRef</b>
/// * <b>SoundRef</b>
/// * <b>Text</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SoundFormat1>))]
public sealed record SoundFormat1 : OpenStringEnum<SoundFormat1>
{
    private SoundFormat1(string value) : base(value)
    {
    }

    public static readonly SoundFormat1 SoundRef = new("SoundRef");

    public static readonly SoundFormat1 MessageRef = new("MessageRef");

    public static readonly SoundFormat1 Text = new("Text");

    public TResult Match<TResult>(Func<TResult> onSoundRef,
        Func<TResult> onMessageRef,
        Func<TResult> onText,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SoundRef => onSoundRef(),
            _ when this == MessageRef => onMessageRef(),
            _ when this == Text => onText(),
            _ => otherwise(Value)
        };

    public void Match(Action onSoundRef, Action onMessageRef, Action onText, Action<string> otherwise)
    {
        if (this == SoundRef) onSoundRef();
        else if (this == MessageRef) onMessageRef();
        else if (this == Text) onText();
        else otherwise(Value);
    }
}
