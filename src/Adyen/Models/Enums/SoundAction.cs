using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>StartSound</b>
/// * <b>StopSound</b>
/// * <b>SetDefaultVolume</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SoundAction>))]
public sealed record SoundAction : OpenStringEnum<SoundAction>
{
    private SoundAction(string value) : base(value)
    {
    }

    public static readonly SoundAction StartSound = new("StartSound");

    public static readonly SoundAction StopSound = new("StopSound");

    public static readonly SoundAction SetDefaultVolume = new("SetDefaultVolume");

    public TResult Match<TResult>(Func<TResult> onStartSound,
        Func<TResult> onStopSound,
        Func<TResult> onSetDefaultVolume,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == StartSound => onStartSound(),
            _ when this == StopSound => onStopSound(),
            _ when this == SetDefaultVolume => onSetDefaultVolume(),
            _ => otherwise(Value)
        };

    public void Match(Action onStartSound, Action onStopSound, Action onSetDefaultVolume, Action<string> otherwise)
    {
        if (this == StartSound) onStartSound();
        else if (this == StopSound) onStopSound();
        else if (this == SetDefaultVolume) onSetDefaultVolume();
        else otherwise(Value);
    }
}
