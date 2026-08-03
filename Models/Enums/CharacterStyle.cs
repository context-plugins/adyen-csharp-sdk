using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Normal</b>
/// * <b>Bold</b>
/// * <b>Italic</b>
/// * <b>Underline</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CharacterStyle>))]
public sealed record CharacterStyle : StringEnum<CharacterStyle>
{
    private CharacterStyle(string value) : base(value)
    {
    }

    public static readonly CharacterStyle Normal = new("Normal");

    public static readonly CharacterStyle Bold = new("Bold");

    public static readonly CharacterStyle Italic = new("Italic");

    public static readonly CharacterStyle Underline = new("Underline");

    public static CharacterStyle FromValue(string value) => FromValueCore(value);
}
