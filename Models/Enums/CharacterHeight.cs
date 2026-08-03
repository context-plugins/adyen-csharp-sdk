using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>SingleHeight</b>
/// * <b>DoubleHeight</b>
/// * <b>HalfHeight</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CharacterHeight>))]
public sealed record CharacterHeight : StringEnum<CharacterHeight>
{
    private CharacterHeight(string value) : base(value)
    {
    }

    public static readonly CharacterHeight SingleHeight = new("SingleHeight");

    public static readonly CharacterHeight DoubleHeight = new("DoubleHeight");

    public static readonly CharacterHeight HalfHeight = new("HalfHeight");

    public static CharacterHeight FromValue(string value) => FromValueCore(value);
}
