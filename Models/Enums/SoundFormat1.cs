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
public sealed record SoundFormat1 : StringEnum<SoundFormat1>
{
    private SoundFormat1(string value) : base(value)
    {
    }

    public static readonly SoundFormat1 SoundRef = new("SoundRef");

    public static readonly SoundFormat1 MessageRef = new("MessageRef");

    public static readonly SoundFormat1 Text = new("Text");

    public static SoundFormat1 FromValue(string value) => FromValueCore(value);
}
