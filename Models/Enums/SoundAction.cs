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
public sealed record SoundAction : StringEnum<SoundAction>
{
    private SoundAction(string value) : base(value)
    {
    }

    public static readonly SoundAction StartSound = new("StartSound");

    public static readonly SoundAction StopSound = new("StopSound");

    public static readonly SoundAction SetDefaultVolume = new("SetDefaultVolume");

    public static SoundAction FromValue(string value) => FromValueCore(value);
}
