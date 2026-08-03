using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>SoundRef</b>
/// * <b>MessageRef</b>
/// * <b>Text</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SoundFormat>))]
public sealed record SoundFormat : StringEnum<SoundFormat>
{
    private SoundFormat(string value) : base(value)
    {
    }

    public static readonly SoundFormat SoundRef = new("SoundRef");

    public static readonly SoundFormat MessageRef = new("MessageRef");

    public static readonly SoundFormat Text = new("Text");

    public static SoundFormat FromValue(string value) => FromValueCore(value);
}
