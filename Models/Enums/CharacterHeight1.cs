using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Character height of the text string to display or print. Absence of this data element means the characters have normal height.
/// Possible values:
/// * <b>DoubleHeight</b>
/// * <b>HalfHeight</b>
/// * <b>SingleHeight</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CharacterHeight1>))]
public sealed record CharacterHeight1 : StringEnum<CharacterHeight1>
{
    private CharacterHeight1(string value) : base(value)
    {
    }

    public static readonly CharacterHeight1 SingleHeight = new("SingleHeight");

    public static readonly CharacterHeight1 DoubleHeight = new("DoubleHeight");

    public static readonly CharacterHeight1 HalfHeight = new("HalfHeight");

    public static CharacterHeight1 FromValue(string value) => FromValueCore(value);
}
